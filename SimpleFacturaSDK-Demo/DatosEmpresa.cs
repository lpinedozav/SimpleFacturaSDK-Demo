using SDKSimpleFactura;
using System;
using SDKSimpleFactura.Models.Facturacion;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using SDKSimpleFactura.Models.Response;
using SDKSimpleFactura.Models.Request;

namespace SimpleFacturaSDK_Demo
{
    public partial class DatosEmpresa : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        private List<EmisorApiEnt> emisorApiEnts;
        public DatosEmpresa()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
        }

        private void DatosEmpresa_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            gridResultados.CellContentClick += dataGridDatosEmpresa_CellContentClick;
        }

        private async void generarDatosEmpresa_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarDatosEmpresa);
            try
            {
                var request = new Credenciales();
                request.RutEmisor = textRutEmisor.Text;
                var response = await cliente.Configuracion.DatosEmpresaAsync(request);

                if (response.Status == 200)
                {

                    emisorApiEnts = new List<EmisorApiEnt> { response.Data };

                    if (emisorApiEnts == null || !emisorApiEnts.Any())
                    {
                        MessageBox.Show("No se encontraron datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    gridResultados.DataSource = null;
                    gridResultados.DataSource = emisorApiEnts;



                }
                else
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarDatosEmpresa);
            }
        }

        private void dataGridDatosEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haya hecho clic en una fila válida y en la columna del botón
            if (e.RowIndex >= 0 && gridResultados.Columns[e.ColumnIndex].Name == "colActividadesEconomicas")
            {
                var reporte = emisorApiEnts[e.RowIndex];
                List<ActividadeconomicaApiEnt> actividadesEconomicas = reporte.ActividadesEconomicas;
                MostrarDetallesEnOtraTabla(actividadesEconomicas);
            }
        }

        private void MostrarDetallesEnOtraTabla(List<ActividadeconomicaApiEnt> actividadeconomicaApiEnts)
        {
            if (actividadeconomicaApiEnts == null || actividadeconomicaApiEnts.Count == 0)
            {
                MessageBox.Show("No hay actividades económicas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear y mostrar el formulario de detalles
            Detalles detallesForm = new Detalles();
            detallesForm.SetDetalles(actividadeconomicaApiEnts, "Actividades Económicas");
            detallesForm.ShowDialog();
        }

    }
}
