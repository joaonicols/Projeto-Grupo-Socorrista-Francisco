namespace GPSFrancisco
{
    partial class frmPesquisarVoluntarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarVoluntarios));
            this.gpbPesquisarPor = new System.Windows.Forms.GroupBox();
            this.ltbPesquisar = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.gpbPesquisarPor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisarPor
            // 
            this.gpbPesquisarPor.Controls.Add(this.ltbPesquisar);
            this.gpbPesquisarPor.Controls.Add(this.btnLimpar);
            this.gpbPesquisarPor.Controls.Add(this.btnPesquisar);
            this.gpbPesquisarPor.Controls.Add(this.txtDescricao);
            this.gpbPesquisarPor.Controls.Add(this.lblDescricao);
            this.gpbPesquisarPor.Controls.Add(this.rdbNome);
            this.gpbPesquisarPor.Controls.Add(this.rdbCodigo);
            this.gpbPesquisarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarPor.Location = new System.Drawing.Point(30, 12);
            this.gpbPesquisarPor.Name = "gpbPesquisarPor";
            this.gpbPesquisarPor.Size = new System.Drawing.Size(780, 296);
            this.gpbPesquisarPor.TabIndex = 1;
            this.gpbPesquisarPor.TabStop = false;
            this.gpbPesquisarPor.Text = "Pesquisar Por";
            // 
            // ltbPesquisar
            // 
            this.ltbPesquisar.FormattingEnabled = true;
            this.ltbPesquisar.ItemHeight = 20;
            this.ltbPesquisar.Location = new System.Drawing.Point(15, 165);
            this.ltbPesquisar.Name = "ltbPesquisar";
            this.ltbPesquisar.Size = new System.Drawing.Size(537, 104);
            this.ltbPesquisar.TabIndex = 4;
            this.ltbPesquisar.SelectedIndexChanged += new System.EventHandler(this.ltbPesquisar_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(579, 162);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(166, 107);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(579, 37);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(166, 107);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(135, 105);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(286, 26);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(36, 108);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(269, 47);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(69, 24);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(40, 47);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigo.TabIndex = 1;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // frmPesquisarVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 330);
            this.Controls.Add(this.gpbPesquisarPor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisarVoluntarios";
            this.Text = "GPSFrancisco - Pesquisar Voluntários";
            this.gpbPesquisarPor.ResumeLayout(false);
            this.gpbPesquisarPor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarPor;
        private System.Windows.Forms.ListBox ltbPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
    }
}