using SDKSimpleFactura;
using System;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class ListadoDteEmitidos : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ListadoDteEmitidos()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
        }

        private void ListadoDteEmitidos_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textRutContribuyente.Text = _appSettings.Credenciales.RutContribuyente;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;

        }
    }
}
