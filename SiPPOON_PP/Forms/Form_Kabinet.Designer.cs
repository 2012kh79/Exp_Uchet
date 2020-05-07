namespace SiPPOON_PP
{
    partial class Form_Kabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kabinet));
            this.pb_Sotrudnik = new System.Windows.Forms.PictureBox();
            this.tb_Familiya = new System.Windows.Forms.TextBox();
            this.lbl_Familiya = new System.Windows.Forms.Label();
            this.lbl_Imya = new System.Windows.Forms.Label();
            this.tb_Imya = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sotrudnik)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Sotrudnik
            // 
            this.pb_Sotrudnik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Sotrudnik.ImageLocation = "";
            this.pb_Sotrudnik.Location = new System.Drawing.Point(10, 10);
            this.pb_Sotrudnik.Name = "pb_Sotrudnik";
            this.pb_Sotrudnik.Size = new System.Drawing.Size(150, 150);
            this.pb_Sotrudnik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Sotrudnik.TabIndex = 0;
            this.pb_Sotrudnik.TabStop = false;
            // 
            // tb_Familiya
            // 
            this.tb_Familiya.Enabled = false;
            this.tb_Familiya.Location = new System.Drawing.Point(202, 26);
            this.tb_Familiya.Name = "tb_Familiya";
            this.tb_Familiya.Size = new System.Drawing.Size(250, 20);
            this.tb_Familiya.TabIndex = 1;
            // 
            // lbl_Familiya
            // 
            this.lbl_Familiya.AutoSize = true;
            this.lbl_Familiya.Location = new System.Drawing.Point(200, 10);
            this.lbl_Familiya.Name = "lbl_Familiya";
            this.lbl_Familiya.Size = new System.Drawing.Size(59, 13);
            this.lbl_Familiya.TabIndex = 2;
            this.lbl_Familiya.Text = "Фамилия:";
            // 
            // lbl_Imya
            // 
            this.lbl_Imya.AutoSize = true;
            this.lbl_Imya.Location = new System.Drawing.Point(200, 50);
            this.lbl_Imya.Name = "lbl_Imya";
            this.lbl_Imya.Size = new System.Drawing.Size(32, 13);
            this.lbl_Imya.TabIndex = 4;
            this.lbl_Imya.Text = "Имя:";
            // 
            // tb_Imya
            // 
            this.tb_Imya.Enabled = false;
            this.tb_Imya.Location = new System.Drawing.Point(202, 66);
            this.tb_Imya.Name = "tb_Imya";
            this.tb_Imya.Size = new System.Drawing.Size(250, 20);
            this.tb_Imya.TabIndex = 3;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(201, 90);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(40, 13);
            this.lbl_Mail.TabIndex = 6;
            this.lbl_Mail.Text = "Почта:";
            // 
            // tb_Mail
            // 
            this.tb_Mail.Enabled = false;
            this.tb_Mail.Location = new System.Drawing.Point(202, 106);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(250, 20);
            this.tb_Mail.TabIndex = 5;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(202, 137);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(120, 23);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Изменить";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(332, 137);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Form_Kabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 171);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.lbl_Imya);
            this.Controls.Add(this.tb_Imya);
            this.Controls.Add(this.lbl_Familiya);
            this.Controls.Add(this.tb_Familiya);
            this.Controls.Add(this.pb_Sotrudnik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Kabinet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.Form_Kabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sotrudnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Familiya;
        private System.Windows.Forms.Label lbl_Familiya;
        private System.Windows.Forms.Label lbl_Imya;
        private System.Windows.Forms.TextBox tb_Imya;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pb_Sotrudnik;
    }
}