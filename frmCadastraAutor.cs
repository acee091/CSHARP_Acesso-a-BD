using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Acesso_a_BD
{
    public partial class frmCadastraAutor : Form
    {
        public string sql;
        public frmCadastraAutor()
        {
            InitializeComponent();
        }

        private void btnCadastraAutor_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tbl_Autores(NomeAutor, SobrenomeAutor) VALUES ('" + txtNomeAutor.Text + "', '" + txtSobrenomeAutor.Text + "');";
            MessageBox.Show(sql);

            ComandosDML inserir = new ComandosDML();
            try
            {
                inserir.iud(sql); //IUD -- I ->INSERT '' U -> UPDATE '' D -> DELETE
                MessageBox.Show("Registro inserido com sucesso");
            }
            catch ( SqlException s)
            {
                MessageBox.Show(s.Source.ToString(), "Erro de banco de dados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source.ToString(), "Erro Genérico");
            }
            finally
            {
                this.Hide();
            }
        }
    }
}
