using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Escolar_HEEF.Frms
{
    public partial class FrmLoginSenha : Form
    {
        string[] caracteresAvulsos = new string[] { ",", "*", ";", "INSERT", "insert", "SELECT", "select", "WHERE", "where", "FROM", "from", "AND", "and" };
        public bool Logadonosistema;
        int errorusuario = 0, errorsenha = 0;
        public string receberDadosTabela = "tbusuario";
        public bool logadonosistemaGetSet { get; set; }
        public string NivelAcesso { get; set; }         //Responsavel pelo Nivel de Acesso
        public string UsuarioConectado{ get; set; } //Responsavel por mostrar quem esta conectado no sistema
        public FrmLoginSenha()
        {
            InitializeComponent();
        }
        public FrmLoginSenha(bool Logadonosistema)
        {
            logadonosistemaGetSet = Logadonosistema;
            InitializeComponent();
        }
        private void LoginSenha_Load(object sender, EventArgs e)
        {

            //Vincular Enter ao btnLogin
           // this.AcceptButton = btnLogar;
            //Vincular ESC ao btnSair
            this.CancelButton = btnSair;


        }
        private void estalogando()
        {
            string usuarionome = txtBoxUsuario.Text, usuariosenha = txtBoxSenha.Text;
            string sqlusuario = "";
            string sqlsenha = "";
            if ((usuarionome != "") && (usuariosenha != ""))
            {
                foreach (string aprocurardentro in caracteresAvulsos)
                {
                    int pos = usuarionome.IndexOf(aprocurardentro);
                    if (pos != -1)
                    {
                        errorusuario = errorusuario + 1;
                    }
                    int pos2 = usuariosenha.IndexOf(aprocurardentro);
                    if (pos2 != -1)
                    {
                        errorsenha = errorsenha + 1;
                    }
                }
                if (errorusuario > 0) { sqlusuario = " no Usuário " + errorusuario; }
                if (errorsenha > 0) { sqlsenha = "\n na Senha " + errorsenha; }
                int error = errorsenha + errorusuario;
                if (error > 0)
                {
                    txtgboxloginsenha.ForeColor = System.Drawing.Color.Red;
                    txtgboxloginsenha.Text = "Foi Encontrado SQL Inject " + sqlusuario + " " + sqlsenha;
                    txtBoxSenha.Clear();
                    errorusuario = 0;
                    errorsenha = 0;
                }
                else
                {
                    try
                    {
                        ClsObjetos.ClsUsuario dadosdatabela = new ClsObjetos.ClsUsuario();
                        string NomedoTabela = txtBoxUsuario.Text;
                        dadosdatabela.Nome = usuarionome;
                        dadosdatabela.Senha = usuariosenha;
                        Logadonosistema = Convert.ToBoolean(Dao.DaoAcessoUsuarioSql.MySql_GetUsuarioseAdmin(receberDadosTabela, dadosdatabela, Logadonosistema));
                        if (Logadonosistema)
                        {
                            administradordatabela = Dao.DaoAcessoUsuarioSql.MySql_ProcuraDadosadminstrador(receberDadosTabela, NomedoTabela);
                            logadonosistemaGetSet = Logadonosistema;
                            UsuarioConectado = dadosdatabela.Nome;
                            NivelAcesso = administradordatabela;
                            this.Close();
                        }
                        else
                        {
                            txtgboxloginsenha.ForeColor = System.Drawing.Color.Red;
                            txtgboxloginsenha.Text = "Por favor Digite Usuário, e ou, Senha \n Validos!";
                            txtBoxSenha.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("\n \n Ocorreu algun erro! \n \n" + ex.Message, "Erro ao Acesso de Login ", MessageBoxButtons.OK);
                        Close();
                    }
                }
            }
            else
            {
                txtgboxloginsenha.ForeColor = System.Drawing.Color.Red;
                txtgboxloginsenha.Text = "Por favor Digite Usuário, e ou, Senha";
                txtBoxSenha.Clear();
            }
        }
        public string administradordatabela { get; set; }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public bool PodeAbrirContaSozinho
        {
            get
            {
                //bool maiorDeIdade = this.idade >= 18;
                //bool emancipado = this.documentos.contains("emancipacao");
                bool possuiCPF = !string.IsNullOrEmpty(this.txtBoxSenha.Text);
                //return (maiorDeIdade || emancipado) && possuiCPF;
                return possuiCPF;
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            estalogando();
        }
        private void txtBoxUsuario_Click(object sender, EventArgs e)
        {
            metodoMudarDigitacaoTexto();
        }

        private void metodoMudarDigitacaoTexto()
        {
            txtgboxloginsenha.ForeColor = System.Drawing.Color.Black;
            txtgboxloginsenha.Text = "Digite Seu Login de Usuário e Senha";
        }
        private void PressionarEnterSenha(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 	//se pressionar enter ensina do txtsenha o sistema vai camar logar...
            {
                estalogando();
            }
        }

        private void key_Enter_Press(object sender, KeyEventArgs e)
        {
            //string procurartecla = e.KeyCode.ToString();
            //metodoProcurandoCaracteres(procurartecla);

            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            metodoMudarDigitacaoTexto();

        }

        private void key_Caracteres(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                metodoMudarDigitacaoTexto();
            }
            string procurartecla = txtBoxUsuario.Text;
            metodoProcurandoCaracteres(procurartecla);


        }

        private void metodoProcurandoCaracteres(string procurartecla)
        {
            foreach (string aprocurardentro in caracteresAvulsos)
            {
                int pos = procurartecla.IndexOf(aprocurardentro);
                if (pos != -1)
                {
                    txtgboxloginsenha.ForeColor = System.Drawing.Color.Red;
                    txtgboxloginsenha.Text = "Caracteres \"" + aprocurardentro + "\" não permitido! ";
                }
            }

        }
    }
}
