﻿using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Request;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using SimpleFacturaSDK_Demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ListadoDteEmitidos_Recibidos : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        private List<DteEnt> list;

        public ListadoDteEmitidos_Recibidos()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE);
        }

        private void ListadoDteEmitidos_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            numericFolio.Value = 0; // Valor predeterminado para el Folio
            ChangeUI();
            gridResultados.AutoGenerateColumns = false;

            // Asociar el evento CellContentClick
            gridResultados.CellContentClick += gridResultados_CellContentClick;
            gridResultados.CellFormatting += dataGridListado_CellFormatting;
        }

        private async void generarListaDTE_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarListaDTE);
            try
            {
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
                    MessageBox.Show("Por favor, selecciona un ambiente (Certificación o Producción).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListaDteRequest request = new ListaDteRequest()
                {
                    Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales()
                    {
                        RutEmisor = textRutEmisor.Text
                    },
                    Desde = dateTimeDesde.Value,
                    Hasta = dateTimeHasta.Value,
                    Ambiente = ambienteSeleccionado
                };

                if (textNombreSucursal.Enabled)
                {
                    request.Credenciales.NombreSucursal = textNombreSucursal.Text;
                }

                var tipoDte = comboBoxCodigoTipoDTE.SelectedItem as ComboBoxItem;
                request.CodigoTipoDte = (DTEType)tipoDte.Value;

                Response<List<DteEnt>> response;

                if (radio_Bton_emitidoListado.Checked)
                {
                    response = await cliente.Facturacion.ListadoDtesEmitidosAsync(request);
                }
                else
                {
                    response = await cliente.Proveedores.ListadoDtesRecibidosAsync(request);
                }

                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    list = response.Data;

                    // Asignar la lista al DataSource del DataGridView
                    gridResultados.DataSource = null;
                    gridResultados.DataSource = list;

                    // Configurar columna de detalles si no existe
                    ConfigurarColumnaDetalles();
                    RemoverColumnasVacias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarListaDTE);
            }
        }

        private void dataGridListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si es una de las columnas que deseas formatear
            if (gridResultados.Columns[e.ColumnIndex].Name == "neto" ||
                gridResultados.Columns[e.ColumnIndex].Name == "iva" ||
                gridResultados.Columns[e.ColumnIndex].Name == "total")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    // Aplica el formato utilizando el helper
                    e.Value = FormattingHelper.FormatearPrecio(valor);
                    e.FormattingApplied = true;
                }
            }
        }

        private void RemoverColumnasVacias()
        {
            // Recorremos las columnas de derecha a izquierda para poder eliminarlas sin problemas
            for (int i = gridResultados.Columns.Count - 1; i >= 0; i--)
            {
                bool columnaVacia = true;
                foreach (DataGridViewRow fila in gridResultados.Rows)
                {
                    var valor = fila.Cells[i].Value;
                    if (valor != null && !string.IsNullOrWhiteSpace(valor.ToString()))
                    {
                        // Encontramos un valor en esta columna, por lo tanto no está vacía
                        columnaVacia = false;
                        break;
                    }
                }

                // Si la columna resultó vacía, la removemos
                if (columnaVacia && gridResultados.Columns[i].Name != "detalles")
                {
                    gridResultados.Columns.RemoveAt(i);
                }
            }
        }
        private void ConfigurarColumnaDetalles()
        {
            // Verifica si ya existe la columna "detalles"
            if (gridResultados.Columns["detalles"] == null)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                {
                    Name = "detalles",
                    HeaderText = "Detalles",
                    Text = "Ver Detalles",
                    UseColumnTextForButtonValue = true
                };

                gridResultados.Columns.Add(buttonColumn);
            }
            

        }
        private void gridResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de columna corresponda a la columna del botón y que no sea una fila de encabezado
            if (gridResultados.Columns[e.ColumnIndex].Name == "detalles" && e.RowIndex >= 0)
            {
                var reporte = list[e.RowIndex];
                List<DetalleDte> detalles = reporte.Detalles;
                MostrarDetallesEnOtraTabla(detalles);
            }
        }

        private void MostrarDetallesEnOtraTabla(List<DetalleDte> detalles)
        {
            if (detalles == null || detalles.Count == 0)
            {
                MessageBox.Show("No hay detalles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Detalles detallesForm = new Detalles();
            detallesForm.SetDetalles(detalles);
            detallesForm.ShowDialog();
        }

        private void radio_Bton_emitidoListado_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUI();
        }

        private void radio_Bton_recibidoListado_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUI();
        }

        private void ChangeUI()
        {
            if (radio_Bton_emitidoListado.Checked)
            {
                textNombreSucursal.Enabled = true;
                dateTimeDesde.Value = DateTime.Parse("2024-12-01");
                dateTimeHasta.Value = DateTime.Parse("2024-12-05");
                comboBoxCodigoTipoDTE.SelectedIndex = 3;
                radioCertificacion.Checked = true;
                radioProduccion.Checked = false;

                string descripcion =
                  "Permite generar lista detallada de DTE emitidos desde una empresa emisora hacia una empresa receptora (o proveedor en caso de Factura de Compra)," +
                  "Es posible generar un listado por tipo de DTE, obtener el detalle de un folio en particular y un listado del total de DTE emitidos.";
                textDocumentacion.Text = descripcion;
            }
            if (radio_Bton_recibidoListado.Checked)
            {
                textNombreSucursal.Enabled = false;
                dateTimeDesde.Value = DateTime.Parse("2024-04-01");
                dateTimeHasta.Value = DateTime.Parse("2024-04-30");
                comboBoxCodigoTipoDTE.SelectedIndex = 0;
                radioCertificacion.Checked = false;
                radioProduccion.Checked = true;

                string descripcion =
                  "Permite generar lista detallada de DTE recibidos desde un proveedor (\"rutContribuyente\") hacia nuestra empresa (\"rutEmisor\")," +
                  "Es posible generar un listado por tipo de DTE, obtener el detalle de un folio en particular y un listado del total de DTE recibidos.";
                textDocumentacion.Text = descripcion;
            }
        }

        private void linkLabelListado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Definir las URLs para emitido y recibido
            string radio_Bton_emitidoListadoUrl = "https://documentacion.simplefactura.cl/#3056548a-3dca-4ccc-9e1c-aa0198668bbe";
            string radio_Bton_recibidoListadoUrl = "https://documentacion.simplefactura.cl/#0b7dbd72-6a3f-4228-b1d1-ae827944946c"; // Cambia a la URL correspondiente

            // Determinar cuál URL usar en función del RadioButton seleccionado
            string url;
            if (radio_Bton_recibidoListado.Checked)
            {
                url = radio_Bton_emitidoListadoUrl;
            }
            else if (radio_Bton_emitidoListado.Checked)
            {
                url = radio_Bton_recibidoListadoUrl;
            }
            else
            {
                MessageBox.Show("Selecciona una opción antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar abrir la URL en el navegador predeterminado
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
