using System;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class Configuracion : Form
    {
        private AppSettings _appSettings;

        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            _appSettings = AppSettings.Load();
            textusername.Text = _appSettings.SDKSettings.Username;
            textpassword.Text = _appSettings.SDKSettings.Password;
            textbaseurl.Text = _appSettings.SDKSettings.BaseUrl;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            // Actualizar los valores en el modelo
            _appSettings.SDKSettings.Username = textusername.Text;
            _appSettings.SDKSettings.Password = textpassword.Text;
            _appSettings.SDKSettings.BaseUrl = textbaseurl.Text;

            // Guardar los cambios en appsettings.json
            _appSettings.Save();

            MessageBox.Show("Configuración guardada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
