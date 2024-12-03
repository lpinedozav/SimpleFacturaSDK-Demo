using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerXML : Form
    {
        private AppSettings _appSettings;
        public ObtenerXML()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipodte_oXML);
        }

        private void ObtenerXML_Load(object sender, EventArgs e)
        {
            var cliente = SimpleClientSingleton.Instance;
            tipodte_oXML.SelectedIndex = 0;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
        }

        private void cancelarXml_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
