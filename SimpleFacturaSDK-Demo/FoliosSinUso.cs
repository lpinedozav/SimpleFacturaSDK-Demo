using SDKSimpleFactura;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;
using static SDKSimpleFactura.Enum.Ambiente;
using SimpleFacturaSDK_Demo.Models;
using SDKSimpleFactura.Models.Request;
using System.Diagnostics;

namespace SimpleFacturaSDK_Demo
{
    public partial class FoliosSinUso : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public FoliosSinUso()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipodte_Folio);
        }

        private void FoliosSinUso_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            tipodte_Folio.SelectedIndex = 3;
            textDocumentacion.Text = "folios sin uso";
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

                if (tipodte_Folio.SelectedItem is ComboBoxItem selectedItem)
                {
                    var tipoDte = (int)selectedItem.Value;
                    var request = new SolicitudFoliosRequest
                    {
                        RutEmpresa = textRutEmisor.Text,
                        TipoDTE = tipoDte,
                        Ambiente = (int)ambienteSeleccionado
                    };
                    var response = await cliente.Folio.FoliosSinUsoAsync(request);

                    if (response.Status == 200)
                    {
                        var listaFoliosSinUso = response.Data; 

                        if (listaFoliosSinUso == null || !listaFoliosSinUso.Any())
                        {
                            MessageBox.Show("No se encontraron folios sin uso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridResultados.DataSource = null;
                            gridResultados.Columns.Clear();
                            return;
                        }
                        gridResultados.DataSource = null;
                        gridResultados.DataSource = listaFoliosSinUso;
                    }
                    else
                    {
                        MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            string urlDocFolioSinUso = "https://documentacion.simplefactura.cl/#81e62ff5-a1e1-4daa-a553-6fa241c378e7";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = urlDocFolioSinUso,
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
