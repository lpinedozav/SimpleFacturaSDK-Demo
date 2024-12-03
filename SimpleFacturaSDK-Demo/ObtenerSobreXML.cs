using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerSobreXML : Form
    {
        private AppSettings _appSettings;
        public ObtenerSobreXML()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipodte_oSXML);
        }

        private void ObtenerSobreXML_Load(object sender, EventArgs e)
        {
            var cliente = SimpleClientSingleton.Instance;
            tipodte_oSXML.SelectedIndex = 0;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
        }
    }
}
