﻿using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Request;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using SimpleFacturaSDK_Demo.Models;
using System;
using System.Collections.Generic;
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
        private List<DataGridViewColumn> columnasOriginales = new List<DataGridViewColumn>();

        public ListadoDteEmitidos_Recibidos()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE);
            GuardarColumnasOriginales();
        }
        private void GuardarColumnasOriginales()
        {
            columnasOriginales.Clear();
            foreach (DataGridViewColumn col in gridResultados.Columns)
            {
                // Creamos una copia de la columna original para poder restaurarla más tarde
                DataGridViewColumn colClone = (DataGridViewColumn)((ICloneable)col).Clone();
                columnasOriginales.Add(colClone);
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
                if (columnaVacia)
                {
                    gridResultados.Columns.RemoveAt(i);
                }
            }
        }

        // Método para resetear las columnas a las originales
        private void ResetearColumnas()
        {
            // Limpia el grid completamente
            gridResultados.Rows.Clear();
            gridResultados.Columns.Clear();

            // Restaura las columnas originales
            foreach (var col in columnasOriginales)
            {
                // Clonamos nuevamente por si se requiere regenerar el estado inicial
                DataGridViewColumn newCol = (DataGridViewColumn)((ICloneable)col).Clone();
                gridResultados.Columns.Add(newCol);
            }
        }

        private void ListadoDteEmitidos_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            numericFolio.Value = 0; // Valor predeterminado para el Folio
            ChangeUI();
        }

        private async void generarListaDTE_Click(object sender, EventArgs e)
        {
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
                Response<List<DteEnt>> response;
                ListaDteRequest request = new ListaDteRequest()
                {
                    Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales()
                };
                request.Credenciales.RutEmisor = textRutEmisor.Text;
                if (textNombreSucursal.Enabled) { request.Credenciales.NombreSucursal = textNombreSucursal.Text; }
                var tipoDte = comboBoxCodigoTipoDTE.SelectedItem as ComboBoxItem;
                request.CodigoTipoDte = (DTEType)tipoDte.Value;
                request.Desde = dateTimeDesde.Value;
                request.Hasta = dateTimeHasta.Value;
                request.Ambiente = ambienteSeleccionado;
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
                    ResetearColumnas();
                    gridResultados.Rows.Clear();
                    gridResultados.CellContentClick += dataGridConsolidado_CellContentClick;
                    DataGridViewButtonCell detallesColumn = new DataGridViewButtonCell();
                    detallesColumn.Value = "Ver Detalles";
                    detallesColumn.UseColumnTextForButtonValue = true;
                    gridResultados.AllowUserToAddRows = false;
                    foreach (var reporte in list)
                    {
                        int rowIndex = gridResultados.Rows.Add(
                            reporte.Ambiente,
                            reporte.FolioReutilizado,
                            reporte.Importado,
                            reporte.CodigoSii,
                            reporte.TipoDte,
                            reporte.EstadoAcuse,
                            reporte.FechaDte,
                            reporte.Folio,
                            reporte.RazonSocialReceptor,
                            reporte.RutReceptor,
                            reporte.TrackId,
                            reporte.EstadoSII,
                            reporte.Neto,
                            reporte.Exento,
                            reporte.Iva,
                            reporte.Total,
                            detallesColumn
                        );
                        DataGridViewRow row = gridResultados.Rows[rowIndex];
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)row.Cells["detalles"];
                        buttonCell.Value = "Ver Detalles";
                    }
                    RemoverColumnasVacias();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridConsolidado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de columna corresponda a la columna del botón y que no sea una fila de encabezado
            if (gridResultados.Columns[e.ColumnIndex].Name == "detalles" && e.RowIndex >= 0)
            {
                // Obtén el reporte correspondiente a la fila seleccionada
                var reporte = list[e.RowIndex]; // Asegúrate de que 'list' esté accesible aquí

                // Supongamos que 'reporte.Detalles' es una lista de DetalleDte
                List<DetalleDte> detalles = reporte.Detalles;

                // Llama al método para mostrar los detalles
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

            // Crear y mostrar el formulario de detalles
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
            }
            if (radio_Bton_recibidoListado.Checked) 
            { 
                textNombreSucursal.Enabled = false; 
                dateTimeDesde.Value = DateTime.Parse("2024-04-01"); 
                dateTimeHasta.Value = DateTime.Parse("2024-04-30"); 
                comboBoxCodigoTipoDTE.SelectedIndex = 0; 
                radioCertificacion.Checked = false; 
                radioProduccion.Checked = true; 
            }
        }
    }
}
