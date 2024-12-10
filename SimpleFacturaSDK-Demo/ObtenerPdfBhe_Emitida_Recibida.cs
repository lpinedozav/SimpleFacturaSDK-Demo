﻿using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Request;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerPdfBhe_Emitida_Recibida : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ObtenerPdfBhe_Emitida_Recibida()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
        }

        private void ObtenerPdfBhe_Emitida_Recibida_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textRutContribuyente.Text = _appSettings.Credenciales.RutContribuyente;
            folio_oPDF_BHE.Value = 15;
            ChangeUI();

        }

        private async void generarpdf_Click(object sender, EventArgs e)
        {
            try
            {
                Response<byte[]> response;
                if (radioButton_emitidoPdf.Checked)
                {
                    var request = new BHERequest
                    {
                        Credenciales = new Credenciales(),
                        Folio = (int)folio_oPDF_BHE.Value
                    };
                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.Folio = (int)folio_oPDF_BHE.Value;
                    response = await cliente.BoletasHonorarios.ObtenerPDFBHEEmitidaAsync(request);
                }
                else
                {
                    var request = new BHERequest
                    {
                        Credenciales = new Credenciales(),
                        Folio = (int)folio_oPDF_BHE.Value
                    };
                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.Credenciales.RutContribuyente = textRutContribuyente.Text;
                    request.Folio = (int)folio_oPDF_BHE.Value;
                    response = await cliente.BoletasHonorarios.ObtenerPDFBHEEmitidaAsync(request);
                }
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        // Obtener el directorio del proyecto (dos niveles hacia arriba desde bin/Debug)
                        string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

                        // Construir la ruta de la carpeta "Files" dentro del directorio del proyecto
                        string directoryPath = Path.Combine(projectDirectory, "Files");

                        // Crear la carpeta si no existe
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        // Ruta completa para guardar el archivo
                        string filePath = Path.Combine(directoryPath, $"DTE_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

                        // Guardar los datos en el archivo
                        File.WriteAllBytes(filePath, response.Data);

                        // Notificar al usuario
                        DialogResult result = MessageBox.Show($"El PDF se ha guardado correctamente en: {filePath}\n¿Desea abrir el archivo ahora?",
                                                                "Éxito",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            // Abrir el PDF
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = filePath,
                                UseShellExecute = true
                            });
                        }

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                // Manejo de errores si es necesario
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void radioButton_recibidoPdf_CheckedChanged_1(object sender, EventArgs e)
        {
            ChangeUI();
        }

        private void radioButton_emitidoPdf_CheckedChanged_1(object sender, EventArgs e)
        {
            ChangeUI();
        }

        private void ChangeUI()
        {
            if (radioButton_emitidoPdf.Checked) { textRutContribuyente.Enabled = true; folio_oPDF_BHE.Value = 15; }
            if (radioButton_recibidoPdf.Checked) { textRutContribuyente.Enabled = false; folio_oPDF_BHE.Value = 1; }
        }

    }
}
