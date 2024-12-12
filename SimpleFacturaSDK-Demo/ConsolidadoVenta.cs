using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Request;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using SimpleFacturaSDK_Demo.Helpers;
using System.Diagnostics;

namespace SimpleFacturaSDK_Demo
{
    public partial class ConsolidadoVenta : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        private List<ReporteDTE> list;

        public ConsolidadoVenta()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
        }

        private void ConsolidadoVenta_Load(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;
            textRut.Text = _appSettings.Credenciales.RutEmisor;
            dataGridConsolidado.CellContentClick += dataGridConsolidado_CellContentClick; // Asocia el evento al DataGridView

            string descripcion =
                 "Este endpoint proporciona un consolidado de ventas desde el portal SimpleFactura. A través de una solicitud, el usuario puede obtener datos en formato JSON, especificando el RUT del emisor y un rango de fechas para filtrar los resultados. ";

            textDocumentacion.Text = descripcion;
        }

        private async void generarConsolidadoV_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarConsolidadoV);
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

                var request = new ListaDteRequest()
                {
                    Credenciales = new Credenciales()
                };
                request.Credenciales.RutEmisor = textRut.Text;
                request.Desde = dateTimeDesde.Value;
                request.Hasta = dateTimeHasta.Value;
                request.Ambiente = ambienteSeleccionado;

                var response = await cliente.Facturacion.ConsolidadoVentasAsync(request);

                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    list = response.Data;

                    // Asigna la lista al DataSource del DataGridView
                    dataGridConsolidado.DataSource = null;
                    dataGridConsolidado.DataSource = list;

                    // Configurar columnas adicionales (botones)
                    ConfigurarColumnasBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarConsolidadoV);
            }
        }

        private void ConfigurarColumnasBotones()
        {
            // Verifica si ya existe la columna "detalle"
            if (dataGridConsolidado.Columns["detalle"] == null)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                {
                    Name = "detalle",
                    HeaderText = "Detalles",
                    Text = "Ver Detalles",
                    UseColumnTextForButtonValue = true
                };

                dataGridConsolidado.Columns.Add(buttonColumn);
            }

            // Ajusta los estilos de las celdas según la lógica del reporte
            foreach (DataGridViewRow row in dataGridConsolidado.Rows)
            {
                if (row.Cells["detalle"] is DataGridViewButtonCell buttonCell)
                {
                    var reporte = row.DataBoundItem as ReporteDTE;

                    if (reporte?.Detalle == null || reporte.Detalle.Count == 0)
                    {
                        buttonCell.Value = "Sin Detalles";
                        buttonCell.Style.ForeColor = System.Drawing.Color.Gray;
                        buttonCell.Style.BackColor = System.Drawing.Color.LightGray;
                        buttonCell.FlatStyle = FlatStyle.Flat;
                    }
                    else
                    {
                        buttonCell.Value = "Ver Detalles";
                        buttonCell.Style.ForeColor = System.Drawing.Color.Black;
                        buttonCell.Style.BackColor = System.Drawing.Color.White;
                        buttonCell.FlatStyle = FlatStyle.Flat;
                    }
                }
            }

            // Ajustar el ancho de las columnas automáticamente
            dataGridConsolidado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridConsolidado.AllowUserToAddRows = false;
        }

        private void dataGridConsolidado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de columna corresponda a la columna del botón y que no sea una fila de encabezado
            if (dataGridConsolidado.Columns[e.ColumnIndex].Name == "detalle" && e.RowIndex >= 0)
            {
                var reporte = list[e.RowIndex];
                List<DetalleDte> detalles = reporte.Detalle;
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

        private void linkLabelConsolidado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
