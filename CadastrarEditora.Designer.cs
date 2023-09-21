namespace Acesso_a_BD
{
    partial class CadastrarEditora
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
            this.btnCadastrarEditora = new System.Windows.Forms.Button();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarEditora
            // 
            this.btnCadastrarEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEditora.Location = new System.Drawing.Point(320, 165);
            this.btnCadastrarEditora.Name = "btnCadastrarEditora";
            this.btnCadastrarEditora.Size = new System.Drawing.Size(138, 49);
            this.btnCadastrarEditora.TabIndex = 0;
            this.btnCadastrarEditora.Text = "Cadastrar Editora";
            this.btnCadastrarEditora.UseVisualStyleBackColor = true;
            this.btnCadastrarEditora.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(308, 129);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(159, 20);
            this.txtNomeEditora.TabIndex = 2;
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEditora.Location = new System.Drawing.Point(82, 124);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(220, 24);
            this.lblNomeEditora.TabIndex = 3;
            this.lblNomeEditora.Text = "Digite o nome da editora:";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTexto.Location = new System.Drawing.Point(70, 76);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(665, 25);
            this.lblTexto.TabIndex = 5;
            this.lblTexto.Text = "Preencha os campos abaixo para cadastrar uma nova editora:";
            this.lblTexto.Click += new System.EventHandler(this.lblTexto_Click);
            // 
            // CadastrarEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblNomeEditora);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.btnCadastrarEditora);
            this.Name = "CadastrarEditora";
            this.Text = "CadastrarEditora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.Label lblTexto;
    }
}