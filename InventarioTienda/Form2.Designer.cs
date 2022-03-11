
namespace InventarioTienda
{
    partial class frmProductoIngresado
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.lblSecc = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "            INFORMACION DE REGISTRO DE LOS PRODUCTOS\r\n                           " +
    "  INGRESADOS AL INVENTARIO \r\n                            POR EL PERSONAL Y SECCI" +
    "ON";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(278, 70);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(147, 13);
            this.lblPersona.TabIndex = 2;
            this.lblPersona.Text = "PERSONAL RESPONSABLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SECCION DE LOS PRODUCTOS INGRESADOS:";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Location = new System.Drawing.Point(290, 98);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(0, 13);
            this.lblPersonal.TabIndex = 4;
            // 
            // lblSecc
            // 
            this.lblSecc.AutoSize = true;
            this.lblSecc.Location = new System.Drawing.Point(278, 177);
            this.lblSecc.Name = "lblSecc";
            this.lblSecc.Size = new System.Drawing.Size(0, 13);
            this.lblSecc.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(580, 228);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 46);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR DEL INVENTARIO";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProductoIngresado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 301);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSecc);
            this.Controls.Add(this.lblPersonal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.label1);
            this.Name = "frmProductoIngresado";
            this.Text = "ProductoIngresado";
            this.Load += new System.EventHandler(this.frmProductoIngresado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblPersonal;
        public System.Windows.Forms.Label lblSecc;
        private System.Windows.Forms.Button btnSalir;
    }
}