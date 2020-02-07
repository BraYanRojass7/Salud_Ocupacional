namespace App_SG_SST_V1_5.Src.Frm
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.txt_desc_est = new System.Windows.Forms.TextBox();
            this.lbl_desc_est = new System.Windows.Forms.Label();
            this.cmb_est = new System.Windows.Forms.ComboBox();
            this.lbl_est = new System.Windows.Forms.Label();
            this.cmb_mod_est = new System.Windows.Forms.ComboBox();
            this.lbl_mod_est = new System.Windows.Forms.Label();
            this.cmb_ciclo = new System.Windows.Forms.ComboBox();
            this.lbl_ciclo = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_txt_tit_2 = new System.Windows.Forms.Label();
            this.lbl_txt_tit_1 = new System.Windows.Forms.Label();
            this.pic_logo_gu = new System.Windows.Forms.PictureBox();
            this.pic_Salir = new System.Windows.Forms.PictureBox();
            this.pic_Inspec = new System.Windows.Forms.PictureBox();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_gu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Inspec)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_desc_est
            // 
            this.txt_desc_est.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_desc_est.Location = new System.Drawing.Point(518, 307);
            this.txt_desc_est.Multiline = true;
            this.txt_desc_est.Name = "txt_desc_est";
            this.txt_desc_est.ReadOnly = true;
            this.txt_desc_est.Size = new System.Drawing.Size(341, 138);
            this.txt_desc_est.TabIndex = 32;
            this.txt_desc_est.TabStop = false;
            // 
            // lbl_desc_est
            // 
            this.lbl_desc_est.AutoSize = true;
            this.lbl_desc_est.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc_est.ForeColor = System.Drawing.Color.White;
            this.lbl_desc_est.Location = new System.Drawing.Point(513, 278);
            this.lbl_desc_est.Name = "lbl_desc_est";
            this.lbl_desc_est.Size = new System.Drawing.Size(346, 25);
            this.lbl_desc_est.TabIndex = 31;
            this.lbl_desc_est.Text = "DESCRIPCIÓN DEL ESTANDAR";
            // 
            // cmb_est
            // 
            this.cmb_est.BackColor = System.Drawing.Color.White;
            this.cmb_est.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_est.FormattingEnabled = true;
            this.cmb_est.Location = new System.Drawing.Point(604, 254);
            this.cmb_est.Name = "cmb_est";
            this.cmb_est.Size = new System.Drawing.Size(159, 21);
            this.cmb_est.TabIndex = 30;
            this.cmb_est.SelectedIndexChanged += new System.EventHandler(this.cmb_est_SelectedIndexChanged_1);
            // 
            // lbl_est
            // 
            this.lbl_est.AutoSize = true;
            this.lbl_est.BackColor = System.Drawing.Color.Transparent;
            this.lbl_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_est.ForeColor = System.Drawing.Color.White;
            this.lbl_est.Location = new System.Drawing.Point(599, 226);
            this.lbl_est.Name = "lbl_est";
            this.lbl_est.Size = new System.Drawing.Size(164, 25);
            this.lbl_est.TabIndex = 29;
            this.lbl_est.Text = "ESTANDARES";
            // 
            // cmb_mod_est
            // 
            this.cmb_mod_est.BackColor = System.Drawing.Color.White;
            this.cmb_mod_est.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mod_est.FormattingEnabled = true;
            this.cmb_mod_est.Location = new System.Drawing.Point(106, 326);
            this.cmb_mod_est.Name = "cmb_mod_est";
            this.cmb_mod_est.Size = new System.Drawing.Size(285, 21);
            this.cmb_mod_est.TabIndex = 28;
            this.cmb_mod_est.SelectedIndexChanged += new System.EventHandler(this.cmb_mod_est_SelectedIndexChanged_1);
            // 
            // lbl_mod_est
            // 
            this.lbl_mod_est.AutoSize = true;
            this.lbl_mod_est.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mod_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mod_est.ForeColor = System.Drawing.Color.White;
            this.lbl_mod_est.Location = new System.Drawing.Point(103, 298);
            this.lbl_mod_est.Name = "lbl_mod_est";
            this.lbl_mod_est.Size = new System.Drawing.Size(290, 25);
            this.lbl_mod_est.TabIndex = 27;
            this.lbl_mod_est.Text = "MODULO DEL ESTANDAR";
            // 
            // cmb_ciclo
            // 
            this.cmb_ciclo.BackColor = System.Drawing.Color.White;
            this.cmb_ciclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ciclo.FormattingEnabled = true;
            this.cmb_ciclo.Items.AddRange(new object[] {
            "Seleccionar",
            "I. Planear"});
            this.cmb_ciclo.Location = new System.Drawing.Point(179, 254);
            this.cmb_ciclo.Name = "cmb_ciclo";
            this.cmb_ciclo.Size = new System.Drawing.Size(121, 21);
            this.cmb_ciclo.TabIndex = 26;
            this.cmb_ciclo.SelectedIndexChanged += new System.EventHandler(this.cmb_ciclo_SelectedIndexChanged);
            // 
            // lbl_ciclo
            // 
            this.lbl_ciclo.AutoSize = true;
            this.lbl_ciclo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ciclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ciclo.ForeColor = System.Drawing.Color.White;
            this.lbl_ciclo.Location = new System.Drawing.Point(199, 226);
            this.lbl_ciclo.Name = "lbl_ciclo";
            this.lbl_ciclo.Size = new System.Drawing.Size(80, 25);
            this.lbl_ciclo.TabIndex = 25;
            this.lbl_ciclo.Text = "CICLO";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header.Controls.Add(this.lbl_txt_tit_2);
            this.pnl_header.Controls.Add(this.lbl_txt_tit_1);
            this.pnl_header.Controls.Add(this.pic_logo_gu);
            this.pnl_header.Location = new System.Drawing.Point(44, 20);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(880, 182);
            this.pnl_header.TabIndex = 24;
            // 
            // lbl_txt_tit_2
            // 
            this.lbl_txt_tit_2.AutoSize = true;
            this.lbl_txt_tit_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_txt_tit_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_tit_2.ForeColor = System.Drawing.Color.White;
            this.lbl_txt_tit_2.Location = new System.Drawing.Point(489, 98);
            this.lbl_txt_tit_2.Name = "lbl_txt_tit_2";
            this.lbl_txt_tit_2.Size = new System.Drawing.Size(279, 46);
            this.lbl_txt_tit_2.TabIndex = 2;
            this.lbl_txt_tit_2.Text = "SG-SST 2019";
            // 
            // lbl_txt_tit_1
            // 
            this.lbl_txt_tit_1.AutoSize = true;
            this.lbl_txt_tit_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_txt_tit_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_tit_1.ForeColor = System.Drawing.Color.White;
            this.lbl_txt_tit_1.Location = new System.Drawing.Point(362, 27);
            this.lbl_txt_tit_1.Name = "lbl_txt_tit_1";
            this.lbl_txt_tit_1.Size = new System.Drawing.Size(495, 46);
            this.lbl_txt_tit_1.TabIndex = 1;
            this.lbl_txt_tit_1.Text = "ESTÁNDARES MÍNIMOS";
            // 
            // pic_logo_gu
            // 
            this.pic_logo_gu.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo_gu.Image = global::App_SG_SST_V1_5.Properties.Resources.GU_Blanco;
            this.pic_logo_gu.Location = new System.Drawing.Point(26, 27);
            this.pic_logo_gu.Name = "pic_logo_gu";
            this.pic_logo_gu.Size = new System.Drawing.Size(330, 126);
            this.pic_logo_gu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_logo_gu.TabIndex = 0;
            this.pic_logo_gu.TabStop = false;
            // 
            // pic_Salir
            // 
            this.pic_Salir.BackColor = System.Drawing.Color.Transparent;
            this.pic_Salir.Image = global::App_SG_SST_V1_5.Properties.Resources.SALIR_BOTON1;
            this.pic_Salir.Location = new System.Drawing.Point(124, 382);
            this.pic_Salir.Name = "pic_Salir";
            this.pic_Salir.Size = new System.Drawing.Size(100, 34);
            this.pic_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Salir.TabIndex = 36;
            this.pic_Salir.TabStop = false;
            this.pic_Salir.Click += new System.EventHandler(this.pic_Salir_Click);
            // 
            // pic_Inspec
            // 
            this.pic_Inspec.BackColor = System.Drawing.Color.Transparent;
            this.pic_Inspec.Image = global::App_SG_SST_V1_5.Properties.Resources.BOTON_INSPECCIONAR1;
            this.pic_Inspec.Location = new System.Drawing.Point(230, 377);
            this.pic_Inspec.Name = "pic_Inspec";
            this.pic_Inspec.Size = new System.Drawing.Size(116, 43);
            this.pic_Inspec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Inspec.TabIndex = 38;
            this.pic_Inspec.TabStop = false;
            this.pic_Inspec.Click += new System.EventHandler(this.pic_Inspec_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::App_SG_SST_V1_5.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 464);
            this.Controls.Add(this.pic_Inspec);
            this.Controls.Add(this.pic_Salir);
            this.Controls.Add(this.txt_desc_est);
            this.Controls.Add(this.lbl_desc_est);
            this.Controls.Add(this.cmb_est);
            this.Controls.Add(this.lbl_est);
            this.Controls.Add(this.cmb_mod_est);
            this.Controls.Add(this.lbl_mod_est);
            this.Controls.Add(this.cmb_ciclo);
            this.Controls.Add(this.lbl_ciclo);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_menu_FormClosing);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_gu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Inspec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_desc_est;
        private System.Windows.Forms.Label lbl_desc_est;
        private System.Windows.Forms.ComboBox cmb_est;
        private System.Windows.Forms.Label lbl_est;
        private System.Windows.Forms.ComboBox cmb_mod_est;
        private System.Windows.Forms.Label lbl_mod_est;
        private System.Windows.Forms.ComboBox cmb_ciclo;
        private System.Windows.Forms.Label lbl_ciclo;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_txt_tit_2;
        private System.Windows.Forms.Label lbl_txt_tit_1;
        private System.Windows.Forms.PictureBox pic_logo_gu;
        private System.Windows.Forms.PictureBox pic_Salir;
        private System.Windows.Forms.PictureBox pic_Inspec;
    }
}