
namespace InventarioTienda
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.mtxtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.rtbnPrincipal = new System.Windows.Forms.RadioButton();
            this.rtbnSecundaria = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.chBodeguero = new System.Windows.Forms.CheckBox();
            this.chDespachador = new System.Windows.Forms.CheckBox();
            this.dtgvIngreso = new System.Windows.Forms.DataGridView();
            this.btnPs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIngreso)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTARIO \"TIENDA LAS MERCEDES\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESO DE PRODUCTOS AL INVENTARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.label4.Location = new System.Drawing.Point(35, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre del producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.label6.Location = new System.Drawing.Point(35, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // txtNombreP
            // 
            this.txtNombreP.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombreP.Location = new System.Drawing.Point(193, 88);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(100, 20);
            this.txtNombreP.TabIndex = 10;
            // 
            // mtxtCantidad
            // 
            this.mtxtCantidad.BackColor = System.Drawing.Color.Gainsboro;
            this.mtxtCantidad.Location = new System.Drawing.Point(193, 125);
            this.mtxtCantidad.Mask = "99999";
            this.mtxtCantidad.Name = "mtxtCantidad";
            this.mtxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.mtxtCantidad.TabIndex = 12;
            this.mtxtCantidad.ValidatingType = typeof(int);
            // 
            // rtbnPrincipal
            // 
            this.rtbnPrincipal.AutoSize = true;
            this.rtbnPrincipal.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.rtbnPrincipal.Location = new System.Drawing.Point(193, 196);
            this.rtbnPrincipal.Name = "rtbnPrincipal";
            this.rtbnPrincipal.Size = new System.Drawing.Size(71, 19);
            this.rtbnPrincipal.TabIndex = 15;
            this.rtbnPrincipal.TabStop = true;
            this.rtbnPrincipal.Text = "Principal";
            this.rtbnPrincipal.UseVisualStyleBackColor = true;
            // 
            // rtbnSecundaria
            // 
            this.rtbnSecundaria.AutoSize = true;
            this.rtbnSecundaria.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.rtbnSecundaria.Location = new System.Drawing.Point(307, 196);
            this.rtbnSecundaria.Name = "rtbnSecundaria";
            this.rtbnSecundaria.Size = new System.Drawing.Size(84, 19);
            this.rtbnSecundaria.TabIndex = 16;
            this.rtbnSecundaria.TabStop = true;
            this.rtbnSecundaria.Text = "Secundaria";
            this.rtbnSecundaria.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(36, 67);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 23);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(36, 107);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(87, 23);
            this.btnMostrar.TabIndex = 30;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.label11.Location = new System.Drawing.Point(35, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "Personal encargado";
            // 
            // chBodeguero
            // 
            this.chBodeguero.AutoSize = true;
            this.chBodeguero.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBodeguero.Location = new System.Drawing.Point(193, 163);
            this.chBodeguero.Name = "chBodeguero";
            this.chBodeguero.Size = new System.Drawing.Size(84, 19);
            this.chBodeguero.TabIndex = 32;
            this.chBodeguero.Text = "Bodeguero";
            this.chBodeguero.UseVisualStyleBackColor = true;
            // 
            // chDespachador
            // 
            this.chDespachador.AutoSize = true;
            this.chDespachador.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.chDespachador.Location = new System.Drawing.Point(307, 163);
            this.chDespachador.Name = "chDespachador";
            this.chDespachador.Size = new System.Drawing.Size(97, 19);
            this.chDespachador.TabIndex = 33;
            this.chDespachador.Text = "Despachador";
            this.chDespachador.UseVisualStyleBackColor = true;
            // 
            // dtgvIngreso
            // 
            this.dtgvIngreso.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvIngreso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvIngreso.EnableHeadersVisualStyles = false;
            this.dtgvIngreso.Location = new System.Drawing.Point(193, 236);
            this.dtgvIngreso.Name = "dtgvIngreso";
            this.dtgvIngreso.Size = new System.Drawing.Size(222, 116);
            this.dtgvIngreso.TabIndex = 35;
            // 
            // btnPs
            // 
            this.btnPs.Location = new System.Drawing.Point(36, 148);
            this.btnPs.Name = "btnPs";
            this.btnPs.Size = new System.Drawing.Size(87, 23);
            this.btnPs.TabIndex = 36;
            this.btnPs.Text = "CONTINUAR";
            this.btnPs.UseVisualStyleBackColor = true;
            this.btnPs.Click += new System.EventHandler(this.btnPS_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 32);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnPs);
            this.panel2.Controls.Add(this.btnMostrar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(604, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 364);
            this.panel2.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 48);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Opciones";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F);
            this.lblCedula.Location = new System.Drawing.Point(444, 167);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(15, 15);
            this.lblCedula.TabIndex = 42;
            this.lblCedula.Text = "-";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(444, 109);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(15, 15);
            this.lblUsuario.TabIndex = 41;
            this.lblUsuario.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(444, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "CI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "USUARIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 396);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvIngreso);
            this.Controls.Add(this.chDespachador);
            this.Controls.Add(this.chBodeguero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rtbnSecundaria);
            this.Controls.Add(this.rtbnPrincipal);
            this.Controls.Add(this.mtxtCantidad);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIngreso)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.MaskedTextBox mtxtCantidad;
        private System.Windows.Forms.RadioButton rtbnPrincipal;
        private System.Windows.Forms.RadioButton rtbnSecundaria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chBodeguero;
        private System.Windows.Forms.CheckBox chDespachador;
        private System.Windows.Forms.DataGridView dtgvIngreso;
        private System.Windows.Forms.Button btnPs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblCedula;
    }
}

