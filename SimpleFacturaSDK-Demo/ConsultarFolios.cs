using SDKSimpleFactura;
using SDKSimpleFactura.Models.Request;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;
using static System.Net.WebRequestMethods;

namespace SimpleFacturaSDK_Demo
{
    public partial class ConsultarFolios : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ConsultarFolios()
        {
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            InitializeComponent();
        }

        private void ConsultarFolios_Load(object sender, EventArgs e)
        {
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE);
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            comboBoxCodigoTipoDTE.SelectedIndex = 3;
            radioCertificacion.Checked = true;
            textDocumentacion.Text = "consultar folios";
        }

        private async void generarConsultaFolios_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarConsultaFolios);
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
                FolioRequest request = new FolioRequest();
                request.Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales();
                request.Credenciales.RutEmisor = textRutEmisor.Text;
                request.Credenciales.NombreSucursal = textNombreSucursal.Text;
                request.Ambiente = (int)ambienteSeleccionado;
                request.CodigoTipoDte = EnumHelper.ObtenerValorSeleccionado<DTEType>(comboBoxCodigoTipoDTE);
                var response = await cliente.Folio.ConsultarFoliosAsync(request);
                if (response.Status != 200)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var list = response.Data;
                    
                    gridResultados.DataSource = null;
                    gridResultados.DataSource = list;
                    foreach (DataGridViewColumn column in gridResultados.Columns)
                    {
                        if (column.ValueType == typeof(DateTime))
                        {
                            column.DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                    }

                    gridResultados.Refresh();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarConsultaFolios);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlDocConsultarFolios = "https://documentacion.simplefactura.cl/#e65dabf9-08c3-4906-94d7-8105e4fc1fae";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = urlDocConsultarFolios,
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
