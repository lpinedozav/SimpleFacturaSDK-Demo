using SDKSimpleFactura;
using SDKSimpleFactura.Models.Facturacion;
using SDKSimpleFactura.Models.Response;
using SimpleFacturaSDK_Demo.Helpers;
using SimpleFacturaSDK_Demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using static SDKSimpleFactura.Enum.Ambiente;
using static SDKSimpleFactura.Enum.TipoDTE;

namespace SimpleFacturaSDK_Demo
{
    public partial class ObtenerDTE : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;
        private DteEnt _dteEnt;

        public ObtenerDTE()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            EnumHelper.LlenarComboBoxConEnum<DTEType>(tipodte_oDTE);

            // Configurar el DataGridView
            ConfigurarDataGridView();
        }

        private void ObtenerDTE_Load_1(object sender, EventArgs e)
        {
            cliente = SimpleClientSingleton.Instance;
            tipodte_oDTE.SelectedIndex = 3;
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
        }

        private void ConfigurarDataGridView()
        {
            gridResultado.AutoGenerateColumns = false;
            gridResultado.Columns.Clear();

            // Columna para el nombre de la propiedad
            DataGridViewTextBoxColumn colPropiedad = new DataGridViewTextBoxColumn
            {
                Name = "Propiedad", // Establecer el nombre de la columna
                HeaderText = "Propiedad",
                DataPropertyName = "Propiedad",
                ReadOnly = true
            };
            gridResultado.Columns.Add(colPropiedad);

            // Columna para el valor de la propiedad
            DataGridViewTextBoxColumn colValor = new DataGridViewTextBoxColumn
            {
                Name = "Valor", // Establecer el nombre de la columna
                HeaderText = "Valor",
                DataPropertyName = "Valor",
                ReadOnly = true
            };
            gridResultado.Columns.Add(colValor);

            gridResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridResultado.RowHeadersVisible = false;

            // Manejar el evento CellContentClick
            gridResultado.CellContentClick -= dataGridView1_CellContentClick;
            gridResultado.CellContentClick += dataGridView1_CellContentClick;
        }

        private async void consultarDTE_Click(object sender, EventArgs e)
        {
            Loading.ShowLoading(consultarDTE);
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

                if (tipodte_oDTE.SelectedItem is ComboBoxItem selectedItem)
                {
                    var tipoDte = (DTEType)selectedItem.Value;
                    var request = new SolicitudDte
                    {
                        Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales(),
                        DteReferenciadoExterno = new DteReferenciadoExterno()
                    };

                    request.Credenciales.RutEmisor = textRutEmisor.Text;
                    request.DteReferenciadoExterno.Folio = (int)folio_oPDF.Value;
                    request.DteReferenciadoExterno.CodigoTipoDte = (int)tipoDte;
                    request.DteReferenciadoExterno.Ambiente = (int)ambienteSeleccionado;

                    var response = await cliente.Facturacion.ObtenerDteAsync(request);
                    if (response.Status == 400 || response.Status == 500)
                    {
                        MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (response.Data != null)
                    {
                        _dteEnt = response.Data;

                        // Poblar el DataGridView
                        var propiedades = ObtenerPropiedadesDteEnt(_dteEnt);
                        gridResultado.DataSource = propiedades;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridResultado.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ocultar el indicador de carga
                Loading.HideLoading(consultarDTE);
            }
        }

        private List<PropiedadValor> ObtenerPropiedadesDteEnt(DteEnt dteEnt)
        {
            var propiedades = new List<PropiedadValor>();

            foreach (PropertyInfo prop in typeof(DteEnt).GetProperties())
            {
                var valor = prop.GetValue(dteEnt);

                // Saltar las propiedades que no tienen valor
                if (valor == null || string.IsNullOrWhiteSpace(valor.ToString()))
                {
                    continue;
                }

                if (prop.Name == "Detalles")
                {
                    // Verificar si hay detalles antes de agregar la entrada
                    var detalles = valor as List<DetalleDte>;
                    if (detalles != null && detalles.Count > 0)
                    {
                        gridDetalles.DataSource = detalles;
                        EliminarColumnasSinDatos(detalles);
                    }
                }
                if(prop.Name == "Referencias")
                {
                    var referencias = valor as List<ReferenciaDte>;
                    if (referencias != null && referencias.Count > 0)
                        // Agregar una entrada para "Detalles" con un botón en la columna "Valor"
                        propiedades.Add(new PropiedadValor
                        {
                            Propiedad = prop.Name,
                            Valor = "Ver Referencias"
                        });
                    propiedades.Add(new PropiedadValor
                    {
                        Propiedad = prop.Name,
                        Valor = "Sin Referencias"
                    });
                }
                else
                {
                    string valorStr = valor.ToString();

                    propiedades.Add(new PropiedadValor
                    {
                        Propiedad = prop.Name,
                        Valor = valorStr
                    });
                }
            }

            return propiedades;
        }
        private void EliminarColumnasSinDatos<T>(List<T> detalles)
        {
            foreach (DataGridViewColumn column in gridDetalles.Columns)
            {
                bool hasData = false;

                foreach (var detalle in detalles)
                {
                    var value = typeof(T).GetProperty(column.DataPropertyName)?.GetValue(detalle, null);

                    if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                    {
                        hasData = true;
                        break;
                    }
                }

                if (!hasData)
                {
                    column.Visible = false;
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que no se hizo clic en el encabezado
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si se hizo clic en la columna "Valor"
                if (gridResultado.Columns[e.ColumnIndex].Name == "Valor")
                {
                    var propiedad = gridResultado.Rows[e.RowIndex].Cells["Propiedad"].Value.ToString();

                    if (propiedad == "Referencias")
                    {
                        // Mostrar los detalles
                        MostrarDetallesEnOtraTabla(_dteEnt?.Referencias);
                    }
                }
            }
        }

        private void MostrarDetallesEnOtraTabla(List<ReferenciaDte> referencias)
        {
            if (referencias == null || referencias.Count == 0)
            {
                MessageBox.Show("No hay referencias para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear y mostrar el formulario de detalles
            Detalles detallesForm = new Detalles();
            detallesForm.SetDetalles(referencias, "Referencias");
            detallesForm.ShowDialog();
        }

        private void linkLabelDTE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://documentacion.simplefactura.cl/#ed2fe5e8-1fcb-4339-927d-cdc379628950";

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
