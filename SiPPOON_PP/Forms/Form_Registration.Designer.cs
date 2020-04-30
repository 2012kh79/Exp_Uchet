namespace SiPPOON_PP
{
    partial class Form_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Registration));
            this.btGlaz = new System.Windows.Forms.Button();
            this.btProv = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_Pochta = new System.Windows.Forms.Label();
            this.tb_Pochta = new System.Windows.Forms.TextBox();
            this.lbl_Imya = new System.Windows.Forms.Label();
            this.lblFam = new System.Windows.Forms.Label();
            this.tb_Fam = new System.Windows.Forms.TextBox();
            this.tbImya = new System.Windows.Forms.TextBox();
            this.tbRepeatPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btReg = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbAuth = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btGlaz
            // 
            this.btGlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGlaz.Location = new System.Drawing.Point(440, 245);
            this.btGlaz.Name = "btGlaz";
            this.btGlaz.Size = new System.Drawing.Size(23, 22);
            this.btGlaz.TabIndex = 60;
            this.btGlaz.UseVisualStyleBackColor = true;
            this.btGlaz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btGlaz_MouseDown);
            this.btGlaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btGlaz_MouseUp);
            // 
            // btProv
            // 
            this.btProv.Location = new System.Drawing.Point(202, 279);
            this.btProv.Name = "btProv";
            this.btProv.Size = new System.Drawing.Size(93, 32);
            this.btProv.TabIndex = 7;
            this.btProv.Text = "Проверить";
            this.btProv.UseVisualStyleBackColor = true;
            this.btProv.Click += new System.EventHandler(this.btProv_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.linkLabel1.Location = new System.Drawing.Point(101, 325);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(291, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Уже зарегистрировались? Авторизоваться";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_Pochta
            // 
            this.lbl_Pochta.AutoSize = true;
            this.lbl_Pochta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pochta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Pochta.Location = new System.Drawing.Point(77, 136);
            this.lbl_Pochta.Name = "lbl_Pochta";
            this.lbl_Pochta.Size = new System.Drawing.Size(61, 20);
            this.lbl_Pochta.TabIndex = 54;
            this.lbl_Pochta.Text = "Почта:";
            // 
            // tb_Pochta
            // 
            this.tb_Pochta.Location = new System.Drawing.Point(154, 138);
            this.tb_Pochta.Name = "tb_Pochta";
            this.tb_Pochta.Size = new System.Drawing.Size(280, 20);
            this.tb_Pochta.TabIndex = 3;
            // 
            // lbl_Imya
            // 
            this.lbl_Imya.AutoSize = true;
            this.lbl_Imya.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Imya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Imya.Location = new System.Drawing.Point(94, 100);
            this.lbl_Imya.Name = "lbl_Imya";
            this.lbl_Imya.Size = new System.Drawing.Size(44, 20);
            this.lbl_Imya.TabIndex = 52;
            this.lbl_Imya.Text = "Имя:";
            // 
            // lblFam
            // 
            this.lblFam.AutoSize = true;
            this.lblFam.BackColor = System.Drawing.Color.Transparent;
            this.lblFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFam.Location = new System.Drawing.Point(53, 68);
            this.lblFam.Name = "lblFam";
            this.lblFam.Size = new System.Drawing.Size(85, 20);
            this.lblFam.TabIndex = 51;
            this.lblFam.Text = "Фамилия:";
            // 
            // tb_Fam
            // 
            this.tb_Fam.Location = new System.Drawing.Point(154, 67);
            this.tb_Fam.Name = "tb_Fam";
            this.tb_Fam.Size = new System.Drawing.Size(280, 20);
            this.tb_Fam.TabIndex = 1;
            this.tb_Fam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Fam_KeyPress);
            // 
            // tbImya
            // 
            this.tbImya.Location = new System.Drawing.Point(154, 102);
            this.tbImya.Name = "tbImya";
            this.tbImya.Size = new System.Drawing.Size(280, 20);
            this.tbImya.TabIndex = 2;
            // 
            // tbRepeatPass
            // 
            this.tbRepeatPass.Location = new System.Drawing.Point(154, 245);
            this.tbRepeatPass.MaxLength = 16;
            this.tbRepeatPass.Name = "tbRepeatPass";
            this.tbRepeatPass.Size = new System.Drawing.Size(280, 20);
            this.tbRepeatPass.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Повтор пароля:";
            // 
            // btReg
            // 
            this.btReg.Enabled = false;
            this.btReg.Location = new System.Drawing.Point(301, 279);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(133, 32);
            this.btReg.TabIndex = 8;
            this.btReg.Text = "Зарегистрироваться";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(154, 209);
            this.tbPass.MaxLength = 16;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(280, 20);
            this.tbPass.TabIndex = 5;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(154, 175);
            this.tbLogin.MaxLength = 16;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(280, 20);
            this.tbLogin.TabIndex = 4;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPass.Location = new System.Drawing.Point(67, 207);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(71, 20);
            this.lbPass.TabIndex = 43;
            this.lbPass.Text = "Пароль:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(77, 173);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(59, 20);
            this.lbLogin.TabIndex = 42;
            this.lbLogin.Text = "Логин:";
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.BackColor = System.Drawing.Color.Transparent;
            this.lbAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuth.Location = new System.Drawing.Point(111, 9);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(277, 51);
            this.lbAuth.TabIndex = 41;
            this.lbAuth.Text = "Регистрация";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(440, 102);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 62;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(440, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 61;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(440, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(440, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(440, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btGlaz);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btProv);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_Pochta);
            this.Controls.Add(this.tb_Pochta);
            this.Controls.Add(this.lbl_Imya);
            this.Controls.Add(this.lblFam);
            this.Controls.Add(this.tb_Fam);
            this.Controls.Add(this.tbImya);
            this.Controls.Add(this.tbRepeatPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btGlaz;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btProv;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_Pochta;
        private System.Windows.Forms.TextBox tb_Pochta;
        private System.Windows.Forms.Label lbl_Imya;
        private System.Windows.Forms.Label lblFam;
        private System.Windows.Forms.TextBox tb_Fam;
        private System.Windows.Forms.TextBox tbImya;
        private System.Windows.Forms.TextBox tbRepeatPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbAuth;
    }
}