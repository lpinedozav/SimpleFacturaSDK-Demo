using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerTimbre : Form
    {
        private AppSettings _appSettings;
        public ObtenerTimbre()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipoDTE_oT);
        }

        private void ObtenerTimbre_Load(object sender, EventArgs e)
        {
            var cliente = SimpleClientSingleton.Instance;
            tipoDTE_oT.SelectedIndex = 0;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
        }

        private void cancelarTimbre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
