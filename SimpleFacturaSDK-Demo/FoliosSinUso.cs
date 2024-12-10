using SDKSimpleFactura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class FoliosSinUso : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        private SolicitarFolios SolicitarFolios;
        public FoliosSinUso()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
        }
    }
}
