using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Escolar_HEEF
{
    public partial class FrmAlunoPrincipal : Form
    {

        public string receberDadosTabela = "ALUNOS";
        //public ClsObjetos.ClsConectado conectado;
        private string NomedoUsuarioConectado;
        private string GrupodoUsuarioConectado;

        public FrmAlunoPrincipal()
        {
            InitializeComponent();
        }

        public FrmAlunoPrincipal(string NomedoUsuarioConectado, string GrupodoUsuarioConectado)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.NomedoUsuarioConectado = NomedoUsuarioConectado;
            this.GrupodoUsuarioConectado = GrupodoUsuarioConectado;
            lbtxtacesso.Text = GrupodoUsuarioConectado;
            lbtxtlogado.Text = NomedoUsuarioConectado;

        }

        private void FrmPrincipalAluno_Load(object sender, EventArgs e)
        {
            preencheGrid();
        }

        private void preencheGrid()
        {

            string colunasdatabela = Properties.Settings.Default.tbalunos;
            try
            {
                dGVAlunos.DataSource = Dao.DaoAcessoAlunosSql.Sql_GetSepararDados(receberDadosTabela, colunasdatabela).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n \n DataGridView buscando dados Ocorreu um Erro! \n \n" + ex.Message, "Erro ao Acesso Usuarios ", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {


#if DEBUG
            NomedoUsuarioConectado = "ALEXSSANDROLIMA";
            GrupodoUsuarioConectado = "ADM";

            FrmAlunoCadastra cadastranovo = new FrmAlunoCadastra(receberDadosTabela, NomedoUsuarioConectado, GrupodoUsuarioConectado);
            cadastranovo.ShowDialog();
            preencheGrid();

#else

            FrmAlunoCadastra cadastranovo = new FrmAlunoCadastra(receberDadosTabela, NomedoUsuarioConectado, GrupodoUsuarioConectado);
            cadastranovo.ShowDialog();
            preencheGrid();

#endif





        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
