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
            this.txtNomeLivro.Location = new System.Drawing.Point(228, 147);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(138, 20);
            this.txtNomeLivro.TabIndex = 2;
            // 
            // txtPrecoLivro
            // 
            this.txtPrecoLivro.Location = new System.Drawing.Point(228, 189);
            this.txtPrecoLivro.Name = "txtPrecoLivro";
            this.txtPrecoLivro.Size = new System.Drawing.Size(138, 20);
            this.txtPrecoLivro.TabIndex = 3;
            // 
            // txtDataPub
            // 
            this.txtDataPub.Location = new System.Drawing.Point(228, 233);
            this.txtDataPub.Name = "txtDataPub";
            this.txtDataPub.Size = new System.Drawing.Size(138, 20);
            this.txtDataPub.TabIndex = 4;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(330, 53);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(105, 32);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(42, 63);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(115, 13);
            this.lblLivro.TabIndex = 6;
            this.lblLivro.Text = "Digite o código do livro";
            // 
            // lbLivro
            // 
            this.lbLivro.AutoSize = true;
            this.lbLivro.Location = new System.Drawing.Point(147, 150);
            this.lbLivro.Name = "lbLivro";
            this.lbLivro.Size = new System.Drawing.Size(75, 13);
            this.lbLivro.TabIndex = 7;
            this.lbLivro.Text = "Nome do livro:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(147, 192);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(75, 13);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço do livro:";
            // 
            // lblDataPub
            // 
            this.lblDataPub.AutoSize = true;
            this.lblDataPub.Location = new System.Drawing.Point(119, 236);
            this.lblDataPub.Name = "lblDataPub";
            this.lblDataPub.Size = new System.Drawing.Size(103, 13);
            this.lblDataPub.TabIndex = 9;
            this.lblDataPub.Text = "Data de publicação:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDataPub);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lbLivro);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtDataPub);
            this.Controls.Add(this.txtPrecoLivro);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.txtCodLivro);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

