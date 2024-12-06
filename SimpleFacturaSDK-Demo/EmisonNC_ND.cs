using System;
using SDKSimpleFactura;
using System.Windows.Forms;
using SimpleFacturaSDK_Demo.Helpers;
using static SDKSimpleFactura.Enum.TipoDTE;
using System.Linq;
using SDKSimpleFactura.Enum;

namespace SimpleFacturaSDK_Demo
{
    public partial class EmisonNC_ND : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public EmisonNC_ND()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE, value => value == DTEType.NotaDebitoElectronica || value == DTEType.NotaCreditoElectronica);
            EnumHelper.LlenarComboBoxConEnum<FormaPago.FormaPagoEnum>(comboBoxFormaPago);
        }
        private void EmisonNC_ND_Load(object sender, EventArgs e)
        {
            //Identificacion
            comboBoxCodigoTipoDTE.SelectedIndex = 1; // nota credito electronica
            comboBoxFormaPago.SelectedIndex = 1;
            fechaEmision.Value = DateTime.Parse("2022-12-05");
            fechaVencimiento.Value = DateTime.Now.AddMonths(6);
            //Datos emisor
            textRUTEmisor.Text = _appSettings.emisor.RUTEmisor;
            correo_emisor.Text = _appSettings.emisor.CorreoEmisor;
            textCiudadEmisor.Text = _appSettings.emisor.CiudadOrigen;
            textTelefonEmisor.Text = _appSettings.emisor.Telefono.First();
            razonSocial_Emisor.Text = _appSettings.emisor.RznSoc;
            textGiroEmisor.Text = _appSettings.emisor.GiroEmis;
            textDireccionEmisor.Text = _appSettings.emisor.DirOrigen;
            textComunaEmisor.Text = _appSettings.emisor.CmnaOrigen;
            textActividadEconomica.Text = _appSettings.emisor.Acteco.First().ToString();
            //Datos receptor
            textRutReceptor.Text = "10422710-4";
            textCorreoReceptor.Text = "mvega@chilesystems.com";
            textCiudadReceptor.Text = "Santiago";
            textRznReceptor.Text = "McL";
            textGiroReceptor.Text = "test";
            textDirReceptor.Text = "Pensamientos 2308";
            textCmnReceptor.Text = "Paine";
            //Productos
            gridProductos.Rows.Add(
                1,
                "test",
                1,
                "KL",
                200,
                200
                );
            //Referencias
            gridReferencias.Rows.Add(
                1,
                "34",
                "367",
                DateTime.Parse("2022-12-06").ToString("dd/MM/yyyy"),
                3,
                "Corrige Monto DTE: test"
                );
            //Totales
            textMontoExento.Text = "200";
            textMontoTotal.Text = "200";
        }

        private void generarNcNd_Click(object sender, EventArgs e)
        {

        }
    }
}
