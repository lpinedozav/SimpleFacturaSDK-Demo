using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerTrazasEmitidas_Recibidas : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ObtenerTrazasEmitidas_Recibidas()
        {
            cliente = SimpleClientSingleton.Instance;
            _appSettings = AppSettings.Current;
            InitializeComponent();
        }

        private void ObtenerTrazasEmitidas_Recibidas_Load(object sender, EventArgs e)
        {
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBox_codigoTipoDTE);
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            comboBox_codigoTipoDTE.SelectedIndex = 3;
            radioCertificacion.Checked = true;
        }
        private void ChangeUI()
        {
            if (radioButton_emitido.Checked)
            {
                textRutContribuyente.Enabled = false;
                folio_oPDF.Value = 8597;
                textDocumentacion.Text = "Permite obtener las trazas del DTE emitido basado en el folio, tipo DTE, ambiente y el rut del emisor.";
            }
            else if (radioButton_recibido.Checked)
            {
                textRutContribuyente.Enabled = true;
                folio_oPDF.Value = 2232;
                textRutContribuyente.Text = "76269769-6";
                textDocumentacion.Text = "Permite obtener las trazas del DTE recibido basado en el folio, tipo DTE, ambiente, rut emisor y el rut proveedor.";
            }
        }

        private void radioButton_emitido_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUI();
        }

        private void radioButton_recibido_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUI();
        }

        private async void obtener_trazas_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(obtener_trazas);
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
                Response<List<TrazasEnt>> response;
                var request = new SolicitudDte
                {
                    Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(), // Inicializamos Credenciales
                    DteReferenciadoExterno = new DteReferenciadoExterno() // Inicializamos DteReferenciadoExterno
                };
                if (radioButton_emitido.Checked)
                {
                    
                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.DteReferenciadoExterno.Folio = (int)folio_oPDF.Value;
                    request.DteReferenciadoExterno.CodigoTipoDte = (int)EnumHelper.ObtenerValorSeleccionado<DTEType>(comboBox_codigoTipoDTE);
                    request.DteReferenciadoExterno.Ambiente = (int)ambienteSeleccionado;
                    response = await cliente.Facturacion.GetTrazasEmitidosAsync(request);
                }
                else
                {
                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.Credenciales.RutContribuyente = textRutContribuyente.Text;
                    request.DteReferenciadoExterno.Folio = (int)folio_oPDF.Value;
                    request.DteReferenciadoExterno.CodigoTipoDte = (int)EnumHelper.ObtenerValorSeleccionado<DTEType>(comboBox_codigoTipoDTE);
                    request.DteReferenciadoExterno.Ambiente = (int)ambienteSeleccionado;
                    response = await cliente.Proveedores.GetTrazasRecibidosAsync(request);
                }
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (response.Data == null) 
                    {
                        MessageBox.Show("No se encontraron trazas","Éxito",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                        Loading.HideLoading(obtener_trazas);
                        return;
                    }
                    gridTrazas.DataSource = null;
                    gridTrazas.DataSource = response.Data;
                    gridTrazas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    var fechaCol = gridTrazas.Columns["fecha"];
                    if (fechaCol != null)
                    {
                        fechaCol.DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Loading.HideLoading(obtener_trazas);
            }
        }

    }

}
