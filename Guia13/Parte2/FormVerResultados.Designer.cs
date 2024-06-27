namespace Parte2
{
    partial class FormVerResultados
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
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.btnCerrarR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(94, 56);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(220, 160);
            this.lbResultados.TabIndex = 0;
            // 
            // btnCerrarR
            // 
            this.btnCerrarR.Location = new System.Drawing.Point(163, 252);
            this.btnCerrarR.Name = "btnCerrarR";
            this.btnCerrarR.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarR.TabIndex = 1;
            this.btnCerrarR.Text = "Cerrar";
            this.btnCerrarR.UseVisualStyleBackColor = true;
            // 
            // FormVerResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 313);
            this.Controls.Add(this.btnCerrarR);
            this.Controls.Add(this.lbResultados);
            this.Name = "FormVerResultados";
            this.Text = "FormVerResultados";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbResultados;
        public System.Windows.Forms.Button btnCerrarR;
    }
}