namespace SimpleFacturaSDK_Demo
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.item_facturacion = new System.Windows.Forms.TabPage();
            this.otros = new System.Windows.Forms.GroupBox();
            this.conciliar_emitidos_Recibidos = new System.Windows.Forms.Button();
            this.Acuse = new System.Windows.Forms.Button();
            this.envio_mail = new System.Windows.Forms.Button();
            this.consolidado_ventas = new System.Windows.Forms.Button();
            this.emision_dte = new System.Windows.Forms.GroupBox();
            this.emision_nc_nd = new System.Windows.Forms.Button();
            this.facturacion_masiva = new System.Windows.Forms.Button();
            this.facturacion_dte = new System.Windows.Forms.Button();
            this.listado_dte_emitido_Recibido = new System.Windows.Forms.Button();
            this.facturacion_exportacion = new System.Windows.Forms.Button();
            this.obtenerdte = new System.Windows.Forms.GroupBox();
            this.obtener_sobre_xml = new System.Windows.Forms.Button();
            this.obtener_dte = new System.Windows.Forms.Button();
            this.obtener_xml = new System.Windows.Forms.Button();
            this.obtener_timbre = new System.Windows.Forms.Button();
            this.obtener_pdf = new System.Windows.Forms.Button();
            this.item_otros = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listar_productos = new System.Windows.Forms.Button();
            this.agregar_productos = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.item_facturacion.SuspendLayout();
            this.otros.SuspendLayout();
            this.emision_dte.SuspendLayout();
            this.obtenerdte.SuspendLayout();
            this.item_otros.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.item_facturacion);
            this.tabControl2.Controls.Add(this.item_otros);
            this.tabControl2.Location = new System.Drawing.Point(13, 55);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(623, 315);
            this.tabControl2.TabIndex = 1;
            // 
            // item_facturacion
            // 
            this.item_facturacion.Controls.Add(this.otros);
            this.item_facturacion.Controls.Add(this.emision_dte);
            this.item_facturacion.Controls.Add(this.obtenerdte);
            this.item_facturacion.Location = new System.Drawing.Point(4, 22);
            this.item_facturacion.Name = "item_facturacion";
            this.item_facturacion.Padding = new System.Windows.Forms.Padding(3);
            this.item_facturacion.Size = new System.Drawing.Size(615, 289);
            this.item_facturacion.TabIndex = 0;
            this.item_facturacion.Text = "Facturación";
            this.item_facturacion.UseVisualStyleBackColor = true;
            // 
            // otros
            // 
            this.otros.Controls.Add(this.conciliar_emitidos_Recibidos);
            this.otros.Controls.Add(this.Acuse);
            this.otros.Controls.Add(this.envio_mail);
            this.otros.Controls.Add(this.consolidado_ventas);
            this.otros.Location = new System.Drawing.Point(412, 15);
            this.otros.Name = "otros";
            this.otros.Size = new System.Drawing.Size(191, 254);
            this.otros.TabIndex = 2;
            this.otros.TabStop = false;
            this.otros.Text = "Otros";
            // 
            // conciliar_emitidos_Recibidos
            // 
            this.conciliar_emitidos_Recibidos.Location = new System.Drawing.Point(15, 117);
            this.conciliar_emitidos_Recibidos.Name = "conciliar_emitidos_Recibidos";
            this.conciliar_emitidos_Recibidos.Size = new System.Drawing.Size(164, 38);
            this.conciliar_emitidos_Recibidos.TabIndex = 13;
            this.conciliar_emitidos_Recibidos.Text = "Conciliar Emitido / Recibido";
            this.conciliar_emitidos_Recibidos.UseVisualStyleBackColor = true;
            this.conciliar_emitidos_Recibidos.Click += new System.EventHandler(this.conciliar_emitidos_Recibidos_Click);
            // 
            // Acuse
            // 
            this.Acuse.Location = new System.Drawing.Point(15, 161);
            this.Acuse.Name = "Acuse";
            this.Acuse.Size = new System.Drawing.Size(164, 38);
            this.Acuse.TabIndex = 11;
            this.Acuse.Text = "Aceptar o Recharzar DTE";
            this.Acuse.UseVisualStyleBackColor = true;
            this.Acuse.Click += new System.EventHandler(this.Acuse_Click);
            // 
            // envio_mail
            // 
            this.envio_mail.Location = new System.Drawing.Point(15, 27);
            this.envio_mail.Name = "envio_mail";
            this.envio_mail.Size = new System.Drawing.Size(164, 38);
            this.envio_mail.TabIndex = 11;
            this.envio_mail.Text = "Envio Mail";
            this.envio_mail.UseVisualStyleBackColor = true;
            this.envio_mail.Click += new System.EventHandler(this.envio_mail_Click);
            // 
            // consolidado_ventas
            // 
            this.consolidado_ventas.Location = new System.Drawing.Point(15, 73);
            this.consolidado_ventas.Name = "consolidado_ventas";
            this.consolidado_ventas.Size = new System.Drawing.Size(164, 38);
            this.consolidado_ventas.TabIndex = 12;
            this.consolidado_ventas.Text = "Consolidado de ventas";
            this.consolidado_ventas.UseVisualStyleBackColor = true;
            this.consolidado_ventas.Click += new System.EventHandler(this.consolidado_ventas_Click);
            // 
            // emision_dte
            // 
            this.emision_dte.Controls.Add(this.emision_nc_nd);
            this.emision_dte.Controls.Add(this.facturacion_masiva);
            this.emision_dte.Controls.Add(this.facturacion_dte);
            this.emision_dte.Controls.Add(this.listado_dte_emitido_Recibido);
            this.emision_dte.Controls.Add(this.facturacion_exportacion);
            this.emision_dte.Location = new System.Drawing.Point(215, 15);
            this.emision_dte.Name = "emision_dte";
            this.emision_dte.Size = new System.Drawing.Size(191, 254);
            this.emision_dte.TabIndex = 1;
            this.emision_dte.TabStop = false;
            this.emision_dte.Text = "Emision DTE";
            // 
            // emision_nc_nd
            // 
            this.emision_nc_nd.Location = new System.Drawing.Point(14, 159);
            this.emision_nc_nd.Name = "emision_nc_nd";
            this.emision_nc_nd.Size = new System.Drawing.Size(164, 38);
            this.emision_nc_nd.TabIndex = 9;
            this.emision_nc_nd.Text = "Emisión NC/ND";
            this.emision_nc_nd.UseVisualStyleBackColor = true;
            this.emision_nc_nd.Click += new System.EventHandler(this.emision_nc_nd_Click);
            // 
            // facturacion_masiva
            // 
            this.facturacion_masiva.Location = new System.Drawing.Point(14, 115);
            this.facturacion_masiva.Name = "facturacion_masiva";
            this.facturacion_masiva.Size = new System.Drawing.Size(164, 38);
            this.facturacion_masiva.TabIndex = 8;
            this.facturacion_masiva.Text = "Facturación Masiva";
            this.facturacion_masiva.UseVisualStyleBackColor = true;
            this.facturacion_masiva.Click += new System.EventHandler(this.facturacion_masiva_Click);
            // 
            // facturacion_dte
            // 
            this.facturacion_dte.Location = new System.Drawing.Point(14, 27);
            this.facturacion_dte.Name = "facturacion_dte";
            this.facturacion_dte.Size = new System.Drawing.Size(164, 38);
            this.facturacion_dte.TabIndex = 5;
            this.facturacion_dte.Text = "Facturación DTE / Boletas";
            this.facturacion_dte.UseVisualStyleBackColor = true;
            this.facturacion_dte.Click += new System.EventHandler(this.facturacion_dte_boleta_Click);
            // 
            // listado_dte_emitido_Recibido
            // 
            this.listado_dte_emitido_Recibido.Location = new System.Drawing.Point(14, 203);
            this.listado_dte_emitido_Recibido.Name = "listado_dte_emitido_Recibido";
            this.listado_dte_emitido_Recibido.Size = new System.Drawing.Size(164, 38);
            this.listado_dte_emitido_Recibido.TabIndex = 10;
            this.listado_dte_emitido_Recibido.Text = "Listado DTE Emitido / Recibido";
            this.listado_dte_emitido_Recibido.UseVisualStyleBackColor = true;
            this.listado_dte_emitido_Recibido.Click += new System.EventHandler(this.listado_dte_emitido_Recibido_Click);
            // 
            // facturacion_exportacion
            // 
            this.facturacion_exportacion.Location = new System.Drawing.Point(14, 71);
            this.facturacion_exportacion.Name = "facturacion_exportacion";
            this.facturacion_exportacion.Size = new System.Drawing.Size(164, 38);
            this.facturacion_exportacion.TabIndex = 7;
            this.facturacion_exportacion.Text = "Facturación Exportación";
            this.facturacion_exportacion.UseVisualStyleBackColor = true;
            this.facturacion_exportacion.Click += new System.EventHandler(this.facturacion_exportacion_Click);
            // 
            // obtenerdte
            // 
            this.obtenerdte.Controls.Add(this.obtener_sobre_xml);
            this.obtenerdte.Controls.Add(this.obtener_dte);
            this.obtenerdte.Controls.Add(this.obtener_xml);
            this.obtenerdte.Controls.Add(this.obtener_timbre);
            this.obtenerdte.Controls.Add(this.obtener_pdf);
            this.obtenerdte.Location = new System.Drawing.Point(18, 15);
            this.obtenerdte.Name = "obtenerdte";
            this.obtenerdte.Size = new System.Drawing.Size(191, 254);
            this.obtenerdte.TabIndex = 0;
            this.obtenerdte.TabStop = false;
            this.obtenerdte.Text = "Obtener DTE";
            // 
            // obtener_sobre_xml
            // 
            this.obtener_sobre_xml.Location = new System.Drawing.Point(14, 203);
            this.obtener_sobre_xml.Name = "obtener_sobre_xml";
            this.obtener_sobre_xml.Size = new System.Drawing.Size(164, 38);
            this.obtener_sobre_xml.TabIndex = 4;
            this.obtener_sobre_xml.Text = "Obtener SobreXML";
            this.obtener_sobre_xml.UseVisualStyleBackColor = true;
            this.obtener_sobre_xml.Click += new System.EventHandler(this.obtener_sobre_xml_Click);
            // 
            // obtener_dte
            // 
            this.obtener_dte.Location = new System.Drawing.Point(14, 159);
            this.obtener_dte.Name = "obtener_dte";
            this.obtener_dte.Size = new System.Drawing.Size(164, 38);
            this.obtener_dte.TabIndex = 3;
            this.obtener_dte.Text = "Obtener DTE";
            this.obtener_dte.UseVisualStyleBackColor = true;
            this.obtener_dte.Click += new System.EventHandler(this.obtener_dte_Click);
            // 
            // obtener_xml
            // 
            this.obtener_xml.Location = new System.Drawing.Point(14, 115);
            this.obtener_xml.Name = "obtener_xml";
            this.obtener_xml.Size = new System.Drawing.Size(164, 38);
            this.obtener_xml.TabIndex = 2;
            this.obtener_xml.Text = "Obtener XML";
            this.obtener_xml.UseVisualStyleBackColor = true;
            this.obtener_xml.Click += new System.EventHandler(this.obtener_xml_Click);
            // 
            // obtener_timbre
            // 
            this.obtener_timbre.Location = new System.Drawing.Point(14, 71);
            this.obtener_timbre.Name = "obtener_timbre";
            this.obtener_timbre.Size = new System.Drawing.Size(164, 38);
            this.obtener_timbre.TabIndex = 1;
            this.obtener_timbre.Text = "Obtener Timbre";
            this.obtener_timbre.UseVisualStyleBackColor = true;
            this.obtener_timbre.Click += new System.EventHandler(this.ObtenerTimbre_Click);
            // 
            // obtener_pdf
            // 
            this.obtener_pdf.Location = new System.Drawing.Point(14, 27);
            this.obtener_pdf.Name = "obtener_pdf";
            this.obtener_pdf.Size = new System.Drawing.Size(164, 38);
            this.obtener_pdf.TabIndex = 0;
            this.obtener_pdf.Text = "Obtener PDF";
            this.obtener_pdf.UseVisualStyleBackColor = true;
            this.obtener_pdf.Click += new System.EventHandler(this.obtener_pdf_Click);
            // 
            // item_otros
            // 
            this.item_otros.Controls.Add(this.groupBox4);
            this.item_otros.Controls.Add(this.groupBox5);
            this.item_otros.Controls.Add(this.groupBox6);
            this.item_otros.Location = new System.Drawing.Point(4, 22);
            this.item_otros.Name = "item_otros";
            this.item_otros.Size = new System.Drawing.Size(615, 289);
            this.item_otros.TabIndex = 4;
            this.item_otros.Text = "Otros";
            this.item_otros.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Configuracion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Configuracion
            // 
            this.Configuracion.Image = global::SimpleFacturaSDK_Demo.Properties.Resources.ConfiguracionEdit16;
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Size = new System.Drawing.Size(115, 24);
            this.Configuracion.Text = "Configuración";
            this.Configuracion.Click += new System.EventHandler(this.Configuracion_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Location = new System.Drawing.Point(409, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 254);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otros";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Conciliar Emitido / Recibido";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(15, 161);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(164, 38);
            this.button16.TabIndex = 11;
            this.button16.Text = "Aceptar o Recharzar DTE";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(15, 19);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(164, 38);
            this.button17.TabIndex = 11;
            this.button17.Text = "Envio Mail";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(15, 63);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(164, 38);
            this.button18.TabIndex = 12;
            this.button18.Text = "Consolidado de ventas";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button19);
            this.groupBox5.Controls.Add(this.button20);
            this.groupBox5.Controls.Add(this.button21);
            this.groupBox5.Controls.Add(this.button22);
            this.groupBox5.Controls.Add(this.button23);
            this.groupBox5.Location = new System.Drawing.Point(212, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(191, 254);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Emision DTE";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(14, 159);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(164, 38);
            this.button19.TabIndex = 9;
            this.button19.Text = "Emisión NC/ND";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(14, 115);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(164, 38);
            this.button20.TabIndex = 8;
            this.button20.Text = "Facturación Masiva";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(14, 19);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(164, 38);
            this.button21.TabIndex = 5;
            this.button21.Text = "Facturación DTE / Boletas";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(14, 203);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(164, 38);
            this.button22.TabIndex = 10;
            this.button22.Text = "Listado DTE Emitido / Recibido";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(14, 63);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(164, 38);
            this.button23.TabIndex = 7;
            this.button23.Text = "Facturación Exportación";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listar_productos);
            this.groupBox6.Controls.Add(this.agregar_productos);
            this.groupBox6.Location = new System.Drawing.Point(15, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(191, 111);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Productos";
            // 
            // listar_productos
            // 
            this.listar_productos.Location = new System.Drawing.Point(14, 63);
            this.listar_productos.Name = "listar_productos";
            this.listar_productos.Size = new System.Drawing.Size(164, 38);
            this.listar_productos.TabIndex = 1;
            this.listar_productos.Text = "Listar Productos";
            this.listar_productos.UseVisualStyleBackColor = true;
            // 
            // agregar_productos
            // 
            this.agregar_productos.Location = new System.Drawing.Point(14, 19);
            this.agregar_productos.Name = "agregar_productos";
            this.agregar_productos.Size = new System.Drawing.Size(164, 38);
            this.agregar_productos.TabIndex = 0;
            this.agregar_productos.Text = "Agregar Productos";
            this.agregar_productos.UseVisualStyleBackColor = true;
            this.agregar_productos.Click += new System.EventHandler(this.agregar_productos_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(644, 375);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleFactura-Demo";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl2.ResumeLayout(false);
            this.item_facturacion.ResumeLayout(false);
            this.otros.ResumeLayout(false);
            this.emision_dte.ResumeLayout(false);
            this.obtenerdte.ResumeLayout(false);
            this.item_otros.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ObtenerPDF;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage item_facturacion;
        private System.Windows.Forms.TabPage item_otros;
        private System.Windows.Forms.GroupBox otros;
        private System.Windows.Forms.Button conciliar_emitidos_Recibidos;
        private System.Windows.Forms.Button envio_mail;
        private System.Windows.Forms.Button listado_dte_emitido_Recibido;
        private System.Windows.Forms.Button consolidado_ventas;
        private System.Windows.Forms.GroupBox emision_dte;
        private System.Windows.Forms.Button emision_nc_nd;
        private System.Windows.Forms.Button facturacion_masiva;
        private System.Windows.Forms.Button facturacion_dte;
        private System.Windows.Forms.Button facturacion_exportacion;
        private System.Windows.Forms.GroupBox obtenerdte;
        private System.Windows.Forms.Button obtener_sobre_xml;
        private System.Windows.Forms.Button obtener_dte;
        private System.Windows.Forms.Button obtener_xml;
        private System.Windows.Forms.Button obtener_timbre;
        private System.Windows.Forms.Button obtener_pdf;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Configuracion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button Acuse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button listar_productos;
        private System.Windows.Forms.Button agregar_productos;
    }
}

