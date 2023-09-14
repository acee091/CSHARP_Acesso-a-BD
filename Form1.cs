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
    public partial class Form1 : Form
    {
        public string consulta;
        public string sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            // Consulta a ser realizada:
            consulta = "SELECT NomeLivro, PrecoLivro, DataPub FROM tbl_Livros WHERE IdLivro = " + txtCodLivro.Text;

            //Instanciar a classe que realiza a consulta:
            ConsultarLivro consultarLivros = new ConsultarLivro();

            //Passar a string SQL para o metódo fazerConsulta()
            consultarLivros.fazerConsulta(consulta);

            //Mostrar os resultados nas caixas de texto
            txtNomeLivro.Text = Variaveis.CaixaTxtNomeLivro;            
            txtPrecoLivro.Text = Variaveis.CaixaTxtPrecoLivro;
            txtDataPub.Text = Variaveis.CaixaTxtDataPub.ToString("dd/MM/yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carrega ComboBox com método da classe CareggaComboBox e Listas
            consulta = "SELECT NomeLivro FROM tbl_Livros";
            CarregaComboBox carregaLivros = new CarregaComboBox();

            //Cria Objeto de lista para armazenar os dados dos livros:
            List<string> Livros = new List<string>();

            //Carrega Dados retornados do BD para a lista
            Livros.AddRange(carregaLivros.carregaComboBox(consulta, "NomeLivro"));

            //Converte e copia dados da lista para o combobox
            cmbLivros.Items.AddRange(Livros.ToArray()); //AddRange só recebe ARRAY
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAutor Tela = new ConsultarAutor();
            Tela.Show();
        }
    }
}
