using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Loja_Iniciaç
{
    public partial class Tela_Login : Form
    {
        Thread nt;
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "agrioes" && txtSenha.Text == "educafro")
            {
                this.Close();
                nt = new Thread(formmenu);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }

            else 
            {
                MessageBox.Show("Login ou Senha inválidos!");
            }
        }

        private void formmenu()
        {
            Application.Run(new Menu());

        }
    }

}




