namespace Parte2
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
            this.btnAtCliente = new System.Windows.Forms.Button();
            this.btnVerR = new System.Windows.Forms.Button();
            this.btnPreparar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtCliente
            // 
            this.btnAtCliente.Location = new System.Drawing.Point(382, 48);
            this.btnAtCliente.Name = "btnAtCliente";
            this.btnAtCliente.Size = new System.Drawing.Size(72, 66);
            this.btnAtCliente.TabIndex = 0;
            this.btnAtCliente.Text = "Atención al Cliente";
            this.btnAtCliente.UseVisualStyleBackColor = true;
            this.btnAtCliente.Click += new System.EventHandler(this.btnAtCliente_Click);
            // 
            // btnVerR
            // 
            this.btnVerR.Location = new System.Drawing.Point(214, 41);
            this.btnVerR.Name = "btnVerR";
            this.btnVerR.Size = new System.Drawing.Size(75, 44);
            this.btnVerR.TabIndex = 1;
            this.btnVerR.Text = "Ver Resultados";
            this.btnVerR.UseVisualStyleBackColor = true;
            // 
            // btnPreparar
            // 
            this.btnPreparar.Location = new System.Drawing.Point(214, 127);
            this.btnPreparar.Name = "btnPreparar";
            this.btnPreparar.Size = new System.Drawing.Size(75, 51);
            this.btnPreparar.TabIndex = 2;
            this.btnPreparar.Text = "Preparar Distribucion";
            this.btnPreparar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerR);
            this.groupBox1.Controls.Add(this.btnPreparar);
            this.groupBox1.Location = new System.Drawing.Point(91, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Empresa de Distribucion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtCliente;
        private System.Windows.Forms.Button btnVerR;
        private System.Windows.Forms.Button btnPreparar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

