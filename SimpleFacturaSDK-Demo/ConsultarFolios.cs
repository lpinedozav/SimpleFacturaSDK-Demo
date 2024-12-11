using SDKSimpleFactura;
using SDKSimpleFactura.Models.Request;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

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
        }

        private async void generarConsultaFolios_Click(object sender, EventArgs e)
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
        }
    }
}
