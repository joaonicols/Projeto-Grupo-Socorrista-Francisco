namespace GPSFrancisco
{
    partial class frmGerenciarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarProdutos));
            this.lblData = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pcbFotoVoluntario = new System.Windows.Forms.PictureBox();
            this.cbbUnidade = new System.Windows.Forms.ComboBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.dtpHoras = new System.Windows.Forms.DateTimePicker();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ofdCarregar = new System.Windows.Forms.OpenFileDialog();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.gpbInformacoesVoluntarios = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.pcbCodigoBarras = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoVoluntario)).BeginInit();
            this.pnlCRUD.SuspendLayout();
            this.gpbInformacoesVoluntarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCodigoBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(390, 201);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(131, 20);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Hora da Entrada:";
            // 
            // btnInserir
            // 
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.Location = new System.Drawing.Point(903, 128);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(55, 37);
            this.btnInserir.TabIndex = 27;
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // pcbFotoVoluntario
            // 
            this.pcbFotoVoluntario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbFotoVoluntario.Location = new System.Drawing.Point(1002, 25);
            this.pcbFotoVoluntario.Name = "pcbFotoVoluntario";
            this.pcbFotoVoluntario.Size = new System.Drawing.Size(203, 170);
            this.pcbFotoVoluntario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotoVoluntario.TabIndex = 24;
            this.pcbFotoVoluntario.TabStop = false;
            // 
            // cbbUnidade
            // 
            this.cbbUnidade.FormattingEnabled = true;
            this.cbbUnidade.Location = new System.Drawing.Point(758, 133);
            this.cbbUnidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbUnidade.Name = "cbbUnidade";
            this.cbbUnidade.Size = new System.Drawing.Size(138, 28);
            this.cbbUnidade.TabIndex = 11;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(754, 108);
            this.lblUnidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(69, 20);
            this.lblUnidade.TabIndex = 22;
            this.lblUnidade.Text = "Unidade";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(587, 133);
            this.txtLote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLote.MaxLength = 50;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(145, 26);
            this.txtLote.TabIndex = 9;
            // 
            // dtpHoras
            // 
            this.dtpHoras.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoras.Location = new System.Drawing.Point(559, 229);
            this.dtpHoras.Name = "dtpHoras";
            this.dtpHoras.Size = new System.Drawing.Size(127, 26);
            this.dtpHoras.TabIndex = 14;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpData.Location = new System.Drawing.Point(389, 229);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(116, 26);
            this.dtpData.TabIndex = 13;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(555, 201);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(71, 20);
            this.lblHoras.TabIndex = 13;
            this.lblHoras.Text = "Validade";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(213, 201);
            this.lblDataEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(131, 20);
            this.lblDataEntrada.TabIndex = 8;
            this.lblDataEntrada.Text = "Data de Entrada:";
            this.lblDataEntrada.Click += new System.EventHandler(this.lblDataEntrada_Click);
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(583, 108);
            this.lblLote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(45, 20);
            this.lblLote.TabIndex = 15;
            this.lblLote.Text = "Lote:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(201, 30);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(191, 61);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(23, 29);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(187, 61);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // ofdCarregar
            // 
            this.ofdCarregar.FileName = "openFileDialog1";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(28, 133);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(514, 26);
            this.txtDescricao.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(1066, 30);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(156, 61);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(903, 30);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(156, 61);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(740, 30);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(156, 61);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(576, 30);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(156, 61);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
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
            this.pnlCRUD.Location = new System.Drawing.Point(3, 383);
            this.pnlCRUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(1230, 93);
            this.pnlCRUD.TabIndex = 5;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(399, 30);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(170, 61);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(23, 110);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Enabled = false;
            this.txtCodigoBarras.Location = new System.Drawing.Point(28, 54);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoBarras.MaxLength = 50;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(341, 26);
            this.txtCodigoBarras.TabIndex = 1;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(24, 31);
            this.lblCodigoBarras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(136, 20);
            this.lblCodigoBarras.TabIndex = 0;
            this.lblCodigoBarras.Text = "Código de Barras:";
            // 
            // gpbInformacoesVoluntarios
            // 
            this.gpbInformacoesVoluntarios.Controls.Add(this.label1);
            this.gpbInformacoesVoluntarios.Controls.Add(this.pcbCodigoBarras);
            this.gpbInformacoesVoluntarios.Controls.Add(this.dtpHoraEntrada);
            this.gpbInformacoesVoluntarios.Controls.Add(this.txtQuantidade);
            this.gpbInformacoesVoluntarios.Controls.Add(this.lblQuantidade);
            this.gpbInformacoesVoluntarios.Controls.Add(this.btnInserir);
            this.gpbInformacoesVoluntarios.Controls.Add(this.pcbFotoVoluntario);
            this.gpbInformacoesVoluntarios.Controls.Add(this.dtpHoras);
            this.gpbInformacoesVoluntarios.Controls.Add(this.lblHoras);
            this.gpbInformacoesVoluntarios.Controls.Add(this.cbbUnidade);
            this.gpbInformacoesVoluntarios.Controls.Add(this.dtpData);
            this.gpbInformacoesVoluntarios.Controls.Add(this.lblUnidade);
            this.gpbInformacoesVoluntarios.Controls.Add(this.lblData);
            this.gpbInformacoesVoluntarios.Controls.Add(this.txtLote);
            this.gpbInformacoesVoluntarios.Controls.Add(this.lblLote);
            this.gpbInformacoesVoluntarios.Controls.Add(this.lblDataEntrada);
            this.gpbInformacoesVoluntarios.Controls.Add(this.txtDescricao);
            this.gpbInformacoesVoluntarios.Controls.Add(this.lblDescricao);
            this.gpbInformacoesVoluntarios.Controls.Add(this.txtCodigoBarras);
            this.gpbInformacoesVoluntarios.Controls.Add(this.lblCodigoBarras);
            this.gpbInformacoesVoluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoesVoluntarios.Location = new System.Drawing.Point(3, 31);
            this.gpbInformacoesVoluntarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbInformacoesVoluntarios.Name = "gpbInformacoesVoluntarios";
            this.gpbInformacoesVoluntarios.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbInformacoesVoluntarios.Size = new System.Drawing.Size(1210, 329);
            this.gpbInformacoesVoluntarios.TabIndex = 4;
            this.gpbInformacoesVoluntarios.TabStop = false;
            this.gpbInformacoesVoluntarios.Text = "Informações dos Produtos";
            this.gpbInformacoesVoluntarios.Enter += new System.EventHandler(this.gpbInformacoesVoluntarios_Enter);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(28, 229);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantidade.MaxLength = 50;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(145, 26);
            this.txtQuantidade.TabIndex = 28;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(24, 201);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 20);
            this.lblQuantidade.TabIndex = 29;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(216, 229);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(127, 26);
            this.dtpHoraEntrada.TabIndex = 30;
            // 
            // pcbCodigoBarras
            // 
            this.pcbCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbCodigoBarras.Location = new System.Drawing.Point(554, 48);
            this.pcbCodigoBarras.Name = "pcbCodigoBarras";
            this.pcbCodigoBarras.Size = new System.Drawing.Size(342, 36);
            this.pcbCodigoBarras.TabIndex = 31;
            this.pcbCodigoBarras.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Imagem código de barras:";
            // 
            // frmGerenciarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 504);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.gpbInformacoesVoluntarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSFrancisco - Gerenciar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoVoluntario)).EndInit();
            this.pnlCRUD.ResumeLayout(false);
            this.gpbInformacoesVoluntarios.ResumeLayout(false);
            this.gpbInformacoesVoluntarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCodigoBarras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.PictureBox pcbFotoVoluntario;
        private System.Windows.Forms.ComboBox cbbUnidade;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.DateTimePicker dtpHoras;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.OpenFileDialog ofdCarregar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.GroupBox gpbInformacoesVoluntarios;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.PictureBox pcbCodigoBarras;
        private System.Windows.Forms.Label label1;
    }
}