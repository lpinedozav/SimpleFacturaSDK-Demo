﻿using SDKSimpleFactura;
using SDKSimpleFactura.Models.Request;
using SimpleFacturaSDK_Demo.Helpers;
using SimpleFacturaSDK_Demo.Models;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;
using static SDKSimpleFactura.Models.Request.EnvioMailRequest;

namespace SimpleFacturaSDK_Demo
{
    public partial class EnviarMail : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public EnviarMail()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboxTipoDte);
        }

        private void EnviarMail_Load(object sender, EventArgs e)
        {
            textRutEmpresa.Text = _appSettings.Credenciales.RutEmisor;
            numericFolio.Value = 2149;
            comboxTipoDte.SelectedIndex = 3;
            textPara.Text = "contacto@chilesystems.com";
            textCC.Text = "correo2@gmail.com";
            textCCO.Text = "correo@gmail.com";
            checkXML.Checked = true;
            checkPDF.Checked = true;
            textComentario.Text = "ESTO ES UN COMENTARIO";

            string descripcion =
                 "permite a los usuarios enviar Documentos Tributarios Electrónicos (DTE) por correo electrónico en formato XML, PDF o ambos." +
                 "Para ello, es necesario especificar la empresa que emitió el documento, el tipo de DTE y su folio correspodiente.";

            textDocumentacion.Text = descripcion;
        }

        private async void generarEM_Click(object sender, EventArgs e)
        {
            // Mostrar el indicador de carga en textRespuesta
            Loading.ShowLoading(textRespuesta);

            try
            {
                var request = new EnvioMailRequest()
                {
                    Dte = new DteClass(),
                    Mail = new MailClass()
                };

                request.RutEmpresa = textRutEmpresa.Text;
                request.Dte.folio = (int)numericFolio.Value;
                var tipoDte = comboxTipoDte.SelectedItem as ComboBoxItem;
                request.Dte.tipoDTE = (int)tipoDte.Value;
                request.Mail.to = new List<string> { textPara.Text };
                request.Mail.ccs = new List<string> { textCC.Text };
                request.Mail.ccos = new List<string> { textCCO.Text };
                request.Xml = checkXML.Checked;
                request.Pdf = checkPDF.Checked; // Aquí corrigí porque estaba duplicado `Xml`
                request.Comments = textComentario.Text;

                var response = await cliente.Facturacion.EnvioMailAsync(request);

                // Mostrar la respuesta en textRespuesta
                textRespuesta.Text = $"Estado: {response.Status}\r\n" +
                                     $"Mensaje: {response.Message}\r\n" +
                                     $"Datos: {response.Data}\r\n" +
                                     $"Errores: {(response.Errors != null ? string.Join(", ", response.Errors) : "Ninguno")}\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(textRespuesta);
            }           
        }

        private void linkLabelEnvioMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://documentacion.simplefactura.cl/#261356ab-6b1f-4e2e-8cfa-bbd655a5d96f";

            // Abrir la URL en el navegador predeterminado
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
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
