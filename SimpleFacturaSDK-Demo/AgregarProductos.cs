using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Helpers;
using SDKSimpleFactura.Models.Request;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Policy;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class AgregarProductos : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public AgregarProductos()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            EnumHelper.LlenarComboBoxConEnum<TipoImpuesto.TipoImpuestoEnum>(comboBoxImpuesto);
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            // Arrays de productos y códigos de barras
            string[] productos = new string[20]
            {
                "Coca-Cola", "Pepsi", "Lays", "Doritos", "Nutella",
                "Pringles", "KitKat", "Snickers", "Red Bull", "Heineken",
                "Colgate", "Dove Soap", "Head & Shoulders", "Gillette Razor", "Nivea Cream",
                "Oreo", "M&Ms", "Twix", "Lipton Tea", "Sprite"
            };

            long[] codigosDeBarras = new long[20]
            {
                123456789012, 234567890123, 345678901234, 456789012345, 567890123456,
                678901234567, 789012345678, 890123456789, 901234567890, 112233445566,
                223344556677, 334455667788, 445566778899, 556677889900, 667788990011,
                778899001122, 889900112233, 990011223344, 101112131415, 121314151617
            };

            // Seleccionar un producto y código de barra aleatorios
            Random random = new Random();
            int index = random.Next(0, productos.Length);

            // Asignar valores al formulario
            textNombre.Text = productos[index];
            textCodigoBarra.Text = codigosDeBarras[index].ToString();
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            numericPrecio.Value = 50;
            textUnidadMedida.Text = "un";
            checkBoxImpuesto.Checked = true;
            comboBoxImpuesto.SelectedIndex = 1;
            textDocumentacion.Text = "Permite agregar productos nuevos al emisor y sucursal indicados en Json.";
        }

        private async void generarAgregarProducto_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarAgregarProducto);
            try
            {
                Response<List<ProductoEnt>> response;
                var request = new DatoExternoRequest()
                {
                    Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(),
                    Productos = new List<NuevoProductoExternoRequest>()
                };
                request.Credenciales.RutEmisor = textRutEmisor.Text;
                request.Credenciales.NombreSucursal = textNombreSucursal.Text;
                int number = 0;
                if (checkBoxImpuesto.Checked) number = (int)EnumHelper.ObtenerValorSeleccionado<TipoImpuesto.TipoImpuestoEnum>(comboBoxImpuesto);
                request.Productos.Add(
                    new NuevoProductoExternoRequest()
                    {
                        Nombre = textNombre.Text,
                        CodigoBarra = textCodigoBarra.Text,
                        UnidadMedida = textUnidadMedida.Text,
                        Precio = (double)numericPrecio.Value,
                        TieneImpuestos = false,
                        Impuestos = new List<int> { number }
                    }
                );
                response = await cliente.Productos.AgregarProductosAsync(request);
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
                Loading.HideLoading(generarAgregarProducto);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlDocAddProducts = "https://documentacion.simplefactura.cl/#097b4421-4e06-4ae8-88a5-9974d4c72b3d";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = urlDocAddProducts,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir la URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxImpuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxImpuesto.Checked)
            {
                comboBoxImpuesto.Enabled = false;
                return;
            }
            comboBoxImpuesto.Enabled = true;
        }
    }
}
