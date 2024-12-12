using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using System;
using System.Windows.Forms;
using SimpleFacturaSDK_Demo.Helpers;
using System.Collections.Generic;
using SDKSimpleFactura.Models.Request;
using System.Diagnostics;

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
            textDocumentacion.Text = "Permite generar listado de Productos, de acuerdo a Emisor y Sucursal indicados en Json.";
            gridResultados.CellContentClick += dataGridProductos_CellContentClick;
        }

        private async void generarListadoProductos_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarListadoProductos);
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

                    gridResultados.DataSource = null;
                    gridResultados.DataSource = list;

                    ConfigurarColumnasBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarListadoProductos);
            }
        }
        private void ConfigurarColumnasBotones()
        {
            if (gridResultados.Columns["impuestos"] == null)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                {
                    Name = "impuestos",
                    HeaderText = "Impuestos",
                    Text = "Ver Impuestos",
                    UseColumnTextForButtonValue = true
                };

                gridResultados.Columns.Add(buttonColumn);
            }
            else
            {
                foreach (DataGridViewRow row in gridResultados.Rows)
                {
                    if (row.Cells["impuestos"] is DataGridViewButtonCell buttonCell)
                    {
                        var producto = (ProductoExternoEnt)row.DataBoundItem;

                        if (producto?.Impuestos == null || producto.Impuestos.Count == 0)
                        {
                            buttonCell.Value = "Sin Impuestos";
                            buttonCell.Style.ForeColor = System.Drawing.Color.Gray;
                            buttonCell.Style.BackColor = System.Drawing.Color.LightGray;
                            buttonCell.FlatStyle = FlatStyle.Flat;
                        }
                        else
                        {
                            buttonCell.Value = "Ver Impuestos";
                            buttonCell.Style.ForeColor = System.Drawing.Color.Black;
                            buttonCell.Style.BackColor = System.Drawing.Color.White;
                            buttonCell.FlatStyle = FlatStyle.Flat;
                        }
                    }
                }
            }
            gridResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridResultados.AllowUserToAddRows = false;
        }

        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridResultados.Columns[e.ColumnIndex].Name == "impuestos" && e.RowIndex >= 0)
            {
                var reporte = list[e.RowIndex];
                List<ImpuestoProductoExternoEnt> impuestos = reporte.Impuestos;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlDocListProducts = "https://documentacion.simplefactura.cl/#47940f71-b51e-4e46-b8d6-37499c1af38e";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = urlDocListProducts,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir la URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
