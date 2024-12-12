using System;
using System.Collections.Generic;
using System.Linq;
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

            //Cargar Emisor (en memoria)
            textEmisor.Text = _appSettings.emisor.RUTEmisor;
            textRazonsocial.Text = _appSettings.emisor.RznSoc;
            textGiro.Text = _appSettings.emisor.GiroEmis;
            textTelefono.Text = _appSettings.emisor.Telefono.FirstOrDefault();
            textCorreo.Text = _appSettings.emisor.CorreoEmisor;
            numericAzteco.Value = _appSettings.emisor.Acteco.FirstOrDefault();
            textDireccion.Text = _appSettings.emisor.DirOrigen;
            textComuna.Text = _appSettings.emisor.CmnaOrigen;
            textCiudad.Text = _appSettings.emisor.CiudadOrigen;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(guardar);
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

            _appSettings.emisor.RUTEmisor = textEmisor.Text;
            _appSettings.emisor.RznSoc = textRazonsocial.Text;
            _appSettings.emisor.GiroEmis = textGiro.Text;
            _appSettings.emisor.Telefono = new List<string> { textTelefono.Text };
            _appSettings.emisor.CorreoEmisor = textCorreo.Text;
            _appSettings.emisor.Acteco = new List<int> { (int)numericAzteco.Value };
            _appSettings.emisor.DirOrigen = textDireccion.Text;
            _appSettings.emisor.CmnaOrigen = textComuna.Text;
            _appSettings.emisor.CiudadOrigen = textCiudad.Text;

            // Guardar los cambios en appsettings.json
            _appSettings.Save();
            try
            {
                SimpleClientSingleton.ResetClient();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Configuración guardada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Loading.HideLoading(guardar);
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
