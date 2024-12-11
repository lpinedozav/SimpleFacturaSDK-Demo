using System;
using SDKSimpleFactura;
using System.Windows.Forms;
using SimpleFacturaSDK_Demo.Helpers;
using static SDKSimpleFactura.Enum.TipoDTE;
using System.Linq;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Models.Request;
using System.Collections.Generic;
using SimpleFacturaSDK_Demo.Models;
namespace SimpleFacturaSDK_Demo
{
    public partial class EmisonNC_ND : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public EmisonNC_ND()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE, value => value == DTEType.NotaDebitoElectronica || value == DTEType.NotaCreditoElectronica);
            EnumHelper.LlenarComboBoxConEnum<FormaPago.FormaPagoEnum>(comboBoxFormaPago);
            EnumHelper.LlenarComboBoxConEnum<ReasonTypeEnum>(comboBoxMotivo);
        }
        private void EmisonNC_ND_Load(object sender, EventArgs e)
        {
            //Identificacion
            comboBoxCodigoTipoDTE.SelectedIndex = 1; // nota credito electronica
            comboBoxFormaPago.SelectedIndex = 1;
            numericFolio.Value = 1804;
            fechaEmision.Value = DateTime.Parse("2022-12-05");
            fechaVencimiento.Value = DateTime.Now.AddMonths(6);
            //Datos emisor
            textRUTEmisor.Text = _appSettings.emisor.RUTEmisor;
            correo_emisor.Text = _appSettings.emisor.CorreoEmisor;
            textCiudadEmisor.Text = _appSettings.emisor.CiudadOrigen;
            textTelefonEmisor.Text = _appSettings.emisor.Telefono.First();
            razonSocial_Emisor.Text = _appSettings.emisor.RznSoc;
            textGiroEmisor.Text = _appSettings.emisor.GiroEmis;
            textDireccionEmisor.Text = _appSettings.emisor.DirOrigen;
            textComunaEmisor.Text = _appSettings.emisor.CmnaOrigen;
            textActividadEconomica.Text = _appSettings.emisor.Acteco.First().ToString();
            //Datos receptor
            textRutReceptor.Text = "10422710-4";
            textCorreoReceptor.Text = "mvega@chilesystems.com";
            textCiudadReceptor.Text = "Santiago";
            textRznReceptor.Text = "McL";
            textGiroReceptor.Text = "test";
            textDirReceptor.Text = "Pensamientos 2308";
            textCmnReceptor.Text = "Paine";
            //Productos
            gridProductos.Rows.Add(
                1,
                1,
                "test",
                1,
                FormattingHelper.FormatearPrecio(200),
                FormattingHelper.FormatearPrecio(200)
                );
            //Referencias
            gridReferencias.Rows.Add(
                1,
                "34",
                "367",
                DateTime.Parse("2022-12-06").ToString("dd/MM/yyyy"),
                3,
                "Corrige Monto DTE: test"
                );
            //Totales
            textMontoExento.Text = "200";
            textMontoTotal.Text = "200";
            //Otros
            comboBoxMotivo.SelectedIndex = 6;
            textSucursal.Text = _appSettings.Credenciales.NombreSucursal;
        }

        private async void generarNcNd_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarNcNd);
            try
            {
                var request = new RequestDTE()
                {
                    Documento = new Documento()
                    {
                        Encabezado = new Encabezado()
                        {
                            IdDoc = new IdentificacionDTE(),
                            Emisor = new Emisor(),
                            Receptor = new Receptor(),
                            Totales = new Totales()
                        },
                        Detalle = new List<Detalle>(),
                        Referencia = new List<Referencia>()
                    }
                };
                var tipoDte = comboBoxCodigoTipoDTE.SelectedItem as ComboBoxItem;
                var formaPago = comboBoxFormaPago.SelectedItem as ComboBoxItem;
                var motivo = comboBoxMotivo.SelectedItem as ComboBoxItem;
                var sucursal = textSucursal.Text;
                request.Documento.Encabezado.IdDoc.TipoDTE = (DTEType)tipoDte.Value;
                request.Documento.Encabezado.IdDoc.FchEmis = fechaEmision.Value;
                request.Documento.Encabezado.IdDoc.FmaPago = (FormaPago.FormaPagoEnum)formaPago.Value;
                request.Documento.Encabezado.IdDoc.FchVenc = fechaVencimiento.Value;
                request.Documento.Encabezado.IdDoc.Folio = (long)numericFolio.Value;

                request.Documento.Encabezado.Emisor.RUTEmisor = textRUTEmisor.Text;
                request.Documento.Encabezado.Emisor.RznSoc = razonSocial_Emisor.Text;
                request.Documento.Encabezado.Emisor.GiroEmis = textGiroEmisor.Text;
                request.Documento.Encabezado.Emisor.Telefono = new List<string> { textTelefonEmisor.Text };
                request.Documento.Encabezado.Emisor.CorreoEmisor = correo_emisor.Text;
                request.Documento.Encabezado.Emisor.Acteco = new List<int> { int.Parse(textActividadEconomica.Text) };
                request.Documento.Encabezado.Emisor.DirOrigen = textDireccionEmisor.Text;
                request.Documento.Encabezado.Emisor.CmnaOrigen = textComunaEmisor.Text;
                request.Documento.Encabezado.Emisor.CiudadOrigen = textCiudadEmisor.Text;

                request.Documento.Encabezado.Receptor.RUTRecep = textRutReceptor.Text;
                request.Documento.Encabezado.Receptor.RznSocRecep = textRznReceptor.Text;
                request.Documento.Encabezado.Receptor.GiroRecep = textGiroReceptor.Text;
                request.Documento.Encabezado.Receptor.CorreoRecep = textCorreoReceptor.Text;
                request.Documento.Encabezado.Receptor.DirRecep = textGiroReceptor.Text;
                request.Documento.Encabezado.Receptor.CmnaRecep = textCmnReceptor.Text;
                request.Documento.Encabezado.Receptor.CiudadRecep = textCiudadReceptor.Text;

                request.Documento.Encabezado.Totales.MntExe = int.Parse(textMontoExento.Text);
                request.Documento.Encabezado.Totales.MntTotal = int.Parse(textMontoTotal.Text);

                foreach (DataGridViewRow row in gridProductos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var detalle = new Detalle
                        {
                            NroLinDet = Convert.ToInt32(row.Cells["gridNroLinea"].Value),
                            IndExe = (IndicadorFacturacionExencionEnum)Convert.ToInt32(row.Cells["gridIndExe"].Value),
                            NmbItem = row.Cells["gridNombreProducto"].Value?.ToString() ?? string.Empty,
                            QtyItem = Convert.ToInt32(row.Cells["gridCantidadProducto"].Value),
                            PrcItem = Convert.ToDouble(row.Cells["gridPrecio"].Value),
                            MontoItem = Convert.ToInt32(row.Cells["gridMonto"].Value)
                        };
                        request.Documento.Detalle.Add(detalle);
                    }
                }
                foreach (DataGridViewRow row in gridReferencias.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var referencia = new Referencia
                        {
                            NroLinRef = Convert.ToInt32(row.Cells["gridRefNroLin"].Value),
                            TpoDocRef = row.Cells["gridRefTipoDoc"].Value.ToString(),
                            FolioRef = row.Cells["gridRefFolio"].Value.ToString(),
                            FchRef = DateTime.Parse(row.Cells["gridRefFecha"].Value.ToString()),
                            CodRef = (TipoReferencia.TipoReferenciaEnum)Convert.ToInt32(row.Cells["gridRefCodigo"].Value),
                            RazonRef = row.Cells["gridRefRazon"].Value.ToString(),
                        };
                        request.Documento.Referencia.Add(referencia);
                    }
                }
                var response = await cliente.Facturacion.EmisionNC_NDV2Async(sucursal, (ReasonTypeEnum)motivo.Value, request);
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
                Loading.HideLoading(generarNcNd);
            }
        }
    }
}
