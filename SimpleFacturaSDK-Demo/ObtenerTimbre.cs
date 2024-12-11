using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SimpleFacturaSDK_Demo.Helpers;
using SimpleFacturaSDK_Demo.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerTimbre : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ObtenerTimbre()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipoDTE_oT);
        }

        private void ObtenerTimbre_Load(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;
            tipoDTE_oT.SelectedIndex = 3;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
        }

        private void cancelarTimbre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void generarTimbre_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarTimbre);
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
                if (tipoDTE_oT.SelectedItem is ComboBoxItem selectedItem)
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

                    var response = await cliente.Facturacion.ObtenerTimbreDteAsync(request);
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
                            string filePath = Path.Combine(directoryPath, $"Timbre_{DateTime.Now:yyyyMMdd_HHmmss}.png");
                            byte[] imageBytes = Convert.FromBase64String(response.Data);
                            File.WriteAllBytes(filePath, imageBytes);
                            using (Form imageForm = new Form())
                            {
                                imageForm.Text = "Vista Previa del Timbre";
                                
                                imageForm.Icon = new Icon(Path.Combine(projectDirectory, "Resources", "log.ico"));
                                imageForm.Size = new Size(600, 400);
                                imageForm.StartPosition = FormStartPosition.CenterScreen;

                                PictureBox pictureBox = new PictureBox
                                {
                                    Image = Image.FromFile(filePath),
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    Dock = DockStyle.Fill
                                };
                                imageForm.Controls.Add(pictureBox);
                                imageForm.ShowDialog();
                            }

                            MessageBox.Show($"El Timbre se ha guardado correctamente en: {filePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al guardar el Timbre: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Manejo en caso de que no se seleccione ningún valor
                    MessageBox.Show("Por favor, selecciona un tipo de DTE válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarTimbre);
            }
        }
    }
}
