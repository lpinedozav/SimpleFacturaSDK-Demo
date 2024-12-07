﻿using SDKSimpleFactura.Models.Facturacion;
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

        // Método para asignar los detalles al DataGridView
        public void SetDetalles(List<DetalleDte> detalles)
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

        private void EliminarColumnasSinDatos(List<DetalleDte> detalles)
        {
            // Iterar por las columnas
            foreach (DataGridViewColumn column in dataGridViewDetalles.Columns)
            {
                bool hasData = false;

                // Revisar si alguna fila tiene un valor no nulo o no vacío en esta columna
                foreach (var detalle in detalles)
                {
                    var value = detalle.GetType().GetProperty(column.DataPropertyName)?.GetValue(detalle, null);

                    if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                    {
                        hasData = true;
                        break;
                    }
                }

                // Si ninguna fila tiene datos, ocultar la columna
                if (!hasData)
                {
                    column.Visible = false;
                }
            }
        }
    }
}
