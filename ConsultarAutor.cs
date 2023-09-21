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
    public partial class ConsultarAutor : Form
    {
        public string consulta; 
        
        public ConsultarAutor()
        {
            InitializeComponent();
        }

        private void ConsultarAutor_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaAutor_Click(object sender, EventArgs e)
        {
            consulta = "SELECT NomeAutor, SobrenomeAutor FROM tbl_Autores WHERE IdAutor = " + txtCodAutor.Text;;

            ConsultaAutor consultaAutor = new ConsultaAutor();

            consultaAutor.fazerConsulta(consulta);

            txtNomeAutor.Text = Variaveis.CaixatxtNomeAutor;
            txtSobrenomeAutor.Text = Variaveis.CaixatxtSobrenomeAutor;
        }
    }
}
