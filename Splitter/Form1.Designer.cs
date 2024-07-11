namespace Splitter
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
            this.txtPdf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.txtArchivoNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.chCabecera = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo Pdf";
            // 
            // txtPdf
            // 
            this.txtPdf.Location = new System.Drawing.Point(170, 61);
            this.txtPdf.Name = "txtPdf";
            this.txtPdf.Size = new System.Drawing.Size(465, 20);
            this.txtPdf.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carpeta de Salida";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(170, 87);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(465, 20);
            this.txtSalida.TabIndex = 3;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(53, 198);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArchivoNombres
            // 
            this.txtArchivoNombres.Location = new System.Drawing.Point(170, 122);
            this.txtArchivoNombres.Name = "txtArchivoNombres";
            this.txtArchivoNombres.Size = new System.Drawing.Size(465, 20);
            this.txtArchivoNombres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Archivo de Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Columna de excel";
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(170, 153);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(100, 20);
            this.txtCol.TabIndex = 8;
            this.txtCol.Text = "A";
            // 
            // chCabecera
            // 
            this.chCabecera.AutoSize = true;
            this.chCabecera.Checked = true;
            this.chCabecera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chCabecera.Location = new System.Drawing.Point(297, 155);
            this.chCabecera.Name = "chCabecera";
            this.chCabecera.Size = new System.Drawing.Size(72, 17);
            this.chCabecera.TabIndex = 9;
            this.chCabecera.Text = "Cabecera";
            this.chCabecera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chCabecera);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArchivoNombres);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPdf);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPdf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox txtArchivoNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.CheckBox chCabecera;
    }
}

