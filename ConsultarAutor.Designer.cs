namespace Acesso_a_BD
{
    partial class ConsultarAutor
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
            this.txtCodAutor = new System.Windows.Forms.TextBox();
            this.btnConsultaAutor = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtSobrenomeAutor = new System.Windows.Forms.TextBox();
            this.lblCodAutor = new System.Windows.Forms.Label();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.lblSobrenomeAutor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodAutor
            // 
            this.txtCodAutor.Location = new System.Drawing.Point(166, 110);
            this.txtCodAutor.Name = "txtCodAutor";
            this.txtCodAutor.Size = new System.Drawing.Size(121, 20);
            this.txtCodAutor.TabIndex = 1;
            // 
            // btnConsultaAutor
            // 
            this.btnConsultaAutor.Location = new System.Drawing.Point(166, 136);
            this.btnConsultaAutor.Name = "btnConsultaAutor";
            this.btnConsultaAutor.Size = new System.Drawing.Size(121, 32);
            this.btnConsultaAutor.TabIndex = 6;
            this.btnConsultaAutor.Text = "Consultar";
            this.btnConsultaAutor.UseVisualStyleBackColor = true;
            this.btnConsultaAutor.Click += new System.EventHandler(this.btnConsultaAutor_Click);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(166, 223);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(121, 20);
            this.txtNomeAutor.TabIndex = 7;
            // 
            // txtSobrenomeAutor
            // 
            this.txtSobrenomeAutor.Location = new System.Drawing.Point(166, 277);
            this.txtSobrenomeAutor.Name = "txtSobrenomeAutor";
            this.txtSobrenomeAutor.Size = new System.Drawing.Size(121, 20);
            this.txtSobrenomeAutor.TabIndex = 8;
            // 
            // lblCodAutor
            // 
            this.lblCodAutor.AutoSize = true;
            this.lblCodAutor.Location = new System.Drawing.Point(37, 117);
            this.lblCodAutor.Name = "lblCodAutor";
            this.lblCodAutor.Size = new System.Drawing.Size(123, 13);
            this.lblCodAutor.TabIndex = 9;
            this.lblCodAutor.Text = "Digite o código do autor:";
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(80, 226);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(80, 13);
            this.lblNomeAutor.TabIndex = 10;
            this.lblNomeAutor.Text = "Nome do autor:";
            // 
            // lblSobrenomeAutor
            // 
            this.lblSobrenomeAutor.AutoSize = true;
            this.lblSobrenomeAutor.Location = new System.Drawing.Point(54, 280);
            this.lblSobrenomeAutor.Name = "lblSobrenomeAutor";
            this.lblSobrenomeAutor.Size = new System.Drawing.Size(106, 13);
            this.lblSobrenomeAutor.TabIndex = 11;
            this.lblSobrenomeAutor.Text = "Sobrenome do autor:";
            // 
            // ConsultarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.lblSobrenomeAutor);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.lblCodAutor);
            this.Controls.Add(this.txtSobrenomeAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.btnConsultaAutor);
            this.Controls.Add(this.txtCodAutor);
            this.Name = "ConsultarAutor";
            this.Text = "ConsultarAutor";
            this.Load += new System.EventHandler(this.ConsultarAutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodAutor;
        private System.Windows.Forms.Button btnConsultaAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtSobrenomeAutor;
        private System.Windows.Forms.Label lblCodAutor;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.Label lblSobrenomeAutor;
    }
}