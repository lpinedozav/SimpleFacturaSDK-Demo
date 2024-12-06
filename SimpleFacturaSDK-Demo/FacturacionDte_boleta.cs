using SDKSimpleFactura;
using SDKSimpleFactura.Enum;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class FacturacionDte_boleta : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public FacturacionDte_boleta()
        {
            InitializeComponent();
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE, value => value == DTEType.NotaDebitoElectronica || value == DTEType.NotaCreditoElectronica);
            EnumHelper.LlenarComboBoxConEnum<FormaPago.FormaPagoEnum>(comboBoxFormaPago);
        }

        private void FacturacionDte_boleta_Load(object sender, EventArgs e)
        {
            //Identificacion
            comboBoxCodigoTipoDTE.SelectedIndex = 1; // nota credito electronica
            comboBoxFormaPago.SelectedIndex = 1;
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
                200,
                200
                );

            //Totales
            textMontoExento.Text = "200";
            textMontoTotal.Text = "200";

            textSucursal.Text = _appSettings.Credenciales.NombreSucursal;
        }
    }
}
