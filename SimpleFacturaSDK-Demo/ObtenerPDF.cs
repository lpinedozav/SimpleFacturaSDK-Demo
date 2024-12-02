﻿using SDKSimpleFactura.Enum;
using SDKSimpleFactura.Models.Facturacion;
using SimpleFacturaSDK_Demo.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerPDF : Form
    {
        private AppSettings _appSettings;

        public ObtenerPDF()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            LlenarComboBox();
        }
        private void ObtenerPDF_Load(object sender, EventArgs e)
        {
            var cliente = SimpleClientSingleton.Instance;
            tipodte_oPDF.SelectedIndex = 0;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void generarPdf_Click(object sender, EventArgs e)
        {
            try
            {

             

                // Aquí puedes usar la variable rutaGuardado para guardar el PDF
               // MessageBox.Show($"El PDF se guardará en: {rutaGuardado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Continuar con el proceso de generación del PDF...
                AmbienteEnum ambienteSeleccionado;

                if (radioCertificacion.Checked)
                {
                    ambienteSeleccionado = AmbienteEnum.Certificacion;
                }
                else if (radioProduccion.Checked)
                {
                    ambienteSeleccionado = AmbienteEnum.Produccion;
                }
                else
                {
                    // Si no se selecciona ningún ambiente, mostrar un mensaje
                    MessageBox.Show("Por favor, selecciona un ambiente (Certificación o Producción).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Obtener el valor seleccionado del ComboBox
                if (tipodte_oPDF.SelectedItem is ComboBoxItem selectedItem)
                {
                    var tipoDte = (DTEType)selectedItem.Value; // Obtener el enum seleccionado
                    var request = new SolicitudDte
                    {
                        Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(), // Inicializamos Credenciales
                        DteReferenciadoExterno = new DteReferenciadoExterno() // Inicializamos DteReferenciadoExterno
                    };

                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.Credenciales.NombreSucursal = textNombreSucursal.Text;
                    request.DteReferenciadoExterno.Folio = (int)folio_oPDF.Value;

                    // Asignar el valor del tipo de DTE seleccionado
                    request.DteReferenciadoExterno.CodigoTipoDte = (int)tipoDte;
                    request.DteReferenciadoExterno.Ambiente = (int)ambienteSeleccionado;

                    // Crear un mensaje con los valores que deseas mostrar
                    string mensaje = $"Datos.\n" +
                                     $"Rut Emisor: {request.Credenciales.RutEmisor}\n" +
                                     $"Nombre Sucursal: {request.Credenciales.NombreSucursal}\n" +
                                     $"Folio: {request.DteReferenciadoExterno.Folio}\n" +
                                     $"Código Tipo DTE: {request.DteReferenciadoExterno.CodigoTipoDte}\n" +
                                     $"Ambiente: {request.DteReferenciadoExterno.Ambiente}";


                    // Mostrar el mensaje en una ventana emergente
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Manejo en caso de que no se seleccione ningún valor
                    MessageBox.Show("Por favor, selecciona un tipo de DTE válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores si es necesario
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarComboBox()
        {
            // Obtener todas las opciones del enum
            var enumValues = Enum.GetValues(typeof(DTEType)).Cast<DTEType>();

            foreach (var value in enumValues)
            {
                // Obtener la descripción del atributo Description
                string descripcion = ObtenerDescripcion(value);
                if (!string.IsNullOrEmpty(descripcion))
                {
                    // Agregar al ComboBox (mostrar la descripción, pero almacenar el valor del enum)
                    tipodte_oPDF.Items.Add(new ComboBoxItem { Text = descripcion, Value = value });
                }
            }

            // Establecer el primer elemento como seleccionado por defecto (opcional)
            if (tipodte_oPDF.Items.Count > 0)
            {
                tipodte_oPDF.SelectedIndex = 0;
            }
        }
        private string ObtenerDescripcion(Enum value)
        {
            // Obtener el atributo Description del enum
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? value.ToString();
        }

        private void comboBoxDTE_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor del enum seleccionado
            if (tipodte_oPDF.SelectedItem is ComboBoxItem selectedItem)
            {
                var dteType = (DTEType)selectedItem.Value;
                int valorDte = (int)dteType;

                // Mostrar el valor asociado
                MessageBox.Show($"Seleccionaste: {selectedItem.Text} (Valor: {valorDte})", "Información");
            }
        }

        private void radioCertificacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancelarpdf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

       
    }
}