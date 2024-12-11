using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Models.Request;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class AgregarCliente : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public AgregarCliente()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            //Credenciales
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            //Cliente
            textRutCliente.Text = "57681892-0";
            textRazonCliente.Text = "Cliente Test 1";
            textCiudadCliente.Text = "Ciudad 1";
            textComunaCliente.Text = "Comuna 1";
            textCorreoFacCliente.Text = "direccion 1";
            textCorreoParCliente.Text = "direccion 2";
            textDireccionFacCliente.Text = "correo 1";
            textDireccionParCliente.Text = "correo 2";
            textGiroCliente.Text = "Giro 1";
        }

        private async void generarAgregarCliente_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarAgregarCliente);
            try
            {
                var request = new DatoExternoRequest()
                {
                    Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(),
                    Clientes = new List<NuevoReceptorExternoRequest>()
                };
                request.Credenciales.RutEmisor = textRutEmisor.Text;
                request.Credenciales.NombreSucursal = textNombreSucursal.Text;
                request.Clientes.Add(
                    new NuevoReceptorExternoRequest()
                    {
                        Rut = textRutCliente.Text,
                        RazonSocial = textRazonCliente.Text,
                        Ciudad = textCiudadCliente.Text,
                        Comuna = textComunaCliente.Text,
                        CorreoFact = textCorreoFacCliente.Text,
                        CorreoPar = textCorreoParCliente.Text,
                        DirFact = textDireccionFacCliente.Text,
                        DirPart = textDireccionParCliente.Text,
                        Giro = textGiroCliente.Text
                    }
                );
                var response = await cliente.Clientes.AgregarClientesAsync(request);
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(response.Message, response.Status.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarAgregarCliente);
            }
        }
    }
}
