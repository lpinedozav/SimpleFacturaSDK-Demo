using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Response;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class ConciliarEmitidos_Recibidos : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ConciliarEmitidos_Recibidos()
        {
            _appSettings = AppSettings.Current;
            InitializeComponent();
        }

        private void ConciliarEmitidos_Load(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textMes.Value = 12;
            textAnio.Value = 2024;

            UpdateUIBasedOnSelection();
        }

        private async void generarEmitidos_Click(object sender, EventArgs e)
        {
            // Show the loading indicator on the button (or another control if you prefer)
            Loading.ShowLoading(generarEmitidos);

            try
            {
                var request = new Credenciales();
                request.RutEmisor = textRutEmisor.Text;
                var mes = (int)textMes.Value;
                var anio = (int)textAnio.Value;

                // Perform the asynchronous API call
                Response<string> response;
                if (radio_Bton_emitidoConciliar.Checked) 
                { 
                    response = await cliente.Facturacion.ConciliarEmitidosAsync(request, mes, anio);
                   
                }
                else
                {
                    response = await cliente.Proveedores.ConciliarRecibidosAsync(request, mes, anio);
                  
                }

                if (response.Status != 200)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textRespuesta.Text = $"Estado: {response.Status}\r\n" +
                                         $"Mensaje: {response.Message}\r\n" +
                                         $"Datos: {response.Data ?? "Ninguno"}\r\n" +
                                         $"Errores: {(response.Errors != null ? string.Join(", ", response.Errors) : "Ninguno")}\r\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Loading.HideLoading(generarEmitidos);
            }
        }

        private void linkLabelConciliar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Definir las URLs para emitido y recibido
            string emitidoConciliarUrl = "https://documentacion.simplefactura.cl/#561052ea-921b-4637-8669-23da17774d20";
            string recibidoConciliarUrl = "https://documentacion.simplefactura.cl/#84200982-26b0-4473-9078-67dbb781043b"; 

            // Determinar cuál URL usar en función del RadioButton seleccionado
            string url;
            if (radio_Bton_emitidoConciliar.Checked)
            {
                url = emitidoConciliarUrl;
            }
            else if (radio_Bton_recibidoConciliar.Checked)
            {
                url = recibidoConciliarUrl;
            }
            else
            {
                MessageBox.Show("Selecciona una opción antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar abrir la URL en el navegador predeterminado
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

        private const string BaseDescripcion = "permite la consolidación de datos del Servicio de Impuestos Internos (SII)," +
                                       "accediendo al registro de {0} y extrayendo la información correspondiente a los parámetros especificados en la petición," +
                                       "actualizando los datos de \"Documentos {1}\" de SimpleFactura.";


        private void UpdateUIBasedOnSelection()
        {
            // Determinar los valores para el texto según el estado
            if (radio_Bton_emitidoConciliar.Checked)
            {
                textDocumentacion.Text = string.Format(BaseDescripcion, "ventas", "Emitidos");
            }
            else
            {
                textDocumentacion.Text = string.Format(BaseDescripcion, "compras", "Recibidos");
            }
        }

        private void radio_Bton_recibidoConciliar_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUIBasedOnSelection();
        }

        private void radio_Bton_emitidoConciliar_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUIBasedOnSelection();
        }
    }
}
