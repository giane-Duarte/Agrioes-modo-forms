namespace Loja_Iniciaç
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackColor = System.Drawing.Color.Transparent;
            this.btnCadProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCadProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(225)))), ((int)(((byte)(115)))));
            this.btnCadProd.FlatAppearance.BorderSize = 3;
            this.btnCadProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnCadProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProd.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadProd.Image = ((System.Drawing.Image)(resources.GetObject("btnCadProd.Image")));
            this.btnCadProd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadProd.Location = new System.Drawing.Point(133, 57);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(119, 100);
            this.btnCadProd.TabIndex = 1;
            this.btnCadProd.Text = "Cadastrar Produtos";
            this.btnCadProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadProd.UseVisualStyleBackColor = false;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSobre.Location = new System.Drawing.Point(359, 319);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(107, 91);
            this.btnSobre.TabIndex = 5;
            this.btnSobre.Text = "Sobre a Agriões";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar.Location = new System.Drawing.Point(553, 207);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(118, 91);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar Produtos";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            this.btnComprar.Location = new System.Drawing.Point(133, 207);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(119, 91);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar Produtos";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(553, 57);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 91);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair do Sistema";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(143)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(143)))));
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(828, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(828, 472);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

