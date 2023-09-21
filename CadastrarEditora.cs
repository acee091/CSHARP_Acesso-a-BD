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
    public partial class CadastrarEditora : Form
    {
        public string sql;
        public CadastrarEditora()
        {
            InitializeComponent();
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tbl_editoras(NomeEditora) VALUES ('" + txtNomeEditora.Text + "');";
            MessageBox.Show(sql);

            ComandosDML inserir = new ComandosDML();
            try
            {
                inserir.iud(sql);
                MessageBox.Show("Registro Inserido com sucesso");
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString(), "Erro de Banco de dados");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Source.ToString(), "Erro genérico");
            }
            finally
            {
                this.Hide();
            }
        }
    }
}
