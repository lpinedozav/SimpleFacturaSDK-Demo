using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Request;
using SimpleFacturaSDK_Demo.Helpers;
using SimpleFacturaSDK_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.FormaPago;
using static SDKSimpleFactura.Enum.TipoDTE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleFacturaSDK_Demo
{
    public partial class FacturacionExportacion : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public FacturacionExportacion()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE, value => value == DTEType.FacturaExportacionElectronica);
            EnumHelper.LlenarComboBoxConEnum<FormaPago.FormaPagoEnum>(comboBoxFormaPago);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.Paises>(comboBoxNacionalidad);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.Paises>(comboPaisDestino);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.Paises>(comboBoxPaisReceptor);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.ModalidadVenta>(comboBoxModalidad);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.ClausulaCompraVenta>(comboBoxClausula);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.ViasdeTransporte>(comboBoxViaTransporte);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.Puertos>(comboBoxPuertoEmbarque);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.Puertos>(comboBoxPuertoDesembarque);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.UnidadMedida>(comboUnidadMedidaTara);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.UnidadMedida>(comboBoxPesoBruto);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.UnidadMedida>(comboBoxPesoNeto);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.Moneda>(comboBoxTipoMoneda);
            EnumHelper.LlenarComboBoxConEnum<CodigosAduana.Moneda>(comboBoxTipoMonedaTotal);
        }

        private void FacturacionExportacion_Load(object sender, EventArgs e)
        {
            //Identificacion
            comboBoxFormaPago.SelectedIndex = 1;
            fechaEmision.Value = DateTime.Parse("2024-08-17");
            fechaVencimiento.Value = DateTime.Now.AddMonths(6);
            //Emisor
            textRUTEmisor.Text = _appSettings.emisor.RUTEmisor;
            correo_emisor.Text = _appSettings.emisor.CorreoEmisor;
            textCiudadEmisor.Text = _appSettings.emisor.CiudadOrigen;
            textTelefonEmisor.Text = _appSettings.emisor.Telefono.First();
            razonSocial_Emisor.Text = _appSettings.emisor.RznSoc;
            textGiroEmisor.Text = _appSettings.emisor.GiroEmis;
            textDireccionEmisor.Text = _appSettings.emisor.DirOrigen;
            textComunaEmisor.Text = _appSettings.emisor.CmnaOrigen;
            textActividadEconomica.Text = _appSettings.emisor.Acteco.First().ToString();
            //Receptor
            textRutReceptor.Text = "10422710-4";
            textCorreoReceptor.Text = "mvega@chilesystems.com";
            textCiudadReceptor.Text = "Santiago";
            textRznReceptor.Text = "McL";
            textGiroReceptor.Text = "test";
            textDirReceptor.Text = "Pensamientos 2308";
            textCmnReceptor.Text = "Paine";
            textIdReceptor.Text = "331-555555";
            comboBoxNacionalidad.SelectedIndex = 242;
            //Aduana
            comboBoxModalidad.SelectedItem = comboBoxModalidad.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "A_FIRME");
            comboBoxClausula.SelectedItem = comboBoxClausula.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "FOB");
            comboBoxViaTransporte.SelectedItem = comboBoxViaTransporte.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "AEREO");
            comboBoxPuertoEmbarque.SelectedItem = comboBoxPuertoEmbarque.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "ARICA");
            comboBoxPuertoDesembarque.SelectedItem = comboBoxPuertoDesembarque.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "BUENOS_AIRES");
            comboPaisDestino.SelectedItem = comboPaisDestino.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "ARGENTINA");
            comboBoxPaisReceptor.SelectedItem = comboBoxPaisReceptor.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "ARGENTINA");

            comboUnidadMedidaTara.SelectedItem = comboUnidadMedidaTara.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "U");
            comboBoxPesoBruto.SelectedItem = comboBoxPesoBruto.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "KN");
            comboBoxPesoNeto.SelectedItem = comboBoxPesoNeto.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "KN");
            textClausula.Text = "1984.65";
            textTotalBulto.Text = "30";
            numericFlete.Value = (decimal)965.1;
            numericSeguro.Value = (decimal)10.25;
            numericPesoNeto.Value = (decimal)9.56;
            numericTara.Value = 1;
            numericPesoBruto.Value = (decimal)10.65;
            //Otra moneda
            comboBoxTipoMoneda.SelectedItem = comboBoxTipoMoneda.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "PESO_CHILENO");
            textTipoCambio.Text = "800.36";
            textMontoExento.Text = "45454.36";
            textMontoTotal.Text = "45454.36";
            //Totales
            comboBoxTipoMonedaTotal.SelectedItem = comboBoxTipoMonedaTotal.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value.ToString() == "DOLAR_ESTADOUNIDENSE");
            textTotal.Text = "1000";
            textExento.Text = "1000";
            //Productos
            gridProductos.Rows.Add(
                1,
                1,
                "CHATARRA DE ALUMINIO",
                "OPCIONAL",
                1,
                "U",
                FormattingHelper.FormatearPrecio(1000),
                FormattingHelper.FormatearPrecio(1000)
                );
            //Bulto
            gridBulto.Rows.Add(
                "1-2",
                75,
                "30",
                "1-3",
                "CONTENEDOR"
                );
        }

        private async void generarExporta_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarExporta);

            try
            {
                var exportacion = new RequestDTE
                {
                    Exportaciones = new Exportaciones
                    {
                        Encabezado = new Encabezado
                        {
                            IdDoc = new IdentificacionDTE(),
                            Emisor = new Emisor(),
                            Receptor = new Receptor
                            {
                                Extranjero = new Extranjero()
                            },
                            Transporte = new Transporte
                            {
                                Aduana = new Aduana
                                {
                                    TipoBultos = new List<TipoBulto>()
                                }
                            },
                            Totales = new Totales(),
                            OtraMoneda = new OtraMoneda()
                        },
                        Detalle = new List<DetalleExportacion>()
                    },
                    Observaciones = "NOTA AL PIE DE PAGINA"
                };
                var tipoDte = comboBoxCodigoTipoDTE.SelectedItem as ComboBoxItem;
                var formaPago = comboBoxFormaPago.SelectedItem as ComboBoxItem;
                var sucursal = "Casa Matriz";
                exportacion.Exportaciones.Encabezado.IdDoc.TipoDTE = (DTEType)tipoDte.Value;
                exportacion.Exportaciones.Encabezado.IdDoc.FchEmis = fechaEmision.Value;
                exportacion.Exportaciones.Encabezado.IdDoc.FmaPago = (FormaPago.FormaPagoEnum)formaPago.Value;
                exportacion.Exportaciones.Encabezado.IdDoc.FchVenc = fechaVencimiento.Value;
                //exportacion.Exportaciones.Encabezado.IdDoc.Folio = (long)numericFolio.Value;
                //Emisor
                exportacion.Exportaciones.Encabezado.Emisor.RUTEmisor = textRUTEmisor.Text;
                exportacion.Exportaciones.Encabezado.Emisor.RznSoc = razonSocial_Emisor.Text;
                exportacion.Exportaciones.Encabezado.Emisor.GiroEmis = textGiroEmisor.Text;
                exportacion.Exportaciones.Encabezado.Emisor.Telefono = new List<string> { textTelefonEmisor.Text };
                exportacion.Exportaciones.Encabezado.Emisor.CorreoEmisor = correo_emisor.Text;
                exportacion.Exportaciones.Encabezado.Emisor.Acteco = new List<int> { int.Parse(textActividadEconomica.Text) };
                exportacion.Exportaciones.Encabezado.Emisor.DirOrigen = textDireccionEmisor.Text;
                exportacion.Exportaciones.Encabezado.Emisor.CmnaOrigen = textComunaEmisor.Text;
                exportacion.Exportaciones.Encabezado.Emisor.CiudadOrigen = textCiudadEmisor.Text;

                //Receptor
                var nacionalidad = comboBoxNacionalidad.SelectedItem as ComboBoxItem;
                exportacion.Exportaciones.Encabezado.Receptor.RUTRecep = textRutReceptor.Text;
                exportacion.Exportaciones.Encabezado.Receptor.RznSocRecep = textRznReceptor.Text;
                exportacion.Exportaciones.Encabezado.Receptor.GiroRecep = textGiroReceptor.Text;
                exportacion.Exportaciones.Encabezado.Receptor.CorreoRecep = textCorreoReceptor.Text;
                exportacion.Exportaciones.Encabezado.Receptor.DirRecep = textGiroReceptor.Text;
                exportacion.Exportaciones.Encabezado.Receptor.CmnaRecep = textCmnReceptor.Text;
                exportacion.Exportaciones.Encabezado.Receptor.CiudadRecep = textCiudadReceptor.Text;
                exportacion.Exportaciones.Encabezado.Receptor.Extranjero.NumId = textIdReceptor.Text;
                exportacion.Exportaciones.Encabezado.Receptor.Extranjero.Nacionalidad = (CodigosAduana.Paises)nacionalidad.Value;

                //Aduana
                var modalidadVenta = comboBoxModalidad.SelectedItem as ComboBoxItem;
                var clausulaCompraVenta = comboBoxClausula.SelectedItem as ComboBoxItem;
                var viaTransporte = comboBoxViaTransporte.SelectedItem as ComboBoxItem;
                var puertoEmbarque = comboBoxPuertoEmbarque.SelectedItem as ComboBoxItem;
                var puertoDesembarque = comboBoxPuertoDesembarque.SelectedItem as ComboBoxItem;
                var unidadMedidaTara = comboUnidadMedidaTara.SelectedItem as ComboBoxItem;
                var pesoBruto = comboBoxPesoBruto.SelectedItem as ComboBoxItem;
                var pesoNeto = comboBoxPesoNeto.SelectedItem as ComboBoxItem;
                var paisDestino = comboPaisDestino.SelectedItem as ComboBoxItem;
                var paisReceptor = comboBoxPaisReceptor.SelectedItem as ComboBoxItem;

                exportacion.Exportaciones.Encabezado.Transporte.Aduana.CodModVenta = (CodigosAduana.ModalidadVenta)modalidadVenta.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.CodClauVenta = (CodigosAduana.ClausulaCompraVenta)clausulaCompraVenta.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.TotClauVenta = double.Parse(textClausula.Text);
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.CodViaTransp = (CodigosAduana.ViasdeTransporte)viaTransporte.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.CodPtoEmbarque = (CodigosAduana.Puertos)puertoEmbarque.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.CodPtoDesemb = (CodigosAduana.Puertos)puertoDesembarque.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.Tara = (int)numericTara.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.CodUnidMedTara = (CodigosAduana.UnidadMedida)unidadMedidaTara.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.PesoBruto = (int)numericPesoBruto.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.CodUnidPesoBruto = (CodigosAduana.UnidadMedida)pesoBruto.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.PesoNeto = (int)numericPesoNeto.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.CodUnidPesoNeto = (CodigosAduana.UnidadMedida)pesoNeto.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.TotBultos = int.Parse(textTotalBulto.Text);
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.MntFlete = int.Parse(numericFlete.Text);
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.MntSeguro = int.Parse(numericSeguro.Text);
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.CodPaisRecep = (CodigosAduana.Paises)paisReceptor.Value;
                exportacion.Exportaciones.Encabezado.Transporte.Aduana.CodPaisDestin = (CodigosAduana.Paises)paisDestino.Value;
                //?faltatipobulto

                //Otra moneda
                var tipoMoneda = comboBoxTipoMoneda.SelectedItem as ComboBoxItem;
                exportacion.Exportaciones.Encabezado.OtraMoneda.TpoMoneda = (CodigosAduana.Moneda)tipoMoneda.Value;
                exportacion.Exportaciones.Encabezado.OtraMoneda.TpoCambio = double.Parse(textTipoCambio.Text);
                exportacion.Exportaciones.Encabezado.OtraMoneda.MntExeOtrMnda = double.Parse(textMontoExento.Text);
                exportacion.Exportaciones.Encabezado.OtraMoneda.MntTotOtrMnda = double.Parse(textMontoTotal.Text);


                //Totales
                var tpoMonedaTotal = comboBoxTipoMonedaTotal.SelectedItem as ComboBoxItem;

                exportacion.Exportaciones.Encabezado.Totales.TpoMoneda = (CodigosAduana.Moneda)tpoMonedaTotal.Value;
                exportacion.Exportaciones.Encabezado.Totales.MntExe = int.Parse(textExento.Text);
                exportacion.Exportaciones.Encabezado.Totales.MntTotal = int.Parse(textTotal.Text);

                var response = await cliente.Facturacion.FacturacionIndividualV2ExportacionAsync(sucursal, exportacion);
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
                Loading.HideLoading(generarExporta);
            }
        }
    }
}
