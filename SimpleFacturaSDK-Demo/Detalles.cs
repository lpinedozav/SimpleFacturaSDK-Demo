using SDKSimpleFactura.Models.Facturacion;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }
        public void SetDetalles<T>(List<T> detalles, string titulo)
        {
            Text = titulo;
            SetDetalles(detalles);
        }

        // Método para asignar los detalles al DataGridView
        public void SetDetalles<T>(List<T> detalles)
        {
            if (detalles == null || detalles.Count == 0)
            {
                MessageBox.Show("No hay detalles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Asignar la lista de detalles al DataGridView
            dataGridViewDetalles.DataSource = detalles;

            // Ajustar las columnas al contenido y al título
            dataGridViewDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Ocultar encabezados de fila si no son necesarios
            dataGridViewDetalles.RowHeadersVisible = false;

            // Opcional: Eliminar columnas vacías
            EliminarColumnasSinDatos(detalles);
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            // Puedes agregar código aquí si necesitas inicializar algo al cargar el formulario
        }

        private void EliminarColumnasSinDatos<T>(List<T> detalles)
        {
            foreach (DataGridViewColumn column in dataGridViewDetalles.Columns)
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

    }
}
