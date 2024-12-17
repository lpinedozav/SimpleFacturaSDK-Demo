using SDKSimpleFactura;
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

        }
    }
}
