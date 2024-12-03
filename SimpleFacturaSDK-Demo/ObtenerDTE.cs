using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerDTE : Form
    {
        private AppSettings _appSettings;
        public ObtenerDTE()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipodte_oDTE);
        }

        private void ObtenerDTE_Load_1(object sender, EventArgs e)
        {
            var cliente = SimpleClientSingleton.Instance;
            tipodte_oDTE.SelectedIndex = 0;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
        }

        private void cancelarDte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultarDTE_Click(object sender, EventArgs e)
        {

        }
    }
}
