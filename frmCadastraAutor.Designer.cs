namespace Acesso_a_BD
{
    partial class frmCadastraAutor
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
            this.txtSobrenomeAutor = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.lblSobrenomeAutor = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnCadastraAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSobrenomeAutor
            // 
            this.txtSobrenomeAutor.Location = new System.Drawing.Point(362, 122);
            this.txtSobrenomeAutor.Name = "txtSobrenomeAutor";
            this.txtSobrenomeAutor.Size = new System.Drawing.Size(132, 20);
            this.txtSobrenomeAutor.TabIndex = 0;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(362, 81);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(132, 20);
            this.txtNomeAutor.TabIndex = 1;
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAutor.Location = new System.Drawing.Point(215, 77);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(141, 24);
            this.lblNomeAutor.TabIndex = 2;
            this.lblNomeAutor.Text = "Nome do autor:";
            // 
            // lblSobrenomeAutor
            // 
            this.lblSobrenomeAutor.AutoSize = true;
            this.lblSobrenomeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenomeAutor.Location = new System.Drawing.Point(167, 117);
            this.lblSobrenomeAutor.Name = "lblSobrenomeAutor";
            this.lblSobrenomeAutor.Size = new System.Drawing.Size(189, 24);
            this.lblSobrenomeAutor.TabIndex = 3;
            this.lblSobrenomeAutor.Text = "Sobrenome do autor:";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTexto.Location = new System.Drawing.Point(89, 33);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(633, 25);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Preencha os campos abaixo para cadastrar um novo autor:";
            // 
            // btnCadastraAutor
            // 
            this.btnCadastraAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraAutor.Location = new System.Drawing.Point(352, 167);
            this.btnCadastraAutor.Name = "btnCadastraAutor";
            this.btnCadastraAutor.Size = new System.Drawing.Size(157, 58);
            this.btnCadastraAutor.TabIndex = 5;
            this.btnCadastraAutor.Text = "Cadastrar Autor";
            this.btnCadastraAutor.UseVisualStyleBackColor = true;
            this.btnCadastraAutor.Click += new System.EventHandler(this.btnCadastraAutor_Click);
            // 
            // frmCadastraAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastraAutor);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblSobrenomeAutor);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtSobrenomeAutor);
            this.Name = "frmCadastraAutor";
            this.Text = "frmCadastraAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSobrenomeAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.Label lblSobrenomeAutor;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnCadastraAutor;
    }
}