namespace Escolar_HEEF.Frms
{
    partial class FrmLoginSenha
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSistemalogin = new System.Windows.Forms.Label();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtgboxloginsenha = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSistemalogin);
            this.panel1.Controls.Add(this.txtBoxSenha);
            this.panel1.Controls.Add(this.txtBoxUsuario);
            this.panel1.Controls.Add(this.lbSenha);
            this.panel1.Controls.Add(this.lbUsuario);
            this.panel1.Controls.Add(this.txtgboxloginsenha);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnLogar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 353);
            this.panel1.TabIndex = 0;
            // 
            // lbSistemalogin
            // 
            this.lbSistemalogin.AutoSize = true;
            this.lbSistemalogin.BackColor = System.Drawing.Color.White;
            this.lbSistemalogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSistemalogin.Location = new System.Drawing.Point(44, 23);
            this.lbSistemalogin.Name = "lbSistemalogin";
            this.lbSistemalogin.Size = new System.Drawing.Size(140, 31);
            this.lbSistemalogin.TabIndex = 22;
            this.lbSistemalogin.Text = "OsSystem";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(242, 205);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSenha.TabIndex = 2;
            this.txtBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressionarEnterSenha);
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(242, 132);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUsuario.TabIndex = 0;
            this.txtBoxUsuario.Click += new System.EventHandler(this.txtBoxUsuario_Click);
            this.txtBoxUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter_Press);
            this.txtBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_Caracteres);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.White;
            this.lbSenha.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(244, 189);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(37, 16);
            this.lbSenha.TabIndex = 21;
            this.lbSenha.Text = "Senha";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.White;
            this.lbUsuario.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(244, 116);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(44, 16);
            this.lbUsuario.TabIndex = 20;
            this.lbUsuario.Text = "Usuário";
            // 
            // txtgboxloginsenha
            // 
            this.txtgboxloginsenha.BackColor = System.Drawing.Color.White;
            this.txtgboxloginsenha.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgboxloginsenha.Location = new System.Drawing.Point(195, 83);
            this.txtgboxloginsenha.Name = "txtgboxloginsenha";
            this.txtgboxloginsenha.Size = new System.Drawing.Size(215, 178);
            this.txtgboxloginsenha.TabIndex = 7;
            this.txtgboxloginsenha.TabStop = false;
            this.txtgboxloginsenha.Text = "Digite Seu Login de Usuário e Senha";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(254, 318);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(335, 318);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 30;
            this.btnLogar.Text = "&Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Escolar_HEEF.Properties.Resources.LoginSenha;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 353);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLoginSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 353);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoginSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Usuário Senha";
            this.Load += new System.EventHandler(this.LoginSenha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.GroupBox txtgboxloginsenha;
        private System.Windows.Forms.Label lbSistemalogin;
    }
}