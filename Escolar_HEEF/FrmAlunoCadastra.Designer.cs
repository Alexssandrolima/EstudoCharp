namespace Escolar_HEEF
{
    partial class FrmAlunoCadastra
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbAlteradopor = new System.Windows.Forms.Label();
            this.txtAlteradoPor = new System.Windows.Forms.TextBox();
            this.lbDataalteracao = new System.Windows.Forms.Label();
            this.lbcadastradopor = new System.Windows.Forms.Label();
            this.txtCadastradoPor = new System.Windows.Forms.TextBox();
            this.lbdatacadastro = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.txtpai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmae = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlteradodata = new System.Windows.Forms.MaskedTextBox();
            this.txtDataDia = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(11, 314);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbAlteradopor
            // 
            this.lbAlteradopor.AutoSize = true;
            this.lbAlteradopor.Location = new System.Drawing.Point(56, 151);
            this.lbAlteradopor.Name = "lbAlteradopor";
            this.lbAlteradopor.Size = new System.Drawing.Size(46, 13);
            this.lbAlteradopor.TabIndex = 27;
            this.lbAlteradopor.Text = "Alterado";
            // 
            // txtAlteradoPor
            // 
            this.txtAlteradoPor.Location = new System.Drawing.Point(124, 148);
            this.txtAlteradoPor.Name = "txtAlteradoPor";
            this.txtAlteradoPor.Size = new System.Drawing.Size(118, 20);
            this.txtAlteradoPor.TabIndex = 21;
            this.txtAlteradoPor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // lbDataalteracao
            // 
            this.lbDataalteracao.AutoSize = true;
            this.lbDataalteracao.Location = new System.Drawing.Point(249, 151);
            this.lbDataalteracao.Name = "lbDataalteracao";
            this.lbDataalteracao.Size = new System.Drawing.Size(78, 13);
            this.lbDataalteracao.TabIndex = 25;
            this.lbDataalteracao.Text = "Data Alteração";
            // 
            // lbcadastradopor
            // 
            this.lbcadastradopor.AutoSize = true;
            this.lbcadastradopor.Location = new System.Drawing.Point(313, 248);
            this.lbcadastradopor.Name = "lbcadastradopor";
            this.lbcadastradopor.Size = new System.Drawing.Size(61, 13);
            this.lbcadastradopor.TabIndex = 23;
            this.lbcadastradopor.Text = "Cadastrado";
            // 
            // txtCadastradoPor
            // 
            this.txtCadastradoPor.Location = new System.Drawing.Point(380, 245);
            this.txtCadastradoPor.Name = "txtCadastradoPor";
            this.txtCadastradoPor.Size = new System.Drawing.Size(118, 20);
            this.txtCadastradoPor.TabIndex = 25;
            this.txtCadastradoPor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // lbdatacadastro
            // 
            this.lbdatacadastro.AutoSize = true;
            this.lbdatacadastro.Location = new System.Drawing.Point(510, 248);
            this.lbdatacadastro.Name = "lbdatacadastro";
            this.lbdatacadastro.Size = new System.Drawing.Size(75, 13);
            this.lbdatacadastro.TabIndex = 21;
            this.lbdatacadastro.Text = "Data Cadastro";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(520, 314);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "UF";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.gpBox);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 349);
            this.panel1.TabIndex = 1;
            // 
            // gpBox
            // 
            this.gpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBox.Controls.Add(this.txtpai);
            this.gpBox.Controls.Add(this.label8);
            this.gpBox.Controls.Add(this.txtmae);
            this.gpBox.Controls.Add(this.label7);
            this.gpBox.Controls.Add(this.lbAlteradopor);
            this.gpBox.Controls.Add(this.txtAlteradoPor);
            this.gpBox.Controls.Add(this.lbDataalteracao);
            this.gpBox.Controls.Add(this.txtAlteradodata);
            this.gpBox.Controls.Add(this.lbcadastradopor);
            this.gpBox.Controls.Add(this.txtCadastradoPor);
            this.gpBox.Controls.Add(this.lbdatacadastro);
            this.gpBox.Controls.Add(this.txtDataDia);
            this.gpBox.Controls.Add(this.label6);
            this.gpBox.Controls.Add(this.txtEstado);
            this.gpBox.Controls.Add(this.label5);
            this.gpBox.Controls.Add(this.txtCidade);
            this.gpBox.Controls.Add(this.label4);
            this.gpBox.Controls.Add(this.txtBairro);
            this.gpBox.Controls.Add(this.label3);
            this.gpBox.Controls.Add(this.txtEndereco);
            this.gpBox.Controls.Add(this.label1);
            this.gpBox.Controls.Add(this.txtFone);
            this.gpBox.Controls.Add(this.txtCpf);
            this.gpBox.Controls.Add(this.lbCpf);
            this.gpBox.Controls.Add(this.txtID);
            this.gpBox.Controls.Add(this.lbCodigo);
            this.gpBox.Controls.Add(this.txtNome);
            this.gpBox.Controls.Add(this.label2);
            this.gpBox.Location = new System.Drawing.Point(1, 12);
            this.gpBox.Name = "gpBox";
            this.gpBox.Size = new System.Drawing.Size(684, 271);
            this.gpBox.TabIndex = 10;
            this.gpBox.TabStop = false;
            this.gpBox.Text = "Usuário";
            // 
            // txtpai
            // 
            this.txtpai.Location = new System.Drawing.Point(124, 207);
            this.txtpai.Name = "txtpai";
            this.txtpai.Size = new System.Drawing.Size(379, 20);
            this.txtpai.TabIndex = 24;
            this.txtpai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Pai";
            // 
            // txtmae
            // 
            this.txtmae.Location = new System.Drawing.Point(124, 178);
            this.txtmae.Name = "txtmae";
            this.txtmae.Size = new System.Drawing.Size(379, 20);
            this.txtmae.TabIndex = 23;
            this.txtmae.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mãe";
            // 
            // txtAlteradodata
            // 
            this.txtAlteradodata.Location = new System.Drawing.Point(350, 148);
            this.txtAlteradodata.Mask = "00/00/0000";
            this.txtAlteradodata.Name = "txtAlteradodata";
            this.txtAlteradodata.Size = new System.Drawing.Size(63, 20);
            this.txtAlteradodata.TabIndex = 22;
            this.txtAlteradodata.ValidatingType = typeof(System.DateTime);
            this.txtAlteradodata.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // txtDataDia
            // 
            this.txtDataDia.Enabled = false;
            this.txtDataDia.Location = new System.Drawing.Point(611, 245);
            this.txtDataDia.Mask = "00/00/0000";
            this.txtDataDia.Name = "txtDataDia";
            this.txtDataDia.Size = new System.Drawing.Size(63, 20);
            this.txtDataDia.TabIndex = 26;
            this.txtDataDia.ValidatingType = typeof(System.DateTime);
            this.txtDataDia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(556, 96);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(38, 20);
            this.txtEstado.TabIndex = 18;
            this.txtEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(556, 122);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(118, 20);
            this.txtCidade.TabIndex = 20;
            this.txtCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(124, 122);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(118, 20);
            this.txtBairro.TabIndex = 19;
            this.txtBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(124, 96);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(379, 20);
            this.txtEndereco.TabIndex = 17;
            this.txtEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fone";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(275, 70);
            this.txtFone.Mask = "(99)0000-0000";
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(81, 20);
            this.txtFone.TabIndex = 16;
            this.txtFone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(124, 70);
            this.txtCpf.Mask = "999,999,999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(84, 20);
            this.txtCpf.TabIndex = 15;
            this.txtCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(56, 73);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(23, 13);
            this.lbCpf.TabIndex = 8;
            this.lbCpf.Text = "Cpf";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(556, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(74, 20);
            this.txtID.TabIndex = 14;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(510, 47);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 8;
            this.lbCodigo.Text = "Codigo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(124, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(379, 20);
            this.txtNome.TabIndex = 13;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(600, 314);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // FrmAlunoCadastra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 349);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAlunoCadastra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastra Aluno";
            this.Load += new System.EventHandler(this.FrmAlunoCadastra_Load);
            this.panel1.ResumeLayout(false);
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbAlteradopor;
        private System.Windows.Forms.TextBox txtAlteradoPor;
        private System.Windows.Forms.Label lbDataalteracao;
        private System.Windows.Forms.Label lbcadastradopor;
        private System.Windows.Forms.TextBox txtCadastradoPor;
        private System.Windows.Forms.Label lbdatacadastro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpBox;
        private System.Windows.Forms.MaskedTextBox txtAlteradodata;
        private System.Windows.Forms.MaskedTextBox txtDataDia;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFone;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtpai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmae;
        private System.Windows.Forms.Label label7;
    }
}