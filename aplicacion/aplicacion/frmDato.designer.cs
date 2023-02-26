namespace aplicacion
{
    partial class frmDato
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
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_descrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_compra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_fecha = new System.Windows.Forms.DateTimePicker();
            this.text_venta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(65, 13);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(254, 20);
            this.text_nombre.TabIndex = 0;
            this.text_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_nombre_KeyPress);
            // 
            // text_descrip
            // 
            this.text_descrip.Location = new System.Drawing.Point(65, 73);
            this.text_descrip.Name = "text_descrip";
            this.text_descrip.Size = new System.Drawing.Size(254, 20);
            this.text_descrip.TabIndex = 3;
            this.text_descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_descrip_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrip:";
            // 
            // text_compra
            // 
            this.text_compra.Location = new System.Drawing.Point(78, 142);
            this.text_compra.Name = "text_compra";
            this.text_compra.Size = new System.Drawing.Size(241, 20);
            this.text_compra.TabIndex = 5;
            this.text_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_compra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "P. Compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha:";
            // 
            // text_fecha
            // 
            this.text_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_fecha.Location = new System.Drawing.Point(65, 213);
            this.text_fecha.Name = "text_fecha";
            this.text_fecha.Size = new System.Drawing.Size(97, 20);
            this.text_fecha.TabIndex = 7;
            this.text_fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_fecha_KeyPress);
            // 
            // text_venta
            // 
            this.text_venta.Location = new System.Drawing.Point(65, 280);
            this.text_venta.Name = "text_venta";
            this.text_venta.Size = new System.Drawing.Size(152, 20);
            this.text_venta.TabIndex = 9;
            this.text_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_venta_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "P. Venta:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(65, 339);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(224, 339);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmDato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 386);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.text_venta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_compra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_descrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDato_FormClosed);
            this.Load += new System.EventHandler(this.frmDato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox text_nombre;
        public System.Windows.Forms.TextBox text_descrip;
        public System.Windows.Forms.TextBox text_compra;
        public System.Windows.Forms.DateTimePicker text_fecha;
        public System.Windows.Forms.TextBox text_venta;
    }
}