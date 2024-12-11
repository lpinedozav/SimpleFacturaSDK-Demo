using SDKSimpleFactura;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class SolicitarFolios : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public SolicitarFolios()
        {
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            InitializeComponent();
        }

        private void SolicitarFolios_Load(object sender, EventArgs e)
        {
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE);
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            comboBoxCodigoTipoDTE.SelectedIndex = 3;
            numericCantidad.Value = 1;
        }
    }
}
