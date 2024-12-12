using SDKSimpleFactura;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class ListarClientes : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ListarClientes()
        {
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            InitializeComponent();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textDocumentacion.Text = "Permite generar listado de Clientes, de acuerdo a rut de Emisor indicado en Json.";
        }

        private async void generarListarClientes_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarListarClientes);
            try
            {
                var request = new SDKSimpleFactura.Models.Facturacion.Credenciales();
                request.RutEmisor = textRutEmisor.Text;

                var response = await cliente.Clientes.ListarClientesAsync(request);

                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var list = response.Data;

                    gridResultados.DataSource = null;
                    gridResultados.DataSource = list;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarListarClientes);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlDocListClients = "https://documentacion.simplefactura.cl/#81f3ee6a-acb4-4dca-92d3-88ae9e5c7f72";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = urlDocListClients,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir la URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
