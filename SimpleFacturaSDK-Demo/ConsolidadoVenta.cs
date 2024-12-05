using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Request;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;

namespace SimpleFacturaSDK_Demo
{
    public partial class ConsolidadoVenta : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        private List<ReporteDTE> list;

        public ConsolidadoVenta()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
        }

        private void ConsolidadoVenta_Load(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;

            textRut.Text = _appSettings.Credenciales.RutEmisor;
        }

        private async void generarConsolidadoV_Click(object sender, EventArgs e)
        {
            try
            {
                AmbienteEnum ambienteSeleccionado;

                if (radioCertificacion.Checked)
                {
                    ambienteSeleccionado = AmbienteEnum.Certificacion;
                }
                else if (radioProduccion.Checked)
                {
                    ambienteSeleccionado = AmbienteEnum.Produccion;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un ambiente (Certificación o Producción).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var request = new ListaDteRequest()
                {
                    Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales()
                };
                request.Credenciales.RutEmisor = textRut.Text;
                request.Desde = dateTimeDesde.Value;
                request.Hasta = dateTimeHasta.Value;
                request.Ambiente = ambienteSeleccionado;
                var response = await cliente.Facturacion.ConsolidadoVentasAsync(request);
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    list = response.Data;

                   
                    dataGridConsolidado.Rows.Clear();
                    dataGridConsolidado.CellContentClick += dataGridConsolidado_CellContentClick;
                    DataGridViewButtonCell detallesColumn = new DataGridViewButtonCell();
                    detallesColumn.Value = "Ver Detalles";
                    detallesColumn.UseColumnTextForButtonValue = true; // Hace que todas las celdas muestren el mismo texto en el botón
                                                                       // Recorre cada objeto RepoteDTE en la lista
                    dataGridConsolidado.AllowUserToAddRows = false;

                    foreach (var reporte in list)
                    { 
                        int rowIndex = dataGridConsolidado.Rows.Add(
                            reporte.Fecha.ToString("dd/MM/yyyy"),
                            reporte.TiposDTE,
                            reporte.Emitidos,
                            reporte.Anulados,
                            reporte.TotalNeto,
                            reporte.TotalExento,
                            reporte.TotalIva,
                            reporte.Total,
                            detallesColumn
                        );
                        DataGridViewRow row = dataGridConsolidado.Rows[rowIndex];
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)row.Cells["detalle"];
                        buttonCell.Value = "Ver Detalles";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridConsolidado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de columna corresponda a la columna del botón y que no sea una fila de encabezado
            if (dataGridConsolidado.Columns[e.ColumnIndex].Name == "detalle" && e.RowIndex >= 0)
            {
                // Obtén el reporte correspondiente a la fila seleccionada
                var reporte = list[e.RowIndex]; // Asegúrate de que 'list' esté accesible aquí

                // Supongamos que 'reporte.Detalles' es una lista de DetalleDte
                List<DetalleDte> detalles = reporte.Detalle;

                // Llama al método para mostrar los detalles
                MostrarDetallesEnOtraTabla(detalles);
            }
        }
        private void MostrarDetallesEnOtraTabla(List<DetalleDte> detalles)
        {
            if (detalles == null || detalles.Count == 0)
            {
                MessageBox.Show("No hay detalles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear y mostrar el formulario de detalles
            Detalles detallesForm = new Detalles();
            detallesForm.SetDetalles(detalles);
            detallesForm.ShowDialog();
        }
        private void textRut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
