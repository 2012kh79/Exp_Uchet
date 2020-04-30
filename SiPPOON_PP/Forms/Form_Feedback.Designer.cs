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
            this.gb_Feedback = new System.Windows.Forms.GroupBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tb_Pole = new System.Windows.Forms.TextBox();
            this.tb_Ot = new System.Windows.Forms.TextBox();
            this.lbl_Ot = new System.Windows.Forms.Label();
            this.lbl_FeedBack = new System.Windows.Forms.Label();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.gb_Feedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Feedback
            // 
            this.gb_Feedback.Controls.Add(this.tb_Password);
            this.gb_Feedback.Controls.Add(this.lbl_Password);
            this.gb_Feedback.Controls.Add(this.tb_Mail);
            this.gb_Feedback.Controls.Add(this.lbl_Mail);
            this.gb_Feedback.Controls.Add(this.btn_Send);
            this.gb_Feedback.Controls.Add(this.tb_Pole);
            this.gb_Feedback.Controls.Add(this.tb_Ot);
            this.gb_Feedback.Controls.Add(this.lbl_Ot);
            this.gb_Feedback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_Feedback.Location = new System.Drawing.Point(0, 84);
            this.gb_Feedback.Name = "gb_Feedback";
            this.gb_Feedback.Size = new System.Drawing.Size(275, 310);
            this.gb_Feedback.TabIndex = 1;
            this.gb_Feedback.TabStop = false;
            this.gb_Feedback.Text = "Данные письма";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(57, 47);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(207, 20);
            this.tb_Password.TabIndex = 11;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(7, 50);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(48, 13);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "Пароль:";
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(57, 19);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(207, 20);
            this.tb_Mail.TabIndex = 9;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(26, 22);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(29, 13);
            this.lbl_Mail.TabIndex = 8;
            this.lbl_Mail.Text = "Mail:";
            // 
            // btn_Send
            // 
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Send.Location = new System.Drawing.Point(10, 255);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(254, 50);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Mail_Click);
            // 
            // tb_Pole
            // 
            this.tb_Pole.Location = new System.Drawing.Point(10, 99);
            this.tb_Pole.Multiline = true;
            this.tb_Pole.Name = "tb_Pole";
            this.tb_Pole.Size = new System.Drawing.Size(254, 150);
            this.tb_Pole.TabIndex = 6;
            // 
            // tb_Ot
            // 
            this.tb_Ot.Location = new System.Drawing.Point(57, 73);
            this.tb_Ot.Name = "tb_Ot";
            this.tb_Ot.Size = new System.Drawing.Size(207, 20);
            this.tb_Ot.TabIndex = 4;
            // 
            // lbl_Ot
            // 
            this.lbl_Ot.AutoSize = true;
            this.lbl_Ot.Location = new System.Drawing.Point(6, 76);
            this.lbl_Ot.Name = "lbl_Ot";
            this.lbl_Ot.Size = new System.Drawing.Size(49, 13);
            this.lbl_Ot.TabIndex = 1;
            this.lbl_Ot.Text = "От кого:";
            // 
            // lbl_FeedBack
            // 
            this.lbl_FeedBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_FeedBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_FeedBack.Location = new System.Drawing.Point(0, 0);
            this.lbl_FeedBack.Name = "lbl_FeedBack";
            this.lbl_FeedBack.Size = new System.Drawing.Size(275, 19);
            this.lbl_FeedBack.TabIndex = 9;
            this.lbl_FeedBack.Text = "Оставьте отзыв о нашей программе";
            this.lbl_FeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb5
            // 
            this.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb5.Location = new System.Drawing.Point(225, 22);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(50, 50);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 13;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // pb4
            // 
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb4.Location = new System.Drawing.Point(169, 22);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(50, 50);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 12;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb3
            // 
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb3.Location = new System.Drawing.Point(113, 22);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(50, 50);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 11;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb2
            // 
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb2.Location = new System.Drawing.Point(57, 22);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(50, 50);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 10;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb1.Location = new System.Drawing.Point(0, 22);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(50, 50);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 8;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // Form_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 394);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.lbl_FeedBack);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.gb_Feedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма обратной связи";
            this.Load += new System.EventHandler(this.Form_Mail_Load);
            this.gb_Feedback.ResumeLayout(false);
            this.gb_Feedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Feedback;
        private System.Windows.Forms.TextBox tb_Pole;
        private System.Windows.Forms.TextBox tb_Ot;
        private System.Windows.Forms.Label lbl_Ot;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lbl_FeedBack;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
    }
}