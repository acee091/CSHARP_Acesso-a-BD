namespace Acesso_a_BD
{
    partial class Form1
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
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtPrecoLivro = new System.Windows.Forms.TextBox();
            this.txtDataPub = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblLivro = new System.Windows.Forms.Label();
            this.lbLivro = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDataPub = new System.Windows.Forms.Label();
            this.cmbLivros = new System.Windows.Forms.ComboBox();
            this.lblLivroDisponivel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Location = new System.Drawing.Point(181, 60);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(121, 20);
            this.txtCodLivro.TabIndex = 0;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(181, 145);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(138, 20);
            this.txtNomeLivro.TabIndex = 2;
            // 
            // txtPrecoLivro
            // 
            this.txtPrecoLivro.Location = new System.Drawing.Point(181, 189);
            this.txtPrecoLivro.Name = "txtPrecoLivro";
            this.txtPrecoLivro.Size = new System.Drawing.Size(138, 20);
            this.txtPrecoLivro.TabIndex = 3;
            // 
            // txtDataPub
            // 
            this.txtDataPub.Location = new System.Drawing.Point(181, 230);
            this.txtDataPub.Name = "txtDataPub";
            this.txtDataPub.Size = new System.Drawing.Size(138, 20);
            this.txtDataPub.TabIndex = 4;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(181, 97);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(121, 32);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(54, 63);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(118, 13);
            this.lblLivro.TabIndex = 6;
            this.lblLivro.Text = "Digite o código do livro:";
            // 
            // lbLivro
            // 
            this.lbLivro.AutoSize = true;
            this.lbLivro.Location = new System.Drawing.Point(94, 148);
            this.lbLivro.Name = "lbLivro";
            this.lbLivro.Size = new System.Drawing.Size(75, 13);
            this.lbLivro.TabIndex = 7;
            this.lbLivro.Text = "Nome do livro:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(94, 192);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(75, 13);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço do livro:";
            // 
            // lblDataPub
            // 
            this.lblDataPub.AutoSize = true;
            this.lblDataPub.Location = new System.Drawing.Point(66, 233);
            this.lblDataPub.Name = "lblDataPub";
            this.lblDataPub.Size = new System.Drawing.Size(103, 13);
            this.lblDataPub.TabIndex = 9;
            this.lblDataPub.Text = "Data de publicação:";
            // 
            // cmbLivros
            // 
            this.cmbLivros.FormattingEnabled = true;
            this.cmbLivros.Location = new System.Drawing.Point(499, 97);
            this.cmbLivros.Name = "cmbLivros";
            this.cmbLivros.Size = new System.Drawing.Size(180, 21);
            this.cmbLivros.TabIndex = 10;
            // 
            // lblLivroDisponivel
            // 
            this.lblLivroDisponivel.AutoSize = true;
            this.lblLivroDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivroDisponivel.Location = new System.Drawing.Point(497, 70);
            this.lblLivroDisponivel.Name = "lblLivroDisponivel";
            this.lblLivroDisponivel.Size = new System.Drawing.Size(182, 24);
            this.lblLivroDisponivel.TabIndex = 11;
            this.lblLivroDisponivel.Text = "Livros disponíveis:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem,
            this.editorasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarAutorToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // consultarAutorToolStripMenuItem
            // 
            this.consultarAutorToolStripMenuItem.Name = "consultarAutorToolStripMenuItem";
            this.consultarAutorToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.consultarAutorToolStripMenuItem.Text = "Consultar Autor";
            this.consultarAutorToolStripMenuItem.Click += new System.EventHandler(this.consultarAutorToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorasToolStripMenuItem.Text = "Editoras";
            this.editorasToolStripMenuItem.Click += new System.EventHandler(this.editorasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLivroDisponivel);
            this.Controls.Add(this.cmbLivros);
            this.Controls.Add(this.lblDataPub);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lbLivro);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtDataPub);
            this.Controls.Add(this.txtPrecoLivro);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.txtCodLivro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtPrecoLivro;
        private System.Windows.Forms.TextBox txtDataPub;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Label lbLivro;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDataPub;
        private System.Windows.Forms.ComboBox cmbLivros;
        private System.Windows.Forms.Label lblLivroDisponivel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
    }
}

