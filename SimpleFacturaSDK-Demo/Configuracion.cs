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
            // Utilizar la instancia única de AppSettings
            _appSettings = AppSettings.Current;
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            // Cargar configuración del SDK
            textusername.Text = _appSettings.SDKSettings.Username;
            textpassword.Text = _appSettings.SDKSettings.Password;
            textbaseurl.Text = _appSettings.SDKSettings.BaseUrl;

            // Cargar credenciales (en memoria)
            textEmail.Text = _appSettings.Credenciales.EmailUsuario;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textRutContribuyente.Text = _appSettings.Credenciales.RutContribuyente;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(textusername.Text) ||
                string.IsNullOrWhiteSpace(textpassword.Text) ||
                string.IsNullOrWhiteSpace(textbaseurl.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar los valores en el modelo
            _appSettings.SDKSettings.Username = textusername.Text;
            _appSettings.SDKSettings.Password = textpassword.Text;
            _appSettings.SDKSettings.BaseUrl = textbaseurl.Text;

            _appSettings.Credenciales.EmailUsuario = textEmail.Text;
            _appSettings.Credenciales.RutEmisor = textRutEmisor.Text;
            _appSettings.Credenciales.RutContribuyente = textRutContribuyente.Text;
            _appSettings.Credenciales.NombreSucursal = textNombreSucursal.Text;

            // Guardar los cambios en appsettings.json
            _appSettings.Save();

            MessageBox.Show("Configuración guardada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void base_url_Click(object sender, EventArgs e)
        {

        }
    }
}
