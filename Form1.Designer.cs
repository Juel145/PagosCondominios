
namespace PagosCondominios
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
            this.dataGridViewGeneral = new System.Windows.Forms.DataGridView();
            this.buttonOrdenarCuota = new System.Windows.Forms.Button();
            this.buttonMasPropiedade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNumeroPropiedades = new System.Windows.Forms.Label();
            this.dataGridViewCuotasAltaBajas = new System.Windows.Forms.DataGridView();
            this.buttonMasAltas = new System.Windows.Forms.Button();
            this.buttonMasBajas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNombreTotal = new System.Windows.Forms.Label();
            this.labelApellidoTotal = new System.Windows.Forms.Label();
            this.labelCuotaTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotasAltaBajas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGeneral
            // 
            this.dataGridViewGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeneral.Location = new System.Drawing.Point(12, 22);
            this.dataGridViewGeneral.Name = "dataGridViewGeneral";
            this.dataGridViewGeneral.Size = new System.Drawing.Size(458, 225);
            this.dataGridViewGeneral.TabIndex = 0;
            // 
            // buttonOrdenarCuota
            // 
            this.buttonOrdenarCuota.Location = new System.Drawing.Point(572, 36);
            this.buttonOrdenarCuota.Name = "buttonOrdenarCuota";
            this.buttonOrdenarCuota.Size = new System.Drawing.Size(123, 53);
            this.buttonOrdenarCuota.TabIndex = 1;
            this.buttonOrdenarCuota.Text = "Ordenar por Cuota de Matenimiento";
            this.buttonOrdenarCuota.UseVisualStyleBackColor = true;
            this.buttonOrdenarCuota.Click += new System.EventHandler(this.buttonOrdenarCuota_Click);
            // 
            // buttonMasPropiedade
            // 
            this.buttonMasPropiedade.Location = new System.Drawing.Point(39, 271);
            this.buttonMasPropiedade.Name = "buttonMasPropiedade";
            this.buttonMasPropiedade.Size = new System.Drawing.Size(144, 43);
            this.buttonMasPropiedade.TabIndex = 2;
            this.buttonMasPropiedade.Text = "Mostrar Propietario con Mas Propiedades";
            this.buttonMasPropiedade.UseVisualStyleBackColor = true;
            this.buttonMasPropiedade.Click += new System.EventHandler(this.buttonMasPropiedade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero de Propiedades";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(104, 329);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(35, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "label4";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(104, 355);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(35, 13);
            this.labelApellido.TabIndex = 7;
            this.labelApellido.Text = "label4";
            // 
            // labelNumeroPropiedades
            // 
            this.labelNumeroPropiedades.AutoSize = true;
            this.labelNumeroPropiedades.Location = new System.Drawing.Point(175, 389);
            this.labelNumeroPropiedades.Name = "labelNumeroPropiedades";
            this.labelNumeroPropiedades.Size = new System.Drawing.Size(35, 13);
            this.labelNumeroPropiedades.TabIndex = 8;
            this.labelNumeroPropiedades.Text = "label4";
            // 
            // dataGridViewCuotasAltaBajas
            // 
            this.dataGridViewCuotasAltaBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuotasAltaBajas.Location = new System.Drawing.Point(423, 305);
            this.dataGridViewCuotasAltaBajas.Name = "dataGridViewCuotasAltaBajas";
            this.dataGridViewCuotasAltaBajas.Size = new System.Drawing.Size(329, 122);
            this.dataGridViewCuotasAltaBajas.TabIndex = 9;
            // 
            // buttonMasAltas
            // 
            this.buttonMasAltas.Location = new System.Drawing.Point(439, 271);
            this.buttonMasAltas.Name = "buttonMasAltas";
            this.buttonMasAltas.Size = new System.Drawing.Size(114, 28);
            this.buttonMasAltas.TabIndex = 10;
            this.buttonMasAltas.Text = "Cuotas Mas Altas";
            this.buttonMasAltas.UseVisualStyleBackColor = true;
            this.buttonMasAltas.Click += new System.EventHandler(this.buttonMasAltas_Click);
            // 
            // buttonMasBajas
            // 
            this.buttonMasBajas.Location = new System.Drawing.Point(585, 271);
            this.buttonMasBajas.Name = "buttonMasBajas";
            this.buttonMasBajas.Size = new System.Drawing.Size(110, 28);
            this.buttonMasBajas.TabIndex = 11;
            this.buttonMasBajas.Text = "Cuotas Mas Bajas";
            this.buttonMasBajas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Propietario Con La Cuota Mas Alta En Total";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total a Pagar";
            // 
            // labelNombreTotal
            // 
            this.labelNombreTotal.AutoSize = true;
            this.labelNombreTotal.Location = new System.Drawing.Point(569, 159);
            this.labelNombreTotal.Name = "labelNombreTotal";
            this.labelNombreTotal.Size = new System.Drawing.Size(35, 13);
            this.labelNombreTotal.TabIndex = 16;
            this.labelNombreTotal.Text = "label7";
            // 
            // labelApellidoTotal
            // 
            this.labelApellidoTotal.AutoSize = true;
            this.labelApellidoTotal.Location = new System.Drawing.Point(569, 189);
            this.labelApellidoTotal.Name = "labelApellidoTotal";
            this.labelApellidoTotal.Size = new System.Drawing.Size(35, 13);
            this.labelApellidoTotal.TabIndex = 17;
            this.labelApellidoTotal.Text = "label8";
            // 
            // labelCuotaTotal
            // 
            this.labelCuotaTotal.AutoSize = true;
            this.labelCuotaTotal.Location = new System.Drawing.Point(586, 219);
            this.labelCuotaTotal.Name = "labelCuotaTotal";
            this.labelCuotaTotal.Size = new System.Drawing.Size(35, 13);
            this.labelCuotaTotal.TabIndex = 18;
            this.labelCuotaTotal.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCuotaTotal);
            this.Controls.Add(this.labelApellidoTotal);
            this.Controls.Add(this.labelNombreTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMasBajas);
            this.Controls.Add(this.buttonMasAltas);
            this.Controls.Add(this.dataGridViewCuotasAltaBajas);
            this.Controls.Add(this.labelNumeroPropiedades);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMasPropiedade);
            this.Controls.Add(this.buttonOrdenarCuota);
            this.Controls.Add(this.dataGridViewGeneral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotasAltaBajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGeneral;
        private System.Windows.Forms.Button buttonOrdenarCuota;
        private System.Windows.Forms.Button buttonMasPropiedade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNumeroPropiedades;
        private System.Windows.Forms.DataGridView dataGridViewCuotasAltaBajas;
        private System.Windows.Forms.Button buttonMasAltas;
        private System.Windows.Forms.Button buttonMasBajas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNombreTotal;
        private System.Windows.Forms.Label labelApellidoTotal;
        private System.Windows.Forms.Label labelCuotaTotal;
    }
}

