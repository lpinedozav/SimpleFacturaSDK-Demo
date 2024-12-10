using SimpleFacturaSDK_Demo.Models;
using System;
using System.Windows.Forms;

namespace SimpleFacturaSDK_Demo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void obtener_pdf_Click(object sender, EventArgs e)
        {
            ObtenerPDF formulario = new ObtenerPDF();
            formulario.Show();
        }

        private void ObtenerTimbre_Click(object sender, EventArgs e)
        {
            ObtenerTimbre formulario = new ObtenerTimbre();
            formulario.Show();

        }

        private void obtener_xml_Click(object sender, EventArgs e)
        {
            ObtenerXML formulario = new ObtenerXML();
            formulario.Show();
        }

        private void obtener_dte_Click(object sender, EventArgs e)
        {
            ObtenerDTE formulario = new ObtenerDTE();
            formulario.Show();
        }

        private void obtener_sobre_xml_Click(object sender, EventArgs e)
        {
            ObtenerSobreXML formulario = new ObtenerSobreXML();
            formulario.Show();
        }

        private void facturacion_dte_boleta_Click(object sender, EventArgs e)
        {
            FacturacionDte_boleta formulario = new FacturacionDte_boleta();
            formulario.Show();
        }

        private void facturacion_exportacion_Click(object sender, EventArgs e)
        {
            FacturacionExportacion formulario = new FacturacionExportacion();
            formulario.Show();
        }

        private void facturacion_masiva_Click(object sender, EventArgs e)
        {
            FacturacionMasiva formulario = new FacturacionMasiva();
            formulario.Show();
        }

        private void emision_nc_nd_Click(object sender, EventArgs e)
        {
            EmisonNC_ND formulario = new EmisonNC_ND();
            formulario.Show();
        }

        private void listado_dte_emitido_Recibido_Click(object sender, EventArgs e)
        {
            ListadoDteEmitidos_Recibidos formulario = new ListadoDteEmitidos_Recibidos();
            formulario.Show();
        }

        private void envio_mail_Click(object sender, EventArgs e)
        {
            EnviarMail formulario = new EnviarMail();
            formulario.Show();
        }

        private void consolidado_ventas_Click(object sender, EventArgs e)
        {
            ConsolidadoVenta formulario = new ConsolidadoVenta();
            formulario.Show();
        }

        private void conciliar_emitidos_Recibidos_Click(object sender, EventArgs e)
        {
            ConciliarEmitidos_Recibidos formulario = new ConciliarEmitidos_Recibidos();
            formulario.Show();
        }

        private void Configuracion_Click(object sender, EventArgs e)
        {
            Configuracion formulario = new Configuracion();
            formulario.Show();
        }

        private void Acuse_Click(object sender, EventArgs e)
        {
            Acuse formulario = new Acuse();
            formulario.Show();
        }

        private void agregar_productos_Click(object sender, EventArgs e)
        {
            AgregarProductos formulario = new AgregarProductos();
            formulario.Show();
        }

        private void listar_productos_Click(object sender, EventArgs e)
        {
            ListarProductos formulario = new ListarProductos();
            formulario.Show();
        }

        private void agregarClientes_Click(object sender, EventArgs e)
        {
            AgregarCliente formulario = new AgregarCliente();
            formulario.Show();
        }
        private void listarClientes_Click(object sender, EventArgs e)
        {
            ListarClientes formulario = new ListarClientes();
            formulario.Show();
        }
        private void ListarSucursales_Click(object sender, EventArgs e)
        {
            ListarSucursales formulario = new ListarSucursales();
            formulario.Show();
        }

        private void datosEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void FoliosDisponibles_Click(object sender, EventArgs e)
        {
            ConsultaFoliosDisponibles formulario = new ConsultaFoliosDisponibles();
            formulario.Show();
        }
    }
}
