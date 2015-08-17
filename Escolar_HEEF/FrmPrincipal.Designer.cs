namespace Escolar_HEEF
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbVersao = new System.Windows.Forms.Label();
            this.btnProfessores = new System.Windows.Forms.Button();
            this.btnAreaConhecimentos = new System.Windows.Forms.Button();
            this.btnNotasAlunos = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnHistoricoAluno = new System.Windows.Forms.Button();
            this.panelPrincipalbaixo = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbConectadoNomedoUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbacesso = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbConectadoGrupodoUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.txttraco = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbhora = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.panelPrincipal.SuspendLayout();
            this.panelPrincipalbaixo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.btnLogar);
            this.panelPrincipal.Controls.Add(this.btnSair);
            this.panelPrincipal.Controls.Add(this.lbVersao);
            this.panelPrincipal.Controls.Add(this.btnProfessores);
            this.panelPrincipal.Controls.Add(this.btnAreaConhecimentos);
            this.panelPrincipal.Controls.Add(this.btnNotasAlunos);
            this.panelPrincipal.Controls.Add(this.btnAlunos);
            this.panelPrincipal.Controls.Add(this.btnHistoricoAluno);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1213, 159);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogar.Image = global::Escolar_HEEF.Properties.Resources.logar_cadeado;
            this.btnLogar.Location = new System.Drawing.Point(835, 0);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(163, 159);
            this.btnLogar.TabIndex = 7;
            this.btnLogar.Text = "&Logar";
            this.btnLogar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Image = global::Escolar_HEEF.Properties.Resources.BTN_SAIR;
            this.btnSair.Location = new System.Drawing.Point(1003, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(163, 159);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sai&r";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbVersao
            // 
            this.lbVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVersao.AutoSize = true;
            this.lbVersao.Location = new System.Drawing.Point(1113, 9);
            this.lbVersao.Name = "lbVersao";
            this.lbVersao.Size = new System.Drawing.Size(97, 13);
            this.lbVersao.TabIndex = 5;
            this.lbVersao.Text = "AlexSystem 1.0.1.0";
            this.lbVersao.Click += new System.EventHandler(this.lbVersao_Click);
            // 
            // btnProfessores
            // 
            this.btnProfessores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfessores.Image = global::Escolar_HEEF.Properties.Resources.Books___pencils_512;
            this.btnProfessores.Location = new System.Drawing.Point(668, 0);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(163, 159);
            this.btnProfessores.TabIndex = 4;
            this.btnProfessores.Text = "Cadastro &Professores";
            this.btnProfessores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfessores.UseVisualStyleBackColor = false;
            this.btnProfessores.Click += new System.EventHandler(this.btnProfessores_Click);
            // 
            // btnAreaConhecimentos
            // 
            this.btnAreaConhecimentos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAreaConhecimentos.Image = global::Escolar_HEEF.Properties.Resources.Book___Pens_512;
            this.btnAreaConhecimentos.Location = new System.Drawing.Point(501, 0);
            this.btnAreaConhecimentos.Name = "btnAreaConhecimentos";
            this.btnAreaConhecimentos.Size = new System.Drawing.Size(163, 159);
            this.btnAreaConhecimentos.TabIndex = 3;
            this.btnAreaConhecimentos.Text = "Areas &Conhecimento";
            this.btnAreaConhecimentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAreaConhecimentos.UseVisualStyleBackColor = false;
            this.btnAreaConhecimentos.Click += new System.EventHandler(this.btnAreaConhecimentos_Click);
            // 
            // btnNotasAlunos
            // 
            this.btnNotasAlunos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNotasAlunos.Image = global::Escolar_HEEF.Properties.Resources.Blackboard_512;
            this.btnNotasAlunos.Location = new System.Drawing.Point(334, 0);
            this.btnNotasAlunos.Name = "btnNotasAlunos";
            this.btnNotasAlunos.Size = new System.Drawing.Size(163, 159);
            this.btnNotasAlunos.TabIndex = 2;
            this.btnNotasAlunos.Text = "Cadastro &Notas Aluno";
            this.btnNotasAlunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNotasAlunos.UseVisualStyleBackColor = false;
            this.btnNotasAlunos.Click += new System.EventHandler(this.btnNotasAlunos_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlunos.Image = global::Escolar_HEEF.Properties.Resources.Bag_512;
            this.btnAlunos.Location = new System.Drawing.Point(167, 0);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(163, 159);
            this.btnAlunos.TabIndex = 1;
            this.btnAlunos.Text = "Cadastro &Aluno";
            this.btnAlunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnHistoricoAluno
            // 
            this.btnHistoricoAluno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistoricoAluno.Image = global::Escolar_HEEF.Properties.Resources.Table_512;
            this.btnHistoricoAluno.Location = new System.Drawing.Point(0, 0);
            this.btnHistoricoAluno.Name = "btnHistoricoAluno";
            this.btnHistoricoAluno.Size = new System.Drawing.Size(163, 159);
            this.btnHistoricoAluno.TabIndex = 0;
            this.btnHistoricoAluno.Text = "&Histórico Aluno";
            this.btnHistoricoAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistoricoAluno.UseVisualStyleBackColor = false;
            this.btnHistoricoAluno.Click += new System.EventHandler(this.btnHistoricoAluno_Click);
            // 
            // panelPrincipalbaixo
            // 
            this.panelPrincipalbaixo.Controls.Add(this.statusStrip1);
            this.panelPrincipalbaixo.Controls.Add(this.pictureBox1);
            this.panelPrincipalbaixo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipalbaixo.Location = new System.Drawing.Point(0, 159);
            this.panelPrincipalbaixo.Name = "panelPrincipalbaixo";
            this.panelPrincipalbaixo.Size = new System.Drawing.Size(1213, 299);
            this.panelPrincipalbaixo.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbLogado,
            this.lbConectadoNomedoUsuario,
            this.lbacesso,
            this.lbConectadoGrupodoUsuario,
            this.txttraco,
            this.lbhora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 277);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1213, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbLogado
            // 
            this.lbLogado.Name = "lbLogado";
            this.lbLogado.Size = new System.Drawing.Size(50, 17);
            this.lbLogado.Text = "Logado ";
            // 
            // lbConectadoNomedoUsuario
            // 
            this.lbConectadoNomedoUsuario.Name = "lbConectadoNomedoUsuario";
            this.lbConectadoNomedoUsuario.Size = new System.Drawing.Size(56, 17);
            this.lbConectadoNomedoUsuario.Text = "USUARIO";
            // 
            // lbacesso
            // 
            this.lbacesso.Name = "lbacesso";
            this.lbacesso.Size = new System.Drawing.Size(47, 17);
            this.lbacesso.Text = "Acesso ";
            // 
            // lbConectadoGrupodoUsuario
            // 
            this.lbConectadoGrupodoUsuario.Name = "lbConectadoGrupodoUsuario";
            this.lbConectadoGrupodoUsuario.Size = new System.Drawing.Size(76, 17);
            this.lbConectadoGrupodoUsuario.Text = "CONVIDADO";
            // 
            // txttraco
            // 
            this.txttraco.Name = "txttraco";
            this.txttraco.Size = new System.Drawing.Size(18, 17);
            this.txttraco.Text = " - ";
            // 
            // lbhora
            // 
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(41, 17);
            this.lbhora.Text = "lbhora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Escolar_HEEF.Properties.Resources.fofoalunos;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1213, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Enabled = true;
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 458);
            this.Controls.Add(this.panelPrincipalbaixo);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "HEEF Ecolar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelPrincipalbaixo.ResumeLayout(false);
            this.panelPrincipalbaixo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelPrincipalbaixo;
        private System.Windows.Forms.Button btnHistoricoAluno;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnNotasAlunos;
        private System.Windows.Forms.Button btnAreaConhecimentos;
        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbVersao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbLogado;
        private System.Windows.Forms.ToolStripStatusLabel lbConectadoNomedoUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lbacesso;
        private System.Windows.Forms.ToolStripStatusLabel lbConectadoGrupodoUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lbhora;
        private System.Windows.Forms.ToolStripStatusLabel txttraco;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.Button btnLogar;
    }
}

