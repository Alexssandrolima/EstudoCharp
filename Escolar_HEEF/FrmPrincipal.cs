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
    public partial class FrmPrincipal : Form
    {
        private static bool logadonosistema = false;

        public static bool Logadonosistema
        {
            get { return FrmPrincipal.logadonosistema; }
            set { FrmPrincipal.logadonosistema = value; }
        }
        public string ConectadoNomedoUsuario { get; set; }
        public string ConectadoGrupodoUsuario { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
#if DEBUG
            ConectadoNomedoUsuario = "ALEX";
            ConectadoGrupodoUsuario = "ADM";
#else
            ConectadoNomedoUsuario = "CONVIDADO";
            ConectadoGrupodoUsuario = "CONV";
#endif
            quemestaconectadoagoranosistema();
        }

        private void btnHistoricoAluno_Click(object sender, EventArgs e)
        {

         
            mensagemqueeuquero();
        }
        
        private void btnAlunos_Click(object sender, EventArgs e)
        {
            FrmAlunoPrincipalAbrirTelaSelecionada();
        }

        private void btnNotasAlunos_Click(object sender, EventArgs e)
        {
            mensagemqueeuquero();
        }

        private void btnAreaConhecimentos_Click(object sender, EventArgs e)
        {
            mensagemqueeuquero();
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            mensagemqueeuquero();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            saindodosistema();
        }

        private void saindodosistema()
        {
            if (MessageBox.Show(" " + ConectadoNomedoUsuario + "! \n Deseja realmente sair do sistema?", "Saindo do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                //if (MessageBox.Show("Deseja Salvar seus DADOS ao sair?", "Bkp do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                //{
                //    MessageBox.Show("Salvo com Sucesso!");
                //    this.Close();
                //}
                //else
                //{
                    this.Close();
                //}
            }
        }

        private void mensagemqueeuquero()
        {
            MessageBox.Show("Em conclusão! ", "Obrigado!");
        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            DateTime datahora = DateTime.Now;
            lbhora.Text = "Data: " + datahora.ToShortDateString() + " Hora: " + datahora.ToLongTimeString();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            timerPrincipal_Tick(e, e);
            this.CancelButton = btnSair ;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (Logadonosistema)
            {
                if (MessageBox.Show(" " + ConectadoNomedoUsuario + "! \n Deseja realmente Sair do Login? "
                    , "Fazer Logout no Sistema?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    sair_dosistemadesconectando();
                }
            }
            else
            {
                entrar_comsenhanosistema();
            }
        
        }

        private void entrar_comsenhanosistema()
        {
            Frms.FrmLoginSenha fazerlogin = new Frms.FrmLoginSenha(Logadonosistema);
            fazerlogin.ShowDialog();
            Logadonosistema = fazerlogin.logadonosistemaGetSet;


#if DEBUG
            ConectadoNomedoUsuario = "ALEX";
            ConectadoGrupodoUsuario = "ADM";
            Logadonosistema = true;

#else
            ConectadoNomedoUsuario = fazerlogin.UsuarioConectado;
            ConectadoGrupodoUsuario = fazerlogin.NivelAcesso;
#endif

            quemestaconectadoagoranosistema();
            if (Logadonosistema)
            {
                //btnLogar.Text = " " + ConectadoNomedoUsuario + "  fazer &Logout";
                btnLogar.Text = "&Logout";
            }
        }

        private void sair_dosistemadesconectando()
        {
            btnLogar.Text = "&Logar";
            Logadonosistema = false;
            ConectadoNomedoUsuario = "CONVIDADO";
            ConectadoGrupodoUsuario = "CONV";
            quemestaconectadoagoranosistema();
        }

        private void quemestaconectadoagoranosistema()
        {
            lbConectadoNomedoUsuario.Text = ConectadoNomedoUsuario;
            lbConectadoGrupodoUsuario.Text = ConectadoGrupodoUsuario;
        }


        private void FrmAlunoPrincipalAbrirTelaSelecionada()
        {
            if ((Logadonosistema) && (ConectadoGrupodoUsuario == "ADM"))
            {
                FrmAlunoPrincipal smd = new FrmAlunoPrincipal(ConectadoNomedoUsuario, ConectadoGrupodoUsuario);
                smd.ShowDialog();
            }
            else
            {
                entrar_comsenhanosistema();
                if ((Logadonosistema) && (ConectadoGrupodoUsuario == "ADM"))
                {
                    FrmAlunoPrincipal smd = new FrmAlunoPrincipal(ConectadoNomedoUsuario, ConectadoGrupodoUsuario);
                    smd.ShowDialog();
                }
                else
                {
                    MessageBox.Show("" + MessageBoxerrologado(),"Desculpa! ");
                }
            }
        }

        public string nomelogado, grupologado;

        public object MessageBoxerrologado()
        {

            if(!Logadonosistema)
            {
                nomelogado =  "\n Você nao está Logado! ";
            }
            if(ConectadoGrupodoUsuario != "ADM")
            {
               grupologado = "\n Você nao é administrador! ";
            }
            string tudologado = nomelogado + grupologado;
            return tudologado;

        }

        private void lbVersao_Click(object sender, EventArgs e)
        {
            Frms.FrmConfiguracao fconfig = new Frms.FrmConfiguracao();
            fconfig.ShowDialog();
        }


    }
}
