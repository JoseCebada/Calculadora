namespace WindowsFormsApp1
{
    partial class Conversor
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
            this.lbC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.Location = new System.Drawing.Point(44, 64);
            this.lbC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(210, 27);
            this.lbC.TabIndex = 0;
            this.lbC.Text = "Grados Centígrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados Fahrenheit";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(305, 64);
            this.txtC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(225, 22);
            this.txtC.TabIndex = 2;
            this.txtC.TextChanged += new System.EventHandler(this.TxtC_TextChanged);
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtC_KeyPress_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(305, 154);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress_1);
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.Black;
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConvertir.Location = new System.Drawing.Point(405, 201);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(127, 38);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 254);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbC);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Conversor";
            this.Text = "Conversor de Temperaturas";
            this.Load += new System.EventHandler(this.Conversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnConvertir;
    }
}

