namespace Parte2
{
    partial class FormDespacho
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
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbPesogr = new System.Windows.Forms.TextBox();
            this.tbNempresa = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lbCP = new System.Windows.Forms.Label();
            this.lbPesogr = new System.Windows.Forms.Label();
            this.lbnEmpresa = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbCertificada = new System.Windows.Forms.CheckBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(134, 28);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(100, 20);
            this.tbCP.TabIndex = 0;
            // 
            // tbPesogr
            // 
            this.tbPesogr.Location = new System.Drawing.Point(134, 69);
            this.tbPesogr.Name = "tbPesogr";
            this.tbPesogr.Size = new System.Drawing.Size(100, 20);
            this.tbPesogr.TabIndex = 1;
            // 
            // tbNempresa
            // 
            this.tbNempresa.Location = new System.Drawing.Point(134, 113);
            this.tbNempresa.Name = "tbNempresa";
            this.tbNempresa.Size = new System.Drawing.Size(100, 20);
            this.tbNempresa.TabIndex = 2;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cbCertificada);
            this.gbDatos.Controls.Add(this.lbnEmpresa);
            this.gbDatos.Controls.Add(this.lbPesogr);
            this.gbDatos.Controls.Add(this.lbCP);
            this.gbDatos.Controls.Add(this.tbCP);
            this.gbDatos.Controls.Add(this.tbNempresa);
            this.gbDatos.Controls.Add(this.tbPesogr);
            this.gbDatos.Location = new System.Drawing.Point(73, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(309, 173);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lbCP
            // 
            this.lbCP.AutoSize = true;
            this.lbCP.Location = new System.Drawing.Point(41, 28);
            this.lbCP.Name = "lbCP";
            this.lbCP.Size = new System.Drawing.Size(72, 13);
            this.lbCP.TabIndex = 4;
            this.lbCP.Text = "Código Postal";
            // 
            // lbPesogr
            // 
            this.lbPesogr.AutoSize = true;
            this.lbPesogr.Location = new System.Drawing.Point(41, 72);
            this.lbPesogr.Name = "lbPesogr";
            this.lbPesogr.Size = new System.Drawing.Size(83, 13);
            this.lbPesogr.TabIndex = 5;
            this.lbPesogr.Text = "Peso en gramos";
            // 
            // lbnEmpresa
            // 
            this.lbnEmpresa.AutoSize = true;
            this.lbnEmpresa.Location = new System.Drawing.Point(40, 116);
            this.lbnEmpresa.Name = "lbnEmpresa";
            this.lbnEmpresa.Size = new System.Drawing.Size(88, 13);
            this.lbnEmpresa.TabIndex = 6;
            this.lbnEmpresa.Text = "Numero Empresa";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(117, 191);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbCertificada
            // 
            this.cbCertificada.AutoSize = true;
            this.cbCertificada.Location = new System.Drawing.Point(159, 139);
            this.cbCertificada.Name = "cbCertificada";
            this.cbCertificada.Size = new System.Drawing.Size(102, 17);
            this.cbCertificada.TabIndex = 7;
            this.cbCertificada.Text = "¿Es certificada?";
            this.cbCertificada.UseVisualStyleBackColor = true;
            // 
            // FormDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 235);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbDatos);
            this.Name = "FormDespacho";
            this.Text = "FormDespacho";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lbnEmpresa;
        private System.Windows.Forms.Label lbPesogr;
        private System.Windows.Forms.Label lbCP;
        public System.Windows.Forms.TextBox tbCP;
        public System.Windows.Forms.TextBox tbPesogr;
        public System.Windows.Forms.TextBox tbNempresa;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.CheckBox cbCertificada;
    }
}