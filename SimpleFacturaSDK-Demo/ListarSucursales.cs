using SDKSimpleFactura;
using System;
using SDKSimpleFactura.Models.Facturacion;
using System.Data;
using System.Linq;

using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class ListarSucursales : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ListarSucursales()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
        }
        private void ListarSucursales_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
        }

        private async void generarListado_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarListado);
            try
            {
                var request = new Credenciales();
                request.RutEmisor = textRutEmisor.Text;

                var response = await cliente.Sucursal.ListadoSucursalesAsync(request);

                if (response.Status == 200)
                {
                    var data = response.Data;

                    if (data == null || data.Count == 0)
                    {
                        MessageBox.Show("No se encontraron datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    gridResultados.DataSource = data.Select(x => new
                    {
                        nombre = x.Nombre,
                        direccion = x.Direccion,
                    }).ToList();
                }
                else
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarListado);
            }
        }

    }
}
