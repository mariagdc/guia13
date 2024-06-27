using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtCliente_Click(object sender, EventArgs e)
        {
            FormDespacho modalDespacho = new FormDespacho();
            while (modalDespacho.ShowDialog() == DialogResult.OK)
            {
                int CP = Convert.ToInt32(modalDespacho.tbCP.Text);
                int Peso = Convert.ToInt32(modalDespacho.tbPesogr.Text);
                int Empresa = Convert.ToInt32(modalDespacho.tbNempresa.Text);

                bool Cert = modalDespacho.cbCertificada.Checked;                


            }


        }
    }
}
