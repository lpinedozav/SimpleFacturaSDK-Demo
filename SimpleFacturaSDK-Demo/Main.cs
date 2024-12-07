﻿using SimpleFacturaSDK_Demo.Models;
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

        private void listado_dte_emitido_Click(object sender, EventArgs e)
        {
            ListadoDteEmitidos formulario = new ListadoDteEmitidos();
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

        private void conciliar_emitidos_Click(object sender, EventArgs e)
        {
            ConciliarEmitidos formulario = new ConciliarEmitidos();
            formulario.Show();
        }

        private void Configuracion_Click(object sender, EventArgs e)
        {
            Configuracion formulario = new Configuracion();
            formulario.Show();
        }
    }
}
