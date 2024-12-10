using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using System;
using System.Windows.Forms;
using SimpleFacturaSDK_Demo.Helpers;
using System.Collections.Generic;
using SDKSimpleFactura.Models.Request;

namespace SimpleFacturaSDK_Demo
{
    public partial class ListarProductos : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        private List<ProductoExternoEnt> list;

        public ListarProductos()
        {
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            InitializeComponent();
        }

        private void ListarProductos_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
        }

        private async void generarListadoProductos_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Credenciales();
                request.RutEmisor = textRutEmisor.Text;
                request.NombreSucursal = textNombreSucursal.Text;
                var response = await cliente.Productos.ListarProductosAsync(request);
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    list = response.Data;
                    gridResultados.Rows.Clear();
                    gridResultados.CellContentClick += dataGridProductos_CellContentClick;
                    DataGridViewButtonCell detallesColumn = new DataGridViewButtonCell();
                    detallesColumn.Value = "Ver Impuestos";
                    detallesColumn.UseColumnTextForButtonValue = true;
                    gridResultados.AllowUserToAddRows = false;
                    foreach (var producto in list)
                    {
                        int rowIndex = gridResultados.Rows.Add(
                            //producto.ProductoId,
                            producto.Nombre,
                            FormattingHelper.FormatearPrecio((decimal)producto.Precio),
                            producto.Exento,
                            detallesColumn
                        );
                        DataGridViewRow row = gridResultados.Rows[rowIndex];
                        DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();

                        if (producto.Impuestos == null || producto.Impuestos.Count == 0)
                        {
                            // Configurar el botón como "Sin Impuestos" con estilo visual diferenciado
                            buttonCell.Value = "Sin Impuestos";
                            buttonCell.Style.ForeColor = System.Drawing.Color.Gray; // Cambiar el color del texto
                            buttonCell.Style.BackColor = System.Drawing.Color.LightGray; // Cambiar el color de fondo
                            buttonCell.FlatStyle = FlatStyle.Flat; // Asegurarse de usar estilo plano para aplicar colores
                        }
                        else
                        {
                            // Configurar el botón normalmente
                            buttonCell.Value = "Ver Impuestos";
                        }

                        row.Cells["impuestos"] = buttonCell;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de columna corresponda a la columna del botón y que no sea una fila de encabezado
            if (gridResultados.Columns[e.ColumnIndex].Name == "impuestos" && e.RowIndex >= 0)
            {
                // Obtén el reporte correspondiente a la fila seleccionada
                var reporte = list[e.RowIndex]; // Asegúrate de que 'list' esté accesible aquí

                // Supongamos que 'reporte.Detalles' es una lista de DetalleDte
                List<ImpuestoProductoExternoEnt> impuestos = reporte.Impuestos;

                // Llama al método para mostrar los detalles
                MostrarDetallesEnOtraTabla(impuestos);
            }
        }
        private void MostrarDetallesEnOtraTabla(List<ImpuestoProductoExternoEnt> impuestos)
        {
            if (impuestos == null || impuestos.Count == 0)
            {
                MessageBox.Show("No hay impuestos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear y mostrar el formulario de detalles
            Detalles detallesForm = new Detalles();
            detallesForm.SetDetalles(impuestos, "Impuestos");
            detallesForm.ShowDialog();
        }
    }
}
