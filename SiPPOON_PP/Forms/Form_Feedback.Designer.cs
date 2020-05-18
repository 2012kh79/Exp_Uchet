namespace SiPPOON_PP
{
    partial class Form_Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Feedback));
            this.gb_Mail = new System.Windows.Forms.GroupBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_PassMail = new System.Windows.Forms.TextBox();
            this.lbl_PassMail = new System.Windows.Forms.Label();
            this.tb_Body = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.gb_Mail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Mail
            // 
            this.gb_Mail.Controls.Add(this.tb_Name);
            this.gb_Mail.Controls.Add(this.lbl_Name);
            this.gb_Mail.Controls.Add(this.tb_PassMail);
            this.gb_Mail.Controls.Add(this.lbl_PassMail);
            this.gb_Mail.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_Mail.Location = new System.Drawing.Point(0, 0);
            this.gb_Mail.Name = "gb_Mail";
            this.gb_Mail.Size = new System.Drawing.Size(384, 81);
            this.gb_Mail.TabIndex = 0;
            this.gb_Mail.TabStop = false;
            this.gb_Mail.Text = "Данные аккаунта от почты:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(113, 50);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(259, 20);
            this.tb_Name.TabIndex = 3;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(47, 53);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(60, 13);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Ваше имя:";
            // 
            // tb_PassMail
            // 
            this.tb_PassMail.Location = new System.Drawing.Point(113, 20);
            this.tb_PassMail.Name = "tb_PassMail";
            this.tb_PassMail.Size = new System.Drawing.Size(259, 20);
            this.tb_PassMail.TabIndex = 1;
            // 
            // lbl_PassMail
            // 
            this.lbl_PassMail.AutoSize = true;
            this.lbl_PassMail.Location = new System.Drawing.Point(12, 23);
            this.lbl_PassMail.Name = "lbl_PassMail";
            this.lbl_PassMail.Size = new System.Drawing.Size(95, 13);
            this.lbl_PassMail.TabIndex = 0;
            this.lbl_PassMail.Text = "Пароль от почты:";
            // 
            // tb_Body
            // 
            this.tb_Body.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Body.Location = new System.Drawing.Point(0, 81);
            this.tb_Body.Multiline = true;
            this.tb_Body.Name = "tb_Body";
            this.tb_Body.Size = new System.Drawing.Size(384, 140);
            this.tb_Body.TabIndex = 3;
            this.tb_Body.Enter += new System.EventHandler(this.tb_Body_Enter);
            this.tb_Body.Leave += new System.EventHandler(this.tb_Body_Leave);
            // 
            // btn_Send
            // 
            this.btn_Send.BackgroundImage = global::SiPPOON_PP.Properties.Resources.Mail;
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Send.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Send.Location = new System.Drawing.Point(0, 221);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(384, 40);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Form_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.tb_Body);
            this.Controls.Add(this.gb_Mail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма обратной связи";
            this.Load += new System.EventHandler(this.Form_Mail_Load);
            this.gb_Mail.ResumeLayout(false);
            this.gb_Mail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Mail;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_PassMail;
        private System.Windows.Forms.Label lbl_PassMail;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Body;
        private System.Windows.Forms.Button btn_Send;
    }
}