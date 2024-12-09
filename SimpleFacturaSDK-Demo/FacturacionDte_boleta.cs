﻿using System;
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
    public partial class FacturacionDte_boleta : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public FacturacionDte_boleta()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE, value => value == DTEType.BoletaElectronica || value == DTEType.FacturaElectronica);
            EnumHelper.LlenarComboBoxConEnum<FormaPago.FormaPagoEnum>(comboBoxFormaPago);
            EnumHelper.LlenarComboBoxConEnum<IndicadorServicio.IndicadorServicioEnum>(comboIndService);
        }

        private void FacturacionDte_boleta_Load(object sender, EventArgs e)
        {
            // Configuración inicial según el RadioButton seleccionado
            UpdateUIBasedOnSelection();


            // Datos emisor
            textRUTEmisor.Text = _appSettings.emisor.RUTEmisor;
            correo_emisor.Text = _appSettings.emisor.CorreoEmisor;
            textCiudadEmisor.Text = _appSettings.emisor.CiudadOrigen;
            textTelefonEmisor.Text = _appSettings.emisor.Telefono.First();
            razonSocial_Emisor.Text = _appSettings.emisor.RznSoc;
            textGiroEmisor.Text = _appSettings.emisor.GiroEmis;
            textDireccionEmisor.Text = _appSettings.emisor.DirOrigen;
            textComunaEmisor.Text = _appSettings.emisor.CmnaOrigen;
            textActividadEconomica.Text = _appSettings.emisor.Acteco.First().ToString();

            // Datos receptor
            textDirReceptor.Text = "calle 12";
            textCmnReceptor.Text = "Paine";
            textCiudadReceptor.Text = "Santiago";
            textRutReceptor.Text = "17096073-4";

            // Productos
            gridProductos.Rows.Add(1, "Alfajor", "Desc1", 1, "un", 200, 100);

            // Totales
            textMontoExento.Text = "200";
            textMontoTotal.Text = "200";

            textSucursal.Text = _appSettings.Credenciales.NombreSucursal;
        }

        private void UpdateUIBasedOnSelection()
        {
            if (DteRadioButton.Checked)
            {
                // Configuración para DTE
                comboBoxFormaPago.Enabled = true;
                comboIndService.Enabled = false;
                comboBoxCodigoTipoDTE.SelectedIndex = 0;
                comboBoxFormaPago.SelectedIndex = 1;
                fechaEmision.Value = DateTime.Parse("2022-12-05");
                fechaVencimiento.Value = DateTime.Now.AddMonths(6);

                // Datos receptor
                textCorreoReceptor.Text = "mvega@chilesystems.com";
                textRznReceptor.Text = "Hotel Iquique";
                textGiroReceptor.Text = "test";


                // Habilitar campos para DTE y mantener su contenido
                textCiudadEmisor.Enabled = true;
                correo_emisor.Enabled = true;
                textActividadEconomica.Enabled = true;
                textTelefonEmisor.Enabled = true;
                textGiroReceptor.Enabled = true;
            }
            else if (BoletasRadioButton.Checked)
            {
                // Configuración para Boletas
                comboBoxFormaPago.Enabled = false;
                comboIndService.Enabled = true;
                comboBoxCodigoTipoDTE.SelectedIndex = 1;
                comboIndService.SelectedIndex = 3;
                fechaEmision.Value = DateTime.Parse("2024-09-03");
                fechaVencimiento.Value = DateTime.Parse("2024-09-03");


                textCorreoReceptor.Text = "mercocha13@gmail.com";
                textRznReceptor.Text = "Proveedor Test";

                // Deshabilitar campos para Boletas
                textCiudadEmisor.Enabled = false;
                correo_emisor.Enabled = false;
                textActividadEconomica.Enabled = false;
                textTelefonEmisor.Enabled = false;
                textGiroReceptor.Enabled = false;
            }
        }
        private void DteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUIBasedOnSelection();
        }

        private void BoletasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUIBasedOnSelection();
        }

        private async void generarFacturacioDte_Boleta_Click(object sender, EventArgs e)
        {
            bool isBoleta = BoletasRadioButton.Checked;

            // Crear la solicitud
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
                    Detalle = new List<Detalle>()
                }
            };
            var tipoDte = comboBoxCodigoTipoDTE.SelectedItem as ComboBoxItem;
            request.Documento.Encabezado.IdDoc.TipoDTE = (DTEType)tipoDte.Value;
            request.Documento.Encabezado.IdDoc.FchEmis = fechaEmision.Value;
          
            
            request.Documento.Encabezado.IdDoc.FchVenc = fechaVencimiento.Value;

            if (isBoleta)
            {
                var IndServicio = comboIndService.SelectedItem as ComboBoxItem;
                request.Documento.Encabezado.IdDoc.IndServicio = (IndicadorServicio.IndicadorServicioEnum)IndServicio.Value;
            }
            else
            {
                var formaPago = comboBoxFormaPago.SelectedItem as ComboBoxItem;
                request.Documento.Encabezado.IdDoc.FmaPago = (FormaPago.FormaPagoEnum)formaPago.Value;
            }

            

            if (isBoleta)
            {
                request.Documento.Encabezado.Emisor.RznSocEmisor = razonSocial_Emisor.Text;
                request.Documento.Encabezado.Emisor.GiroEmisor = textGiroEmisor.Text;
                request.Documento.Encabezado.Emisor.GiroEmisor = textGiroEmisor.Text;
            }
            else 
            {
                request.Documento.Encabezado.Emisor.Telefono = new List<string> { textTelefonEmisor.Text };
                request.Documento.Encabezado.Emisor.CorreoEmisor = correo_emisor.Text;
                request.Documento.Encabezado.Emisor.Acteco = new List<int> { int.Parse(textActividadEconomica.Text) };
                request.Documento.Encabezado.Emisor.CiudadOrigen = textCiudadEmisor.Text;
                request.Documento.Encabezado.Emisor.RznSoc = razonSocial_Emisor.Text;
                request.Documento.Encabezado.Emisor.GiroEmis = textGiroEmisor.Text;
                request.Documento.Encabezado.Receptor.GiroRecep = textGiroReceptor.Text;
            }
            // Configuración de Emisor
            request.Documento.Encabezado.Emisor.RUTEmisor = textRUTEmisor.Text;
            request.Documento.Encabezado.Emisor.DirOrigen = textDireccionEmisor.Text;
            request.Documento.Encabezado.Emisor.CmnaOrigen = textComunaEmisor.Text;

            // Configuración de Receptor
            request.Documento.Encabezado.Receptor.RUTRecep = textRutReceptor.Text;
            request.Documento.Encabezado.Receptor.RznSocRecep = textRznReceptor.Text;
            request.Documento.Encabezado.Receptor.DirRecep = textDirReceptor.Text;
            request.Documento.Encabezado.Receptor.CmnaRecep = textCmnReceptor.Text;
            request.Documento.Encabezado.Receptor.CiudadRecep = textCiudadReceptor.Text;

            // Configuración de Totales
            request.Documento.Encabezado.Totales.MntExe = int.Parse(textMontoExento.Text);
            request.Documento.Encabezado.Totales.MntTotal = int.Parse(textMontoTotal.Text);

            // Configuración de Detalles
            foreach (DataGridViewRow row in gridProductos.Rows)
            {
                if (!row.IsNewRow)
                {
                    var detalle = new Detalle
                    {
                        NroLinDet = Convert.ToInt32(row.Cells["gridNroLinea"].Value),
                        NmbItem = row.Cells["gridNombreProducto"].Value?.ToString() ?? string.Empty,
                        DscItem = row.Cells["Descripcion"].Value?.ToString() ?? string.Empty,
                        QtyItem = Convert.ToInt32(row.Cells["gridCantidadProducto"].Value),
                        UnmdItem = row.Cells["Unidad"].Value?.ToString() ?? string.Empty,
                        PrcItem = Convert.ToDouble(row.Cells["gridPrecio"].Value),
                        MontoItem = Convert.ToInt32(row.Cells["gridMonto"].Value)
                    };
                    request.Documento.Detalle.Add(detalle);
                }
            }

            // Enviar solicitud al cliente
            var sucursal = textSucursal.Text;
            var response = await cliente.Facturacion.FacturacionIndividualV2DTEAsync(sucursal, request);

            // Mostrar el resultado
            if (response.Status == 400 || response.Status == 500)
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(response.Message, response.Status.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}