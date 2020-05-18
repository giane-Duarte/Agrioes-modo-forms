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
    public partial class Form1 : Form
    {   //Declaração de vetores

        String[] vtcodProduto = new string[11];
        string[] vtnomeProduto = new string[11];
        double[] vtvalorProduto = new double[11];
        int[] vtEstoque = new int[11];

        //Declaração de Variaveis
        double vsomatotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProducts();
            vsomatotal = 0;

            int ind = 1; 
            while (ind <=10)
            {
                
                LISTAPROD.Items.Add(vtcodProduto[ind] + vtnomeProduto[ind]);
                ind = ind + 1;
            }
                                   
                
        }

        private void loadProducts()
        {
            vtcodProduto[1] = "AG01";
            vtcodProduto[2] = "AG02";
            vtcodProduto[3] = "AG03";
            vtcodProduto[4] = "AG04";
            vtcodProduto[5] = "AG05";
            vtcodProduto[6] = "AG06";
            vtcodProduto[7] = "AG07";
            vtcodProduto[8] = "AG08";
            vtcodProduto[9] = "AG09";
            vtcodProduto[10] = "AG10";


            vtnomeProduto[1] = "Saia de Rótulo";
            vtnomeProduto[2] = "Saia Alumiô";
            vtnomeProduto[3] = "Calça Laço";
            vtnomeProduto[4] = "Vestido";
            vtnomeProduto[5] = "Bermuda";
            vtnomeProduto[6] = "Calça Social";
            vtnomeProduto[7] = "Camisa Social";
            vtnomeProduto[8] = "Camiseta";
            vtnomeProduto[9] = "Camisa Polo";
            vtnomeProduto[10] = "Blusa";

            vtvalorProduto[1] = 100;
            vtvalorProduto[2] = 80;
            vtvalorProduto[3] = 120;
            vtvalorProduto[4] = 90;
            vtvalorProduto[5] = 70;
            vtvalorProduto[6] = 100;
            vtvalorProduto[7] = 85;
            vtvalorProduto[8] = 40;
            vtvalorProduto[9] = 75;
            vtvalorProduto[10] = 120;

            vtEstoque[1] = 20;
            vtEstoque[2] = 20;
            vtEstoque[3] = 20;
            vtEstoque[4] = 20;
            vtEstoque[5] = 20;
            vtEstoque[6] = 20;
            vtEstoque[7] = 20;
            vtEstoque[8] = 20;
            vtEstoque[9] = 20;
            vtEstoque[10] = 20;
        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {
            if (txt_Codigo.Text.Length == 4)

            {
                int ind = 0;
                for (int cp = 1; cp < 11; cp++)
                {
                    if (txt_Codigo.Text == vtcodProduto[cp])
                    {
                        ind = cp;
                    }

                }

                if (ind > 0)
                {
                    lstCaixa.Items.Add(String.Format(" {0} - {1} - {2:C}", vtcodProduto[ind], vtnomeProduto[ind], vtvalorProduto[ind]));
                    picImagem.ImageLocation = "C:\\Users\\Samsung\\Documents\\Curso EducafroTech\\LOJA AGRIÕES\\Loja por Tutorial Youtube\\produtos" + vtcodProduto[ind] + ".jpeg";

                    vsomatotal += vtvalorProduto[ind];
                    txtTotal.Text = Convert.ToString(vsomatotal);

                }

                else
                {
                    MessageBox.Show("Produto Não Encontrado");

                }

                txtEstoque.Text = Convert.ToString (vtEstoque[ind]);
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstCaixa.ClearSelected();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Visible = false;
        }

        private void picImagem_Click(object sender, EventArgs e)
        {

        }

        private void LISTAPROD_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (object produto in LISTAPROD.SelectedItems)
            {
                txt_Codigo.Text = produto.ToString();
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }
    }
    }

