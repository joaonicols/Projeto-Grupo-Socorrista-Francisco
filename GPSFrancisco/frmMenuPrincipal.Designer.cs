namespace GPSFrancisco
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnVoluntarios = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnUsuários = new System.Windows.Forms.Button();
            this.btnAtribuicoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoluntarios
            // 
            this.btnVoluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoluntarios.Image = ((System.Drawing.Image)(resources.GetObject("btnVoluntarios.Image")));
            this.btnVoluntarios.Location = new System.Drawing.Point(25, 12);
            this.btnVoluntarios.Name = "btnVoluntarios";
            this.btnVoluntarios.Size = new System.Drawing.Size(199, 237);
            this.btnVoluntarios.TabIndex = 0;
            this.btnVoluntarios.Text = "  V&oluntários";
            this.btnVoluntarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoluntarios.UseVisualStyleBackColor = true;
            this.btnVoluntarios.Click += new System.EventHandler(this.btnVoluntarios_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(652, 528);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 64);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // btnUsuários
            // 
            this.btnUsuários.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuários.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuários.Image")));
            this.btnUsuários.Location = new System.Drawing.Point(455, 12);
            this.btnUsuários.Name = "btnUsuários";
            this.btnUsuários.Size = new System.Drawing.Size(199, 237);
            this.btnUsuários.TabIndex = 2;
            this.btnUsuários.Text = "&Usuários";
            this.btnUsuários.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuários.UseVisualStyleBackColor = true;
            this.btnUsuários.Click += new System.EventHandler(this.btnUsuários_Click);
            // 
            // btnAtribuicoes
            // 
            this.btnAtribuicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtribuicoes.Image = ((System.Drawing.Image)(resources.GetObject("btnAtribuicoes.Image")));
            this.btnAtribuicoes.Location = new System.Drawing.Point(240, 12);
            this.btnAtribuicoes.Name = "btnAtribuicoes";
            this.btnAtribuicoes.Size = new System.Drawing.Size(199, 237);
            this.btnAtribuicoes.TabIndex = 3;
            this.btnAtribuicoes.Text = "&Atribuições";
            this.btnAtribuicoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtribuicoes.UseVisualStyleBackColor = true;
            this.btnAtribuicoes.Click += new System.EventHandler(this.btnAtribuicoes_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 622);
            this.Controls.Add(this.btnAtribuicoes);
            this.Controls.Add(this.btnUsuários);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVoluntarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.Text = "GPSFrancisco - Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoluntarios;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnUsuários;
        private System.Windows.Forms.Button btnAtribuicoes;
    }
}