using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Escolar_HEEF
{
    public partial class FrmAlunoCadastra : Form
    {
        private string receberDadosTabela;
        private string NomedoUsuarioConectado;
        private string GrupodoUsuarioConectado;

        public FrmAlunoCadastra()
        {
            InitializeComponent();
        }

        public FrmAlunoCadastra(string receberDadosTabela, string NomedoUsuarioConectado, string GrupodoUsuarioConectado)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.receberDadosTabela = receberDadosTabela;
            this.NomedoUsuarioConectado = NomedoUsuarioConectado;
            this.GrupodoUsuarioConectado = GrupodoUsuarioConectado;

        }
        private void btnSair_Click(object sender, EventArgs e)
        {

            saindodatela();
        }

        private void saindodatela()
        {

            if ((txtCpf.Text != "") && (txtNome.Text != ""))
            {
                if (!MessageBox.Show("Deseja realmente sair sem salvar!"
                        , "Saindo do Cadastro!"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.No))
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClsObjetos.ClsAluno aluno = new ClsObjetos.ClsAluno();
            if ((txtCpf.Text != "") && (txtNome.Text != ""))
            {
                try
                {
                    aluno.Nome = txtNome.Text;
                    aluno.Telefone = txtFone.Text;
                    aluno.Endereco = txtEndereco.Text;
                    aluno.Bairro = txtBairro.Text;
                    aluno.Cidade = txtCidade.Text;
                    aluno.Mae = txtmae.Text;
                    aluno.Pai = txtpai.Text;

                    
                 //   aluno.DATADIA = Convert.ToDateTime(txtDataDia.Text);
                 //   aluno.CADASTADOPOR = txtCadastradoPor.Text;

                    //MessageBox.Show("Deseja Cadastra Novamente?"
                    //+ txtNome.Text
                    //+ txtCpf.Text
                    //+ txtFone.Text
                    //+ txtEndereco.Text
                    //+ txtBairro.Text
                    //+ txtCidade.Text
                    //+ txtEstado.Text
                    //+ txtDataDia.Text
                    //+ txtCadastradoPor.Text
                    //, usuario.NOME + " Inserido com sucesso !");

                    //MessageBox.Show("Pegou o cpf -> " + txtCpf.Text + "\n Pegou o DADOS -> " + receberDadosTabela);
//                    Dao.DaoAcessoClienteMysql.MySql_InserirDados(receberDadosTabela, aluno);
                    if (!MessageBox.Show("Deseja Cadastra Novamente?                 "

                        //+ txtNome.Text 
                        //+ txtCpf.Text 
                        //+ txtFone.Text 
                        //+ txtEndereco.Text 
                        //+ txtBairro.Text
                        //+ txtCidade.Text
                        //+ txtEstado.Text
                        //+ txtDataDia.Text
                        //+ txtCadastradoPor.Text

                        , aluno.Nome + " Inserido com sucesso !"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                    {
                        this.Close();
                    }
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtFone.Clear();
                    txtEndereco.Clear();
                    txtBairro.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();
                    txtNome.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                    //this.Close();
                }

            }
            else
            {
                MessageBox.Show("Dados não preenchido, \n Favor preencher!");
            }

        }

        private void FrmAlunoCadastra_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            txtNome.Select();
        }
        private void key_Enter_Press(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape)
            {
                saindodatela();
            }
        }


    }
}
