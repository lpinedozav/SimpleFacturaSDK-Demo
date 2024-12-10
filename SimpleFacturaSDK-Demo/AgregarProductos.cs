using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Models.Request;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

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
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            //Credenciales
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            //Productos
            textNombre.Text = "ProductoTest1";
            textCodigoBarra.Text = "productotest1";
            numericPrecio.Value = 50;
            EnumHelper.LlenarComboBoxConEnum<TipoImpuesto.TipoImpuestoEnum>(comboBoxImpuesto);

        }

        private async void generarAgregarProducto_Click(object sender, EventArgs e)
        {
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
                        UnidadMedida = "un",
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
                    var list = response.Data;
                    foreach (var producto in list)
                    {
                        int rowIndex = gridResultados.Rows.Add(
                            producto.Activo,
                            producto.Nombre,
                            producto.CodigoBarra,
                            producto.Precio,
                            producto.UnidadMedida,
                            producto.Stock
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
