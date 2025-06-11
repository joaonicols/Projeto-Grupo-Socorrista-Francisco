namespace GPSFrancisco
{
    partial class frmCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendario));
            this.cldCalendario = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFormatLong = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblFormatShort = new System.Windows.Forms.Label();
            this.lblFormatTime = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.lblFormatCustom = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.btnCarregarData = new System.Windows.Forms.Button();
            this.txtCalendario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cldCalendario
            // 
            this.cldCalendario.Location = new System.Drawing.Point(324, 171);
            this.cldCalendario.Name = "cldCalendario";
            this.cldCalendario.TabIndex = 0;
            this.cldCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cldCalendario_DateChanged);
            this.cldCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldCalendario_DateSelected);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblFormatLong
            // 
            this.lblFormatLong.AutoSize = true;
            this.lblFormatLong.Location = new System.Drawing.Point(44, 66);
            this.lblFormatLong.Name = "lblFormatLong";
            this.lblFormatLong.Size = new System.Drawing.Size(72, 13);
            this.lblFormatLong.TabIndex = 2;
            this.lblFormatLong.Text = "Format - Long";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(47, 171);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // lblFormatShort
            // 
            this.lblFormatShort.AutoSize = true;
            this.lblFormatShort.Location = new System.Drawing.Point(44, 145);
            this.lblFormatShort.Name = "lblFormatShort";
            this.lblFormatShort.Size = new System.Drawing.Size(73, 13);
            this.lblFormatShort.TabIndex = 4;
            this.lblFormatShort.Text = "Format - Short";
            // 
            // lblFormatTime
            // 
            this.lblFormatTime.AutoSize = true;
            this.lblFormatTime.Location = new System.Drawing.Point(44, 252);
            this.lblFormatTime.Name = "lblFormatTime";
            this.lblFormatTime.Size = new System.Drawing.Size(71, 13);
            this.lblFormatTime.TabIndex = 6;
            this.lblFormatTime.Text = "Format - Time";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(47, 278);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 5;
            // 
            // lblFormatCustom
            // 
            this.lblFormatCustom.AutoSize = true;
            this.lblFormatCustom.Location = new System.Drawing.Point(44, 347);
            this.lblFormatCustom.Name = "lblFormatCustom";
            this.lblFormatCustom.Size = new System.Drawing.Size(83, 13);
            this.lblFormatCustom.TabIndex = 8;
            this.lblFormatCustom.Text = "Format - Custom";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(47, 373);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 7;
            // 
            // btnCarregarData
            // 
            this.btnCarregarData.Location = new System.Drawing.Point(324, 377);
            this.btnCarregarData.Name = "btnCarregarData";
            this.btnCarregarData.Size = new System.Drawing.Size(221, 26);
            this.btnCarregarData.TabIndex = 9;
            this.btnCarregarData.Text = "Carregar Data";
            this.btnCarregarData.UseVisualStyleBackColor = true;
            this.btnCarregarData.Click += new System.EventHandler(this.btnCarregarData_Click);
            // 
            // txtCalendario
            // 
            this.txtCalendario.Location = new System.Drawing.Point(331, 351);
            this.txtCalendario.Name = "txtCalendario";
            this.txtCalendario.Size = new System.Drawing.Size(203, 20);
            this.txtCalendario.TabIndex = 10;
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtCalendario);
            this.Controls.Add(this.btnCarregarData);
            this.Controls.Add(this.lblFormatCustom);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.lblFormatTime);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.lblFormatShort);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblFormatLong);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cldCalendario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalendario";
            this.Text = "GPSFrancisco - Calendário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cldCalendario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFormatLong;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblFormatShort;
        private System.Windows.Forms.Label lblFormatTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lblFormatCustom;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button btnCarregarData;
        private System.Windows.Forms.TextBox txtCalendario;
    }
}