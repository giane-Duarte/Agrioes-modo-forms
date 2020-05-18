namespace Loja_Iniciaç
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCaixa = new System.Windows.Forms.ListBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LISTAPROD = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "DESCRITIVO DA COMPRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "IMAGEM DO PRODUTO";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(673, 335);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(115, 20);
            this.txtTotal.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "VALOR TOTAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "CARRINHO DE COMPRAS";
            // 
            // lstCaixa
            // 
            this.lstCaixa.FormattingEnabled = true;
            this.lstCaixa.Location = new System.Drawing.Point(503, 104);
            this.lstCaixa.Name = "lstCaixa";
            this.lstCaixa.Size = new System.Drawing.Size(285, 225);
            this.lstCaixa.TabIndex = 17;
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(278, 156);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(182, 173);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 16;
            this.picImagem.TabStop = false;
            this.picImagem.Click += new System.EventHandler(this.picImagem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "CÓDIGO DO PRODUTO";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(290, 105);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(149, 20);
            this.txt_Codigo.TabIndex = 14;
            this.txt_Codigo.TextChanged += new System.EventHandler(this.txt_Codigo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "QUANTIDADE EM ESTOQUE";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(290, 358);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(149, 20);
            this.txtEstoque.TabIndex = 27;
            this.txtEstoque.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Transparent;
            this.btnComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Image = ((System.Drawing.Image)(resources.GetObject("btnComprar.Image")));
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComprar.Location = new System.Drawing.Point(503, 368);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(90, 92);
            this.btnComprar.TabIndex = 28;
            this.btnComprar.Text = "Excluir Produto";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(687, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 92);
            this.button2.TabIndex = 29;
            this.button2.Text = "Voltar Para o Menu";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // LISTAPROD
            // 
            this.LISTAPROD.FormattingEnabled = true;
            this.LISTAPROD.Location = new System.Drawing.Point(34, 67);
            this.LISTAPROD.Name = "LISTAPROD";
            this.LISTAPROD.Size = new System.Drawing.Size(188, 264);
            this.LISTAPROD.TabIndex = 30;
            this.LISTAPROD.SelectedIndexChanged += new System.EventHandler(this.LISTAPROD_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 485);
            this.Controls.Add(this.LISTAPROD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCaixa);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Codigo);
            this.Name = "Form1";
            this.Text = "Carrinho de Compras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCaixa;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox LISTAPROD;
    }
}