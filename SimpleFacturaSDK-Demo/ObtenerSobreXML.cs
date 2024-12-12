using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Models.Facturacion;
using SimpleFacturaSDK_Demo.Helpers;
using SimpleFacturaSDK_Demo.Models;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerSobreXML : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ObtenerSobreXML()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipodte_oSXML);
        }

        private void ObtenerSobreXML_Load(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;
            tipodte_oSXML.SelectedIndex = 3;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
        }
        private async void generarSXML_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarSXML);
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
                TipoSobreEnvio tipoSobreEnvioSeleccioando;
                if (radioAlSII.Checked)
                {
                    tipoSobreEnvioSeleccioando = TipoSobreEnvio.AlSII;
                }
                else if (radioAlReceptor.Checked)
                {
                    tipoSobreEnvioSeleccioando = TipoSobreEnvio.AlReceptor;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un tipo sobre envio (Al SII o Al Receptor).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (tipodte_oSXML.SelectedItem is ComboBoxItem selectedItem)
                {
                    var tipoDte = (DTEType)selectedItem.Value;
                    var request = new SolicitudDte
                    {
                        Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(),
                        DteReferenciadoExterno = new DteReferenciadoExterno()
                    };

                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.DteReferenciadoExterno.Folio = (int)folio_oPDF.Value;
                    request.DteReferenciadoExterno.CodigoTipoDte = (int)tipoDte;
                    request.DteReferenciadoExterno.Ambiente = (int)ambienteSeleccionado;
                    var response = await cliente.Facturacion.ObtenerSobreXmlDteAsync(request, tipoSobreEnvioSeleccioando);
                    if ((int)response.Status == 400 || (int)response.Status == 500)
                    {
                        MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                            string directoryPath = Path.Combine(projectDirectory, "Files");
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }
                            string filePath = Path.Combine(directoryPath, $"XML_{DateTime.Now:yyyyMMdd_HHmmss}.xml");
                            File.WriteAllBytes(filePath, response.Data);

                            // Abrir el archivo XML en el navegador predeterminado
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = filePath,
                                UseShellExecute = true
                            });

                            MessageBox.Show($"El XML se ha guardado correctamente en: {filePath}\nSe ha abierto en el navegador.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al guardar o abrir el XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    // Manejo en caso de que no se seleccione ningún valor
                    MessageBox.Show("Por favor, selecciona un tipo de DTE válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarSXML);
            }
        }

        private void linkLabelSobreXml_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://documentacion.simplefactura.cl/#1a8af57d-24e2-41c1-a596-42abc06ed54c";

            // Abrir la URL en el navegador predeterminado
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
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
