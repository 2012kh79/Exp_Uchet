namespace SiPPOON_PP
{
    partial class Form_Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Result));
            this.lbl_Result = new System.Windows.Forms.Label();
            this.pb_Okruga = new System.Windows.Forms.PictureBox();
            this.pb_Kategorii = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Okruga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Kategorii)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Result.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_Result.Location = new System.Drawing.Point(12, 24);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(462, 31);
            this.lbl_Result.TabIndex = 10;
            this.lbl_Result.Text = "Выберите интересующие результаты";
            // 
            // pb_Okruga
            // 
            this.pb_Okruga.BackColor = System.Drawing.Color.Transparent;
            this.pb_Okruga.BackgroundImage = global::SiPPOON_PP.Properties.Resources.Result_Okr;
            this.pb_Okruga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Okruga.Location = new System.Drawing.Point(247, 72);
            this.pb_Okruga.Name = "pb_Okruga";
            this.pb_Okruga.Size = new System.Drawing.Size(225, 225);
            this.pb_Okruga.TabIndex = 11;
            this.pb_Okruga.TabStop = false;
            this.pb_Okruga.Click += new System.EventHandler(this.Pb_Okruga_Click);
            this.pb_Okruga.MouseLeave += new System.EventHandler(this.Pb_Okruga_MouseLeave);
            this.pb_Okruga.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pb_Okruga_MouseMove);
            // 
            // pb_Kategorii
            // 
            this.pb_Kategorii.BackColor = System.Drawing.Color.Transparent;
            this.pb_Kategorii.BackgroundImage = global::SiPPOON_PP.Properties.Resources.Result_Kat;
            this.pb_Kategorii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Kategorii.Location = new System.Drawing.Point(12, 72);
            this.pb_Kategorii.Name = "pb_Kategorii";
            this.pb_Kategorii.Size = new System.Drawing.Size(225, 225);
            this.pb_Kategorii.TabIndex = 8;
            this.pb_Kategorii.TabStop = false;
            this.pb_Kategorii.Click += new System.EventHandler(this.Pb_Kategorii_Click);
            this.pb_Kategorii.MouseLeave += new System.EventHandler(this.Pb_Kategorii_MouseLeave);
            this.pb_Kategorii.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pb_Kategorii_MouseMove);
            // 
            // Form_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.pb_Okruga);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.pb_Kategorii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты проведения экспертизы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Result_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Okruga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Kategorii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Result;
        public System.Windows.Forms.PictureBox pb_Kategorii;
        public System.Windows.Forms.PictureBox pb_Okruga;
    }
}