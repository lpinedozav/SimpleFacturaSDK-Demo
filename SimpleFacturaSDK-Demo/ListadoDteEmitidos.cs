using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Request;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ListadoDteEmitidos : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        private List<DteEnt> list;
        public ListadoDteEmitidos()
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
            comboBoxCodigoTipoDTE.SelectedIndex = 3; // Seleccionar el primer ítem del ComboBox
            dateTimeDesde.Value = DateTime.Now.AddDays(-4); // Predeterminado a 4 días antes de hoy
            dateTimeHasta.Value = DateTime.Now; // Predeterminado al día actual
            radioCertificacion.Checked = true; // Ambiente predeterminado: Certificación
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

                var request = new ListaDteRequest()
                {
                    Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales()
                };
                request.Credenciales.RutEmisor = textRutEmisor.Text;
                request.Credenciales.NombreSucursal = textNombreSucursal.Text;
                request.Desde = dateTimeDesde.Value;
                request.Hasta = dateTimeHasta.Value;
                request.Ambiente = ambienteSeleccionado;
                var response = await cliente.Facturacion.ListadoDtesEmitidosAsync(request);
                if (response.Status == 400 || response.Status == 500)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    list = response.Data;


                    gridResultados.Rows.Clear();
                    //gridResultados.CellContentClick += dataGridConsolidado_CellContentClick;
                    DataGridViewButtonCell detallesColumn = new DataGridViewButtonCell();
                    detallesColumn.Value = "Ver Detalles";
                    detallesColumn.UseColumnTextForButtonValue = true; // Hace que todas las celdas muestren el mismo texto en el botón
                                                                       // Recorre cada objeto RepoteDTE en la lista
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

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
