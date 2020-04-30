namespace SiPPOON_PP
{
    partial class Form_Authorize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Authorize));
            this.btVhod = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbAuth = new System.Windows.Forms.Label();
            this.ll_Password = new System.Windows.Forms.LinkLabel();
            this.btGlaz = new System.Windows.Forms.Button();
            this.ll_NoAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btVhod
            // 
            this.btVhod.Location = new System.Drawing.Point(138, 177);
            this.btVhod.Name = "btVhod";
            this.btVhod.Size = new System.Drawing.Size(130, 35);
            this.btVhod.TabIndex = 45;
            this.btVhod.Text = "Авторизоваться";
            this.btVhod.UseVisualStyleBackColor = true;
            this.btVhod.Click += new System.EventHandler(this.BtVhod_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(95, 148);
            this.tbPass.MaxLength = 16;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(214, 20);
            this.tbPass.TabIndex = 44;
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPass_KeyPress);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(95, 98);
            this.tbLogin.MaxLength = 16;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(214, 20);
            this.tbLogin.TabIndex = 43;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPass.Location = new System.Drawing.Point(22, 146);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(71, 20);
            this.lbPass.TabIndex = 42;
            this.lbPass.Text = "Пароль:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(34, 96);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(59, 20);
            this.lbLogin.TabIndex = 41;
            this.lbLogin.Text = "Логин:";
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.BackColor = System.Drawing.Color.Transparent;
            this.lbAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuth.Location = new System.Drawing.Point(55, 26);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(284, 51);
            this.lbAuth.TabIndex = 40;
            this.lbAuth.Text = "Авторизация";
            // 
            // ll_Password
            // 
            this.ll_Password.AutoSize = true;
            this.ll_Password.BackColor = System.Drawing.Color.Transparent;
            this.ll_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ll_Password.Location = new System.Drawing.Point(145, 235);
            this.ll_Password.Name = "ll_Password";
            this.ll_Password.Size = new System.Drawing.Size(118, 17);
            this.ll_Password.TabIndex = 47;
            this.ll_Password.TabStop = true;
            this.ll_Password.Text = "Забыли пароль?";
            this.ll_Password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Password_LinkClicked);
            // 
            // btGlaz
            // 
            this.btGlaz.BackgroundImage = global::SiPPOON_PP.Properties.Resources.Glaz;
            this.btGlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGlaz.Location = new System.Drawing.Point(316, 147);
            this.btGlaz.Name = "btGlaz";
            this.btGlaz.Size = new System.Drawing.Size(23, 22);
            this.btGlaz.TabIndex = 46;
            this.btGlaz.UseVisualStyleBackColor = true;
            this.btGlaz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btGlaz_MouseDown);
            this.btGlaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btGlaz_MouseUp);
            // 
            // ll_NoAccount
            // 
            this.ll_NoAccount.AutoSize = true;
            this.ll_NoAccount.BackColor = System.Drawing.Color.Transparent;
            this.ll_NoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ll_NoAccount.Location = new System.Drawing.Point(75, 215);
            this.ll_NoAccount.Name = "ll_NoAccount";
            this.ll_NoAccount.Size = new System.Drawing.Size(245, 17);
            this.ll_NoAccount.TabIndex = 46;
            this.ll_NoAccount.TabStop = true;
            this.ll_NoAccount.Text = "Нет аккаунта? Зарегистрироваться";
            this.ll_NoAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_NoAccount_LinkClicked);
            // 
            // Form_Authorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ll_NoAccount);
            this.Controls.Add(this.ll_Password);
            this.Controls.Add(this.btGlaz);
            this.Controls.Add(this.btVhod);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Authorize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form_Authorize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGlaz;
        private System.Windows.Forms.Button btVhod;
        public System.Windows.Forms.TextBox tbPass;
        public System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbAuth;
        private System.Windows.Forms.LinkLabel ll_Password;
        private System.Windows.Forms.LinkLabel ll_NoAccount;
    }
}