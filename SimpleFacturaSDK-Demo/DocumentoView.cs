using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace SimpleFacturaSDK_Demo
{

    public partial class DocumentoView : Form
    {
        private PdfViewer pdfViewer;
        public DocumentoView(string pdfPath)
        {
            InitializeComponent();
            this.Text = "Visor de PDF";
            this.WindowState = FormWindowState.Maximized;

            // Crear el control PdfViewer
            pdfViewer = new PdfViewer
            {
                Dock = DockStyle.Fill,
                ShowToolbar = true // Opcional: Muestra una barra de herramientas básica
            };

            this.Controls.Add(pdfViewer);

            // Cargar el archivo PDF
            try
            {
                var document = PdfDocument.Load(pdfPath);
                pdfViewer.Document = document;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}