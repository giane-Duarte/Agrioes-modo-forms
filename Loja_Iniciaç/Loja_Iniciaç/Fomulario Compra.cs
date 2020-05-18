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
    public partial class frm_Comprar : Form
    {
        // Declaração de 4 arrays(vetores) p/ armazenar 11 preodutos e seus respectivos codigos e valores.

        string[] vtCodProd = new string[11];
        string[] vtNomeProduto = new string[11];
        double[] vtValor = new double[11];
        int[] vtEstoque = new int[11];

        //Variavel 
        double vsoma;



        public frm_Comprar()
        {
            InitializeComponent();
        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {

            /*inicia com uma condição, se o usuário digitar um código com 4 caracteres(length), esse código é adicionado ao listBox
             *  A propriedade length retorna a quantidade de caracteres.            
             *  Após o conteúdo ser enviado para o ListBox, o textbox será limpo e o Focus posiciona o cursor para o 
             *  TextBox para uma nova digitação  */
             
            if (txt_Codigo.Text.Length == 4)
            {
                int indice = 0;
                
                /*Faça enquanto  o produto for menor ou igual  a quantidade dos itens array*/
                for (int prod = 1; prod <=vtCodProd.Length; prod++)
                {
                    if (txt_Codigo.Text == vtCodProd[prod])
                    {
                        indice = prod;

                    }
                    if(indice==0)
                    {
                        MessageBox.Show("Produto Não Encontrado");
                        /*COnsição: se foi encontrado um produto ele retorna as informações de acordo com o indice
                         * caso não encontre, exibe a mensagem de erro*/
                    }
                    else
                    {
                        lstCaixa.Items.Add(txt_Codigo.Text + "--" + vtNomeProduto[indice] + "--R$" + vtValor[indice]);
                        /*Conteudo adicionado ao listbox, concatena + as informações (codigo/nome/valor)*/

                        vsoma = vsoma + vtValor[indice];
                        label3.Text = ("Valor Total R$ " + vsoma);
                        picImagem.ImageLocation = "C:/Users/HP/OneDrive/root agrioes/C# Modo Forms/LOJA AGRIÕES - Versão 3/produtos" + vtCodProd[indice] + ".jpeg";
                        txt_Codigo.Text = "";
                        txt_Codigo.Focus();
                        /*Localização da imagem quye deve ser colocada em uma pasta imagens em c:
                         * o textbox será limpo e o focus posiciona o cursor para o textbox para uma
                         * digitação*/


                        
                    }

                }



            }

        }

        private void frm_Comprar_Load(object sender, EventArgs e)
        {
            // Ao entrar no form será chamado o método

            carregarArray();
            vsoma = 0;
        }
        /*Criação do Método para ser chamado quando necessário, isso evita repetir
várias vezes o mesmo código*/

        private void carregarArray()


        {

            /*Códigos, Produtos e Valores ref. os arrays que foram declarados*/

            vtCodProd[1] = "AG01";
            vtCodProd[2] = "AG02";
            vtCodProd[3] = "AG03";
            vtCodProd[4] = "AG04";
            vtCodProd[5] = "AG05";
            vtCodProd[6] = "AG06";
            vtCodProd[7] = "AG07";
            vtCodProd[8] = "AG08";
            vtCodProd[9] = "AG09";
            vtCodProd[10] = "AG10";


            vtNomeProduto[1] = "Saia de Rótulo";
            vtNomeProduto[2] = "Saia Alumiô";
            vtNomeProduto[3] = "Calça Laço";
            vtNomeProduto[4] = "Vestido";
            vtNomeProduto[5] = "Bermuda";
            vtNomeProduto[6] = "Calça Social";
            vtNomeProduto[7] = "Camisa Social";
            vtNomeProduto[8] = "Camiseta";
            vtNomeProduto[9] = "Camisa Polo";
            vtNomeProduto[10] = "Blusa";

            vtValor[1] = 100;
            vtValor[2] = 80;
            vtValor[3] = 120;
            vtValor[4] = 90;
            vtValor[5] = 70;
            vtValor[6] = 100;
            vtValor[7] = 85;
            vtValor[8] = 40;
            vtValor[9] = 75;
            vtValor[10] = 120;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Visible = false;
        }
    }   
}
