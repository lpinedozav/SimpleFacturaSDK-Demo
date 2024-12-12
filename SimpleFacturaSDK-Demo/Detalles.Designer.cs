namespace SimpleFacturaSDK_Demo
{
    partial class Detalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalles));
            this.dataGridViewDetalles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDetalles
            // 
            this.dataGridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalles.Location = new System.Drawing.Point(10, 6);
            this.dataGridViewDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDetalles.Name = "dataGridViewDetalles";
            this.dataGridViewDetalles.RowHeadersWidth = 51;
            this.dataGridViewDetalles.RowTemplate.Height = 24;
            this.dataGridViewDetalles.Size = new System.Drawing.Size(525, 264);
            this.dataGridViewDetalles.TabIndex = 0;
            // 
            // Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 283);
            this.Controls.Add(this.dataGridViewDetalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Detalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.Detalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDetalles;
    }
}