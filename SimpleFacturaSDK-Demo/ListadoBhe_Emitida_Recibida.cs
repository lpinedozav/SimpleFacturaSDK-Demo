using SDKSimpleFactura;
using SDKSimpleFactura.Models.Request;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class ListadoBhe_Emitida_Recibida : Form
    {
        private AppSettings _appSettings;
        private SimpleFacturaClient cliente;

        public ListadoBhe_Emitida_Recibida()
        {
            InitializeComponent();
            _appSettings = AppSettings.Current;
            cliente = SimpleClientSingleton.Instance;

            // Ajustar las columnas para que llenen el espacio disponible
            dataGridEmisor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReceptor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTotales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOtros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListadoBhe_Emitida_Recibida_Load(object sender, EventArgs e)
        {
            textRutEmisor.Text = _appSettings.Credenciales.RutEmisor;
            textNombreSucursal.Text = _appSettings.Credenciales.NombreSucursal;
            dateTimeDesde.Value = DateTime.Parse("2024-09-03");
            dateTimeHasta.Value = DateTime.Parse("2024-11-11");
            folio_oListado.Value = 0;

            // Quitar fila vacía
            dataGridEmisor.AllowUserToAddRows = false;
            dataGridReceptor.AllowUserToAddRows = false;
            dataGridTotales.AllowUserToAddRows = false;
            gridOtros.AllowUserToAddRows = false;

            ChangeUI();
        }

        private async void generarListadoBHE_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new ListaBHERequest
                {
                    Credenciales = new SDKSimpleFactura.Models.Facturacion.Credenciales()
                };
                request.Credenciales.RutEmisor = textRutEmisor.Text;
                request.Credenciales.NombreSucursal = textNombreSucursal.Text;
                request.Desde = dateTimeDesde.Value;
                request.Hasta = dateTimeHasta.Value;

                var response = (radioButton_emitidoListado.Checked)
                    ? await cliente.BoletasHonorarios.ListadoBHEEmitidasAsync(request)
                    : await cliente.BoletasHonorarios.ListadoBHERecibidosAsync(request);

                if (response.Status == 200)
                {
                    var data = response.Data;

                    if (data == null || data.Count == 0)
                    {
                        // Sin datos
                        LimpiarDataGrids();
                        MessageBox.Show("No se encontraron datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Llenar DataGridView según el caso
                    if (radioButton_emitidoListado.Checked)
                    {
                        dataGridEmisor.DataSource = data.Select(d => new {
                            Rut = d.Emisor?.rutEmisor,
                            direccion = d.Emisor?.Direccion,
                            razonSocial = d.Emisor?.RazonSocial
                        }).ToList();

                        dataGridReceptor.DataSource = data.Select(d => new {
                            RutReceptor = d.Receptor?.Rut,
                            ComunaReceptor = d.Receptor?.Comuna,
                            Nombre = d.Receptor?.Nombre,
                            DireccionReceptor = d.Receptor?.Direccion,
                            Region = d.Receptor?.Region
                        }).ToList();

                        dataGridTotales.DataSource = data.Select(d => new {
                            TotalHonorarios = d.Totales?.TotalHonorarios,
                            MontoBruto = d.Totales?.Bruto,
                            MontoLiquido = d.Totales?.Liquido,
                            pagado = 0,
                            retenido = 0
                        }).ToList();

                        gridOtros.DataSource = data.Select(d => new {
                            folio = d.Folio,
                            fechaEmision = d.FechaEmision,
                            codigoBarra = d.CodigoBarra,
                            estado = d.Estado,
                            descripcionAnulacion = d.DescripcionAnulacion
                        }).ToList();

                        // Mostrar columnas necesarias, por si las ocultamos antes
                        if (gridOtros.Columns["codigoBarra"] != null)
                            gridOtros.Columns["codigoBarra"].Visible = true;
                        if (gridOtros.Columns["descripcionAnulacion"] != null)
                            gridOtros.Columns["descripcionAnulacion"].Visible = true;
                    }
                    else
                    {
                        // Recibido
                        dataGridEmisor.DataSource = data.Select(d => new {
                            Rut = d.Emisor?.rutEmisor,
                            direccion = "",
                            razonSocial = d.Emisor?.RazonSocial
                        }).ToList();

                        dataGridReceptor.DataSource = data.Select(d => new {
                            RutReceptor = d.Receptor?.Rut,
                            ComunaReceptor = "",
                            Nombre = d.Receptor?.Nombre,
                            DireccionReceptor = "",
                            Region = ""
                        }).ToList();

                        dataGridTotales.DataSource = data.Select(d => new {
                            TotalHonorarios = d.Totales?.TotalHonorarios,
                            MontoBruto = d.Totales?.Bruto,
                            MontoLiquido = d.Totales?.Liquido,
                            pagado = d.Totales?.Pagado,
                            retenido = d.Totales?.Retenido
                        }).ToList();

                        gridOtros.DataSource = data.Select(d => new {
                            folio = d.Folio,
                            fechaEmision = d.FechaEmision,
                            codigoBarra = "",
                            estado = d.Estado,
                            descripcionAnulacion = ""
                        }).ToList();

                        // Ocultar columnas no necesarias
                        if (gridOtros.Columns["codigoBarra"] != null)
                            gridOtros.Columns["codigoBarra"].Visible = false;
                        if (gridOtros.Columns["descripcionAnulacion"] != null)
                            gridOtros.Columns["descripcionAnulacion"].Visible = false;
                    }

                    // Ocultar columnas completamente vacías
                    OcultarColumnasVacias(dataGridEmisor);
                    OcultarColumnasVacias(dataGridReceptor);
                    OcultarColumnasVacias(dataGridTotales);
                    OcultarColumnasVacias(gridOtros);

                }
                else
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton_emitidoListado_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUI();
        }

        private void radioButton_recibidoListado_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUI();
        }

        private void ChangeUI()
        {
            // Ajustes de interfaz según el estado Emitido/Recibido
        }

        private void LimpiarDataGrids()
        {
            dataGridEmisor.DataSource = null;
            dataGridEmisor.Columns.Clear();
            dataGridReceptor.DataSource = null;
            dataGridReceptor.Columns.Clear();
            dataGridTotales.DataSource = null;
            dataGridTotales.Columns.Clear();
            gridOtros.DataSource = null;
            gridOtros.Columns.Clear();
        }

        private void OcultarColumnasVacias(DataGridView dgv)
        {
            if (dgv.DataSource == null) return;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                bool allEmpty = true;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[col.Index].Value != null && !string.IsNullOrWhiteSpace(row.Cells[col.Index].Value.ToString()))
                    {
                        allEmpty = false;
                        break;
                    }
                }
                // Si todas las celdas de esta columna están vacías, la ocultamos
                if (allEmpty) col.Visible = false;
            }
        }
    }
}
