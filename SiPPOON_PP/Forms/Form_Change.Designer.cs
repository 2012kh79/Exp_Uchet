namespace SiPPOON_PP
{
    partial class Form_Change
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Change));
            this.btn_Kategorii = new System.Windows.Forms.Button();
            this.btn_Okruga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Kategorii
            // 
            this.btn_Kategorii.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Kategorii.Location = new System.Drawing.Point(0, 0);
            this.btn_Kategorii.Name = "btn_Kategorii";
            this.btn_Kategorii.Size = new System.Drawing.Size(284, 36);
            this.btn_Kategorii.TabIndex = 0;
            this.btn_Kategorii.Text = "Категории";
            this.btn_Kategorii.UseVisualStyleBackColor = true;
            this.btn_Kategorii.Click += new System.EventHandler(this.btn_Kategorii_Click);
            // 
            // btn_Okruga
            // 
            this.btn_Okruga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Okruga.Location = new System.Drawing.Point(0, 36);
            this.btn_Okruga.Name = "btn_Okruga";
            this.btn_Okruga.Size = new System.Drawing.Size(284, 36);
            this.btn_Okruga.TabIndex = 1;
            this.btn_Okruga.Text = "Округа";
            this.btn_Okruga.UseVisualStyleBackColor = true;
            this.btn_Okruga.Click += new System.EventHandler(this.btn_Okruga_Click);
            // 
            // Form_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.btn_Okruga);
            this.Controls.Add(this.btn_Kategorii);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты по:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Kategorii;
        private System.Windows.Forms.Button btn_Okruga;
    }
}