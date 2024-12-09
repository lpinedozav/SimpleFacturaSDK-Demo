using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class Acuse : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public Acuse()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE);
            EnumHelper.LlenarComboBoxConEnum<ResponseType>(comboBoxRespuesta);
            EnumHelper.LlenarComboBoxConEnum<RejectionType>(comboBoxTipoRechazo);

        }

        private void Acuse_Load(object sender, EventArgs e)
        {
            //credenciales
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textRutContribuyente.Text = _appSettings.Credenciales.RutContribuyente;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            //
        }
    }
}
