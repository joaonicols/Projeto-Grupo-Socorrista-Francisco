namespace GPSFrancisco
{
    partial class frmGerenciarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarUsuarios));
            this.gpbInformacoesUsuario = new System.Windows.Forms.GroupBox();
            this.cbbUsuariosCadastrados = new System.Windows.Forms.ComboBox();
            this.lblUsuariosCadastrados = new System.Windows.Forms.Label();
            this.btnErro = new System.Windows.Forms.Button();
            this.btnChecked = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuário = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtValidaSenha = new System.Windows.Forms.TextBox();
            this.lblValidaSenha = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbInformacoesUsuario.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacoesUsuario
            // 
            this.gpbInformacoesUsuario.Controls.Add(this.cbbUsuariosCadastrados);
            this.gpbInformacoesUsuario.Controls.Add(this.lblUsuariosCadastrados);
            this.gpbInformacoesUsuario.Controls.Add(this.btnErro);
            this.gpbInformacoesUsuario.Controls.Add(this.btnChecked);
            this.gpbInformacoesUsuario.Controls.Add(this.txtUsuario);
            this.gpbInformacoesUsuario.Controls.Add(this.lblUsuário);
            this.gpbInformacoesUsuario.Controls.Add(this.txtSenha);
            this.gpbInformacoesUsuario.Controls.Add(this.lblSenha);
            this.gpbInformacoesUsuario.Controls.Add(this.txtValidaSenha);
            this.gpbInformacoesUsuario.Controls.Add(this.lblValidaSenha);
            this.gpbInformacoesUsuario.Controls.Add(this.txtCodigo);
            this.gpbInformacoesUsuario.Controls.Add(this.lblCódigo);
            this.gpbInformacoesUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoesUsuario.Location = new System.Drawing.Point(26, 22);
            this.gpbInformacoesUsuario.Name = "gpbInformacoesUsuario";
            this.gpbInformacoesUsuario.Size = new System.Drawing.Size(888, 379);
            this.gpbInformacoesUsuario.TabIndex = 0;
            this.gpbInformacoesUsuario.TabStop = false;
            this.gpbInformacoesUsuario.Text = "Informações do Usuário";
            // 
            // cbbUsuariosCadastrados
            // 
            this.cbbUsuariosCadastrados.FormattingEnabled = true;
            this.cbbUsuariosCadastrados.Location = new System.Drawing.Point(614, 62);
            this.cbbUsuariosCadastrados.Name = "cbbUsuariosCadastrados";
            this.cbbUsuariosCadastrados.Size = new System.Drawing.Size(199, 28);
            this.cbbUsuariosCadastrados.TabIndex = 10;
            this.cbbUsuariosCadastrados.Click += new System.EventHandler(this.cbbUsuariosCadastrados_Click);
            // 
            // lblUsuariosCadastrados
            // 
            this.lblUsuariosCadastrados.AutoSize = true;
            this.lblUsuariosCadastrados.Location = new System.Drawing.Point(623, 39);
            this.lblUsuariosCadastrados.Name = "lblUsuariosCadastrados";
            this.lblUsuariosCadastrados.Size = new System.Drawing.Size(171, 20);
            this.lblUsuariosCadastrados.TabIndex = 9;
            this.lblUsuariosCadastrados.Text = "Usuários Cadastrados:";
            // 
            // btnErro
            // 
            this.btnErro.FlatAppearance.BorderSize = 0;
            this.btnErro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErro.Image = ((System.Drawing.Image)(resources.GetObject("btnErro.Image")));
            this.btnErro.Location = new System.Drawing.Point(434, 250);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(36, 31);
            this.btnErro.TabIndex = 8;
            this.btnErro.UseVisualStyleBackColor = true;
            this.btnErro.Visible = false;
            // 
            // btnChecked
            // 
            this.btnChecked.FlatAppearance.BorderSize = 0;
            this.btnChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecked.Image = ((System.Drawing.Image)(resources.GetObject("btnChecked.Image")));
            this.btnChecked.Location = new System.Drawing.Point(434, 251);
            this.btnChecked.Name = "btnChecked";
            this.btnChecked.Size = new System.Drawing.Size(36, 30);
            this.btnChecked.TabIndex = 7;
            this.btnChecked.UseVisualStyleBackColor = true;
            this.btnChecked.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(27, 159);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(145, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblUsuário
            // 
            this.lblUsuário.AutoSize = true;
            this.lblUsuário.Location = new System.Drawing.Point(35, 136);
            this.lblUsuário.Name = "lblUsuário";
            this.lblUsuário.Size = new System.Drawing.Size(68, 20);
            this.lblUsuário.TabIndex = 6;
            this.lblUsuário.Text = "Usuário:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(27, 255);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(173, 25);
            this.txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(35, 232);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // txtValidaSenha
            // 
            this.txtValidaSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtValidaSenha.Location = new System.Drawing.Point(266, 255);
            this.txtValidaSenha.MaxLength = 12;
            this.txtValidaSenha.Name = "txtValidaSenha";
            this.txtValidaSenha.PasswordChar = 'l';
            this.txtValidaSenha.Size = new System.Drawing.Size(162, 25);
            this.txtValidaSenha.TabIndex = 4;
            this.txtValidaSenha.TextChanged += new System.EventHandler(this.txtValidaSenha_TextChanged);
            // 
            // lblValidaSenha
            // 
            this.lblValidaSenha.AutoSize = true;
            this.lblValidaSenha.Location = new System.Drawing.Point(272, 232);
            this.lblValidaSenha.Name = "lblValidaSenha";
            this.lblValidaSenha.Size = new System.Drawing.Size(113, 20);
            this.lblValidaSenha.TabIndex = 2;
            this.lblValidaSenha.Text = "Validar Senha:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(27, 64);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(145, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Location = new System.Drawing.Point(35, 41);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(63, 20);
            this.lblCódigo.TabIndex = 0;
            this.lblCódigo.Text = "Código:";
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(6, 426);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(1061, 107);
            this.pnlCRUD.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(914, 30);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(134, 58);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(774, 30);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 58);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(634, 30);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(134, 58);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(494, 30);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(134, 58);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(342, 30);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(146, 58);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(172, 30);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(164, 58);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(6, 30);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(160, 58);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmGerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 546);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.gpbInformacoesUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarUsuarios";
            this.Text = "GPSFrancisco - Gerenciar Usuários";
            this.gpbInformacoesUsuario.ResumeLayout(false);
            this.gpbInformacoesUsuario.PerformLayout();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacoesUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuário;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtValidaSenha;
        private System.Windows.Forms.Label lblValidaSenha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnChecked;
        private System.Windows.Forms.Button btnErro;
        private System.Windows.Forms.ComboBox cbbUsuariosCadastrados;
        private System.Windows.Forms.Label lblUsuariosCadastrados;
    }
}