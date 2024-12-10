using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Helpers;
using System;
using System.Windows.Forms;
using SimpleFacturaSDK_Demo.Helpers;

namespace SimpleFacturaSDK_Demo
{
    public partial class ListarProductos : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ListarProductos()
        {
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            InitializeComponent();
        }

        private void ListarProductos_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
        }

        private async void generarListadoProductos_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Credenciales();
                request.RutEmisor = textRutEmisor.Text;
                request.NombreSucursal = textNombreSucursal.Text;
                var response = await cliente.Productos.ListarProductosAsync(request);
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var list = response.Data;
                    foreach (var producto in list)
                    {
                        int rowIndex = gridResultados.Rows.Add(
                            //producto.ProductoId,
                            producto.Nombre,
                            FormattingHelper.FormatearPrecio((decimal)producto.Precio),
                            producto.Exento
                        );
                        //DataGridViewRow row = gridResultados.Rows[rowIndex];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
