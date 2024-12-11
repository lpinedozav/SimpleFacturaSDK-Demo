using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Helpers;
using SDKSimpleFactura.Models.Request;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Collections.Generic;
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
            var randomText = StringHelper.GenerateRandomString(6);
            //Credenciales
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            //Productos
            textNombre.Text = randomText;
            textCodigoBarra.Text = randomText;
            numericPrecio.Value = 50;
            textUnidadMedida.Text = "un";
            comboBoxImpuesto.SelectedIndex = 1;
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
                request.Productos.Add(
                    new NuevoProductoExternoRequest()
                    {
                        Nombre = textNombre.Text,
                        CodigoBarra = textCodigoBarra.Text,
                        UnidadMedida = textUnidadMedida.Text,
                        Precio = (double)numericPrecio.Value,
                        TieneImpuestos = false,
                        Impuestos = new List<int> { (int)EnumHelper.ObtenerValorSeleccionado<TipoImpuesto.TipoImpuestoEnum>(comboBoxImpuesto) }
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
    }
}
