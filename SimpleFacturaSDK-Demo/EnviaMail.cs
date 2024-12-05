using SDKSimpleFactura;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class EnviarMail : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public EnviarMail()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboxTipoDte);
        }

        private void EnviarMail_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            numericFolio.Value = 2149;
            comboxTipoDte.SelectedIndex = 3;
            textPara.Text = "contacto@chilesystems.com";
            textCC.Text = "correo2@gmail.com";
            textCCO.Text = "correo@gmail.com";
            checkXML.Checked = true;
            checkPDF.Checked = true;
            textComentario.Text = "ESTO ES UN COMENTARIO";
        }
    }
}
