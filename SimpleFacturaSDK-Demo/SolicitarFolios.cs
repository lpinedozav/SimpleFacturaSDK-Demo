using SDKSimpleFactura;
using SDKSimpleFactura.Models.Request;
using SimpleFacturaSDK_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class SolicitarFolios : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;

        public SolicitarFolios()
        {
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;
            InitializeComponent();
        }

        private void SolicitarFolios_Load(object sender, EventArgs e)
        {
            EnumHelper.LlenarComboBoxConEnum<DTEType>(comboBoxCodigoTipoDTE);
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            comboBoxCodigoTipoDTE.SelectedIndex = 3;
            numericCantidad.Value = 1;
        }

        private async void generarSolicitarFolio_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(generarSolicitarFolio);
            try
            {
                FolioRequest request = new FolioRequest();
                request.Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales();
                request.Credenciales.RutEmisor = textRutEmisor.Text;
                request.Credenciales.NombreSucursal = textNombreSucursal.Text;
                request.Cantidad = (int)numericCantidad.Value;
                request.CodigoTipoDte = EnumHelper.ObtenerValorSeleccionado<DTEType>(comboBoxCodigoTipoDTE);
                var response = await cliente.Folio.SolicitarFoliosAsync(request);
                if (response.Status != 200)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Transformar response.Data en una lista de PropertyValuePair
                    var propertyValueList = new List<PropiedadValor>();

                    if (response.Data != null)
                    {
                        var properties = response.Data.GetType().GetProperties();

                        foreach (var prop in properties)
                        {
                            var value = prop.GetValue(response.Data, null);
                            string formattedValue;

                            if (value is DateTime dateTime)
                            {
                                formattedValue = dateTime.ToString("dd/MM/yyyy");
                            }
                            else if (value == null)
                            {
                                formattedValue = "N/A";
                            }
                            else if (value.GetType().IsPrimitive || value is string)
                            {
                                formattedValue = value.ToString();
                            }
                            else
                            {
                                // Para objetos complejos, serializar a JSON
                                formattedValue = Newtonsoft.Json.JsonConvert.SerializeObject(value);
                            }

                            propertyValueList.Add(new PropiedadValor
                            {
                                Propiedad = prop.Name,
                                Valor = formattedValue
                            });
                        }
                    }

                    // Asignar la lista a la grilla
                    gridResultados.AutoGenerateColumns = false;
                    gridResultados.DataSource = propertyValueList;

                    // Configurar columnas si no están configuradas
                    if (gridResultados.Columns.Count == 0)
                    {
                        // Columna para "Propiedad"
                        var columnaPropiedad = new DataGridViewTextBoxColumn
                        {
                            HeaderText = "Propiedad",
                            DataPropertyName = "Propiedad",
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        };
                        gridResultados.Columns.Add(columnaPropiedad);

                        // Columna para "Valor"
                        var columnaValor = new DataGridViewTextBoxColumn
                        {
                            HeaderText = "Valor",
                            DataPropertyName = "Valor",
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        };
                        gridResultados.Columns.Add(columnaValor);
                    }

                    gridResultados.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(generarSolicitarFolio);
            }
        }
    }
}
