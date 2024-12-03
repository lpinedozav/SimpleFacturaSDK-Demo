using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
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
    public partial class ObtenerDTE : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        public ObtenerDTE()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipodte_oDTE);
        }

        private void ObtenerDTE_Load_1(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;
            tipodte_oDTE.SelectedIndex = 0;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
        }

        private void cancelarDte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void consultarDTE_Click(object sender, EventArgs e)
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
                    // Si no se selecciona ningún ambiente, mostrar un mensaje
                    MessageBox.Show("Por favor, selecciona un ambiente (Certificación o Producción).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (tipodte_oDTE.SelectedItem is ComboBoxItem selectedItem)
                {
                    var tipoDte = (DTEType)selectedItem.Value; // Obtener el enum seleccionado
                    var request = new SolicitudDte
                    {
                        Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(), // Inicializamos Credenciales
                        DteReferenciadoExterno = new DteReferenciadoExterno() // Inicializamos DteReferenciadoExterno
                    };

                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.DteReferenciadoExterno.Folio = (int)folio_oPDF.Value;

                    // Asignar el valor del tipo de DTE seleccionado
                    request.DteReferenciadoExterno.CodigoTipoDte = (int)tipoDte;
                    request.DteReferenciadoExterno.Ambiente = (int)ambienteSeleccionado;

                    // Crear un mensaje con los valores que deseas mostrar
                    string mensaje = $"Datos.\n" +
                                     $"Rut Emisor: {request.Credenciales.RutEmisor}\n" +
                                     $"Folio: {request.DteReferenciadoExterno.Folio}\n" +
                                     $"Código Tipo DTE: {request.DteReferenciadoExterno.CodigoTipoDte}\n" +
                                     $"Ambiente: {request.DteReferenciadoExterno.Ambiente}";
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var response = await cliente.Facturacion.ObtenerDteAsync(request);
                    if (response.Status == 400 || response.Status == 500)
                    {
                        MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (response.Data != null)
                        {
                            // Asignar el objeto DTEent como fuente de datos
                            dataGridView1.DataSource = new List<DteEnt> { response.Data };

                            // Agregar una columna de botón si no existe
                            if (!dataGridView1.Columns.Contains("Detalles"))
                            {
                                DataGridViewButtonColumn detallesButtonColumn = new DataGridViewButtonColumn
                                {
                                    Name = "Detalles",
                                    HeaderText = "Detalles",
                                    Text = "Ver Detalles",
                                    UseColumnTextForButtonValue = true
                                };
                                dataGridView1.Columns.Add(detallesButtonColumn);
                                dataGridView1.CellClick += dataGridView1_CellClick;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se hizo clic en la columna "Detalles"
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Detalles")
            {
                // Obtener el objeto DTEent correspondiente a la fila seleccionada
                DteEnt selectedDte = (DteEnt)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                // Obtener la lista de detalles asociada
                List<DetalleDte> detalles = selectedDte.Detalles; // Asegúrate de que 'Detalles' es el nombre de la lista en tu clase DTEent

                // Mostrar la lista de detalles en otra tabla o ventana
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


    }
}
