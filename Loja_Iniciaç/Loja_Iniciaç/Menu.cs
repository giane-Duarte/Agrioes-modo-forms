using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Iniciaç
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            frm_CadProdutos frm = new frm_CadProdutos();
            frm.Show();
            this.Visible = false;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frm_Consultar frm = new frm_Consultar();
            frm.Show();
            this.Visible = false;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {

        }
    }
}
