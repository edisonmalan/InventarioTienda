
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.mtxtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.rtbnAbastos = new System.Windows.Forms.RadioButton();
            this.rtbntBebidas = new System.Windows.Forms.RadioButton();
            this.rtbnEmbutidos = new System.Windows.Forms.RadioButton();
            this.rtbnFrutas = new System.Windows.Forms.RadioButton();
            this.rtbnAseo = new System.Windows.Forms.RadioButton();
            this.rtbnLacteos = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.chBodeguero = new System.Windows.Forms.CheckBox();
            this.chDespachador = new System.Windows.Forms.CheckBox();
            this.dtgvIngreso = new System.Windows.Forms.DataGridView();
            this.btnPS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTARIO \"TIENDA LAS MERCEDES\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESO DE PRODUCTOS AL INVENTARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre del producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(166, 88);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(100, 20);
            this.txtNombreP.TabIndex = 10;
            // 
            // mtxtCantidad
            // 
            this.mtxtCantidad.Location = new System.Drawing.Point(166, 127);
            this.mtxtCantidad.Mask = "99999";
            this.mtxtCantidad.Name = "mtxtCantidad";
            this.mtxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.mtxtCantidad.TabIndex = 12;
            this.mtxtCantidad.ValidatingType = typeof(int);
            // 
            // rtbnAbastos
            // 
            this.rtbnAbastos.AutoSize = true;
            this.rtbnAbastos.Location = new System.Drawing.Point(134, 185);
            this.rtbnAbastos.Name = "rtbnAbastos";
            this.rtbnAbastos.Size = new System.Drawing.Size(63, 17);
            this.rtbnAbastos.TabIndex = 15;
            this.rtbnAbastos.TabStop = true;
            this.rtbnAbastos.Text = "Abastos";
            this.rtbnAbastos.UseVisualStyleBackColor = true;
            // 
            // rtbntBebidas
            // 
            this.rtbntBebidas.AutoSize = true;
            this.rtbntBebidas.Location = new System.Drawing.Point(215, 185);
            this.rtbntBebidas.Name = "rtbntBebidas";
            this.rtbntBebidas.Size = new System.Drawing.Size(63, 17);
            this.rtbntBebidas.TabIndex = 16;
            this.rtbntBebidas.TabStop = true;
            this.rtbntBebidas.Text = "Bebidas";
            this.rtbntBebidas.UseVisualStyleBackColor = true;
            // 
            // rtbnEmbutidos
            // 
            this.rtbnEmbutidos.AutoSize = true;
            this.rtbnEmbutidos.Location = new System.Drawing.Point(316, 185);
            this.rtbnEmbutidos.Name = "rtbnEmbutidos";
            this.rtbnEmbutidos.Size = new System.Drawing.Size(74, 17);
            this.rtbnEmbutidos.TabIndex = 17;
            this.rtbnEmbutidos.TabStop = true;
            this.rtbnEmbutidos.Text = "Embutidos";
            this.rtbnEmbutidos.UseVisualStyleBackColor = true;
            // 
            // rtbnFrutas
            // 
            this.rtbnFrutas.AutoSize = true;
            this.rtbnFrutas.Location = new System.Drawing.Point(407, 185);
            this.rtbnFrutas.Name = "rtbnFrutas";
            this.rtbnFrutas.Size = new System.Drawing.Size(54, 17);
            this.rtbnFrutas.TabIndex = 18;
            this.rtbnFrutas.TabStop = true;
            this.rtbnFrutas.Text = "Frutas";
            this.rtbnFrutas.UseVisualStyleBackColor = true;
            // 
            // rtbnAseo
            // 
            this.rtbnAseo.AutoSize = true;
            this.rtbnAseo.Location = new System.Drawing.Point(498, 185);
            this.rtbnAseo.Name = "rtbnAseo";
            this.rtbnAseo.Size = new System.Drawing.Size(49, 17);
            this.rtbnAseo.TabIndex = 19;
            this.rtbnAseo.TabStop = true;
            this.rtbnAseo.Text = "Aseo";
            this.rtbnAseo.UseVisualStyleBackColor = true;
            // 
            // rtbnLacteos
            // 
            this.rtbnLacteos.AutoSize = true;
            this.rtbnLacteos.Location = new System.Drawing.Point(589, 185);
            this.rtbnLacteos.Name = "rtbnLacteos";
            this.rtbnLacteos.Size = new System.Drawing.Size(63, 17);
            this.rtbnLacteos.TabIndex = 24;
            this.rtbnLacteos.TabStop = true;
            this.rtbnLacteos.Text = "Lacteos";
            this.rtbnLacteos.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(372, 100);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(466, 100);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 30;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Personal encargado";
            // 
            // chBodeguero
            // 
            this.chBodeguero.AutoSize = true;
            this.chBodeguero.Location = new System.Drawing.Point(166, 161);
            this.chBodeguero.Name = "chBodeguero";
            this.chBodeguero.Size = new System.Drawing.Size(78, 17);
            this.chBodeguero.TabIndex = 32;
            this.chBodeguero.Text = "Bodeguero";
            this.chBodeguero.UseVisualStyleBackColor = true;
            // 
            // chDespachador
            // 
            this.chDespachador.AutoSize = true;
            this.chDespachador.Location = new System.Drawing.Point(272, 161);
            this.chDespachador.Name = "chDespachador";
            this.chDespachador.Size = new System.Drawing.Size(90, 17);
            this.chDespachador.TabIndex = 33;
            this.chDespachador.Text = "Despachador";
            this.chDespachador.UseVisualStyleBackColor = true;
            // 
            // dtgvIngreso
            // 
            this.dtgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIngreso.Location = new System.Drawing.Point(157, 208);
            this.dtgvIngreso.Name = "dtgvIngreso";
            this.dtgvIngreso.Size = new System.Drawing.Size(233, 116);
            this.dtgvIngreso.TabIndex = 35;
            // 
            // btnPS
            // 
            this.btnPS.Location = new System.Drawing.Point(567, 100);
            this.btnPS.Name = "btnPS";
            this.btnPS.Size = new System.Drawing.Size(75, 40);
            this.btnPS.TabIndex = 36;
            this.btnPS.Text = "PERSONAL Y SECCION";
            this.btnPS.UseVisualStyleBackColor = true;
            this.btnPS.Click += new System.EventHandler(this.btnPS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 345);
            this.Controls.Add(this.btnPS);
            this.Controls.Add(this.dtgvIngreso);
            this.Controls.Add(this.chDespachador);
            this.Controls.Add(this.chBodeguero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rtbnLacteos);
            this.Controls.Add(this.rtbnAseo);
            this.Controls.Add(this.rtbnFrutas);
            this.Controls.Add(this.rtbnEmbutidos);
            this.Controls.Add(this.rtbntBebidas);
            this.Controls.Add(this.rtbnAbastos);
            this.Controls.Add(this.mtxtCantidad);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIngreso)).EndInit();
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
        private System.Windows.Forms.RadioButton rtbnAbastos;
        private System.Windows.Forms.RadioButton rtbntBebidas;
        private System.Windows.Forms.RadioButton rtbnEmbutidos;
        private System.Windows.Forms.RadioButton rtbnFrutas;
        private System.Windows.Forms.RadioButton rtbnAseo;
        private System.Windows.Forms.RadioButton rtbnLacteos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chBodeguero;
        private System.Windows.Forms.CheckBox chDespachador;
        private System.Windows.Forms.DataGridView dtgvIngreso;
        private System.Windows.Forms.Button btnPS;
    }
}

