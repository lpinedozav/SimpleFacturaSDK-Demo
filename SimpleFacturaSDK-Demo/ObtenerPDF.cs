using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SimpleFacturaSDK_Demo.Helpers;
using SimpleFacturaSDK_Demo.Models;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
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
            tipodte_oPDF.SelectedIndex = 0;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private async void generarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                // Aquí puedes usar la variable rutaGuardado para guardar el PDF
               // MessageBox.Show($"El PDF se guardará en: {rutaGuardado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Continuar con el proceso de generación del PDF...
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
                // Obtener el valor seleccionado del ComboBox
                if (tipodte_oPDF.SelectedItem is ComboBoxItem selectedItem)
                {
                    var tipoDte = (DTEType)selectedItem.Value; // Obtener el enum seleccionado
                    var request = new SolicitudDte
                    {
                        Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(), // Inicializamos Credenciales
                        DteReferenciadoExterno = new DteReferenciadoExterno() // Inicializamos DteReferenciadoExterno
                    };

                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.Credenciales.NombreSucursal = textNombreSucursal.Text;
                    request.DteReferenciadoExterno.Folio = (int)folio_oPDF.Value;

                    // Asignar el valor del tipo de DTE seleccionado
                    request.DteReferenciadoExterno.CodigoTipoDte = (int)tipoDte;
                    request.DteReferenciadoExterno.Ambiente = (int)ambienteSeleccionado;

                    // Crear un mensaje con los valores que deseas mostrar
                    string mensaje = $"Datos.\n" +
                                     $"Rut Emisor: {request.Credenciales.RutEmisor}\n" +
                                     $"Nombre Sucursal: {request.Credenciales.NombreSucursal}\n" +
                                     $"Folio: {request.DteReferenciadoExterno.Folio}\n" +
                                     $"Código Tipo DTE: {request.DteReferenciadoExterno.CodigoTipoDte}\n" +
                                     $"Ambiente: {request.DteReferenciadoExterno.Ambiente}";
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var response = await cliente.Facturacion.ObtenerPdfDteAsync(request);
                    if ((int)response.Status == 400 || (int)response.Status == 500)
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
                            MessageBox.Show($"El PDF se ha guardado correctamente en: {filePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al guardar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Manejo de errores si es necesario
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void radioCertificacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancelarpdf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

       
    }
}
