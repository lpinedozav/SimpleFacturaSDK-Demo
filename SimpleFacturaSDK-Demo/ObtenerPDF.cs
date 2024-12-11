using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using SimpleFacturaSDK_Demo.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerPDF : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;

        public ObtenerPDF()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipodte_oPDF);
        }
        private void ObtenerPDF_Load(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;
            tipodte_oPDF.SelectedIndex = 3; // factura electronica por defecto
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            textRutContribuyente.Text = _appSettings.Credenciales.RutContribuyente;

            ChangeUI();
        }

     
        private async void generarPdf_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarpdf);
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
                    // Si no se selecciona ningún ambiente, mostrar un mensaje
                    MessageBox.Show("Por favor, selecciona un ambiente (Certificación o Producción).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Response<byte[]> response;
                if (radioButton_emitidoPdf.Checked)
                {
                    var request = new SolicitudDte
                    {
                        Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(), // Inicializamos Credenciales
                        DteReferenciadoExterno = new DteReferenciadoExterno() // Inicializamos DteReferenciadoExterno
                    };
                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.Credenciales.NombreSucursal = textNombreSucursal.Text;
                    request.DteReferenciadoExterno.Folio = (int)folio_oPDF.Value;
                    request.DteReferenciadoExterno.CodigoTipoDte = (int)EnumHelper.ObtenerValorSeleccionado<DTEType>(tipodte_oPDF);
                    request.DteReferenciadoExterno.Ambiente = (int)ambienteSeleccionado;
                    response = await cliente.Facturacion.ObtenerPdfDteAsync(request);
                }
                else
                {
                    var request = new SDKSimpleFactura.Models.Request.ListaDteRequest()
                    {
                        Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(), // Inicializamos Credenciales
                    };
                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.Credenciales.RutContribuyente = textRutContribuyente.Text;
                    request.CodigoTipoDte = EnumHelper.ObtenerValorSeleccionado<DTEType>(tipodte_oPDF);
                    request.Ambiente = ambienteSeleccionado;
                    request.Folio = (int)folio_oPDF.Value;
                    response = await cliente.Proveedores.ObtenerPDFAsync(request);
                }
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        // Obtener el directorio del proyecto (dos niveles hacia arriba desde bin/Debug)
                        string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

                        // Construir la ruta de la carpeta "Files" dentro del directorio del proyecto
                        string directoryPath = Path.Combine(projectDirectory, "Files");

                        // Crear la carpeta si no existe
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        // Ruta completa para guardar el archivo
                        string filePath = Path.Combine(directoryPath, $"DTE_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

                        // Guardar los datos en el archivo
                        File.WriteAllBytes(filePath, response.Data);

                        // Notificar al usuario
                        DialogResult result = MessageBox.Show($"El PDF se ha guardado correctamente en: {filePath}\n¿Desea abrir el archivo ahora?",
                                                                "Éxito",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            // Abrir el PDF
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = filePath,
                                UseShellExecute = true
                            });
                        }

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                // Manejo de errores si es necesario
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarpdf);
            }
        }

        private void radioButton_emitidoPdf_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUI();
        }
        private void radioButton_recibidoPdf_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUI();
        }
        private void ChangeUI()
        {
            if (radioButton_emitidoPdf.Checked) { textRutContribuyente.Enabled = false; textNombreSucursal.Enabled = true; folio_oPDF.Value = 4117; }
            if (radioButton_recibidoPdf.Checked) { textNombreSucursal.Enabled = false; textRutContribuyente.Enabled = true; folio_oPDF.Value = 2232; }
        }
    }
}
