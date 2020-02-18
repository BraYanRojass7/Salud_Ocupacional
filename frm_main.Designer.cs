namespace App_SG_SST_V1_5
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_login = new System.Windows.Forms.Panel();
            this.ppic_ingresar = new System.Windows.Forms.PictureBox();
            this.pic_boton = new System.Windows.Forms.PictureBox();
            this.lbl_tit_user = new System.Windows.Forms.Label();
            this.pnl_texts = new System.Windows.Forms.Panel();
            this.chk_reco_contra = new System.Windows.Forms.CheckBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppic_ingresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_boton)).BeginInit();
            this.pnl_texts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.Transparent;
            this.pnl_login.Controls.Add(this.ppic_ingresar);
            this.pnl_login.Controls.Add(this.pic_boton);
            this.pnl_login.Controls.Add(this.lbl_tit_user);
            this.pnl_login.Controls.Add(this.pnl_texts);
            this.pnl_login.Controls.Add(this.pic_user);
            this.pnl_login.Location = new System.Drawing.Point(72, 139);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(256, 376);
            this.pnl_login.TabIndex = 8;
            // 
            // ppic_ingresar
            // 
            this.ppic_ingresar.BackColor = System.Drawing.Color.Transparent;
            this.ppic_ingresar.Image = global::App_SG_SST_V1_5.Properties.Resources.INGRESAR_BOTON;
            this.ppic_ingresar.Location = new System.Drawing.Point(130, 318);
            this.ppic_ingresar.Name = "ppic_ingresar";
            this.ppic_ingresar.Size = new System.Drawing.Size(89, 31);
            this.ppic_ingresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ppic_ingresar.TabIndex = 12;
            this.ppic_ingresar.TabStop = false;
            this.ppic_ingresar.Click += new System.EventHandler(this.ppic_ingresar_Click);
            // 
            // pic_boton
            // 
            this.pic_boton.BackColor = System.Drawing.Color.Transparent;
            this.pic_boton.Image = global::App_SG_SST_V1_5.Properties.Resources.SALIR_BOTON1;
            this.pic_boton.Location = new System.Drawing.Point(35, 318);
            this.pic_boton.Name = "pic_boton";
            this.pic_boton.Size = new System.Drawing.Size(89, 31);
            this.pic_boton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_boton.TabIndex = 10;
            this.pic_boton.TabStop = false;
            this.pic_boton.Click += new System.EventHandler(this.pic_boton_Click);
            // 
            // lbl_tit_user
            // 
            this.lbl_tit_user.AutoSize = true;
            this.lbl_tit_user.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tit_user.ForeColor = System.Drawing.Color.White;
            this.lbl_tit_user.Location = new System.Drawing.Point(95, 118);
            this.lbl_tit_user.Name = "lbl_tit_user";
            this.lbl_tit_user.Size = new System.Drawing.Size(68, 24);
            this.lbl_tit_user.TabIndex = 5;
            this.lbl_tit_user.Text = "HSEQ";
            // 
            // pnl_texts
            // 
            this.pnl_texts.BackColor = System.Drawing.Color.Transparent;
            this.pnl_texts.Controls.Add(this.txt_user);
            this.pnl_texts.Controls.Add(this.chk_reco_contra);
            this.pnl_texts.Controls.Add(this.lbl_pass);
            this.pnl_texts.Controls.Add(this.lbl_user);
            this.pnl_texts.Controls.Add(this.txt_pass);
            this.pnl_texts.Location = new System.Drawing.Point(36, 149);
            this.pnl_texts.Name = "pnl_texts";
            this.pnl_texts.Size = new System.Drawing.Size(183, 147);
            this.pnl_texts.TabIndex = 2;
            // 
            // chk_reco_contra
            // 
            this.chk_reco_contra.AutoSize = true;
            this.chk_reco_contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_reco_contra.ForeColor = System.Drawing.Color.White;
            this.chk_reco_contra.Location = new System.Drawing.Point(16, 118);
            this.chk_reco_contra.Name = "chk_reco_contra";
            this.chk_reco_contra.Size = new System.Drawing.Size(150, 20);
            this.chk_reco_contra.TabIndex = 3;
            this.chk_reco_contra.Text = "Recordar Usuario";
            this.chk_reco_contra.UseVisualStyleBackColor = true;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_pass.Location = new System.Drawing.Point(41, 64);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(98, 16);
            this.lbl_pass.TabIndex = 5;
            this.lbl_pass.Text = "Contraseña";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(57, 13);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(71, 16);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "Usuario";
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(15, 87);
            this.txt_pass.MaxLength = 15;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(154, 17);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(16, 38);
            this.txt_user.MaxLength = 15;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(154, 17);
            this.txt_user.TabIndex = 1;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_user
            // 
            this.pic_user.Image = global::App_SG_SST_V1_5.Properties.Resources.user2;
            this.pic_user.Location = new System.Drawing.Point(81, 19);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(96, 96);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_user.TabIndex = 2;
            this.pic_user.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::App_SG_SST_V1_5.Properties.Resources.GU_Blanco;
            this.pictureBox1.Location = new System.Drawing.Point(72, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::App_SG_SST_V1_5.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppic_ingresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_boton)).EndInit();
            this.pnl_texts.ResumeLayout(false);
            this.pnl_texts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label lbl_tit_user;
        private System.Windows.Forms.Panel pnl_texts;
        private System.Windows.Forms.CheckBox chk_reco_contra;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.PictureBox pic_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_boton;
        private System.Windows.Forms.PictureBox ppic_ingresar;
    }
}