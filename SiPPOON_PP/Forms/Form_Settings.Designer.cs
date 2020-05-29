namespace SiPPOON_PP.Forms
{
    partial class Form_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings));
            this.gb_Result = new System.Windows.Forms.GroupBox();
            this.btn_Review = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_PathFile = new System.Windows.Forms.Label();
            this.btn_Review_Folder = new System.Windows.Forms.Button();
            this.tb_Path_Folder = new System.Windows.Forms.TextBox();
            this.lbl_Path_Folder = new System.Windows.Forms.Label();
            this.gb_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Result
            // 
            this.gb_Result.Controls.Add(this.btn_Review_Folder);
            this.gb_Result.Controls.Add(this.tb_Path_Folder);
            this.gb_Result.Controls.Add(this.lbl_Path_Folder);
            this.gb_Result.Controls.Add(this.btn_Review);
            this.gb_Result.Controls.Add(this.btn_Save);
            this.gb_Result.Controls.Add(this.tb_Path);
            this.gb_Result.Controls.Add(this.btn_Update);
            this.gb_Result.Controls.Add(this.lbl_PathFile);
            this.gb_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Result.Location = new System.Drawing.Point(0, 0);
            this.gb_Result.Name = "gb_Result";
            this.gb_Result.Size = new System.Drawing.Size(384, 106);
            this.gb_Result.TabIndex = 0;
            this.gb_Result.TabStop = false;
            this.gb_Result.Text = "Результаты исследования";
            // 
            // btn_Review
            // 
            this.btn_Review.Enabled = false;
            this.btn_Review.Location = new System.Drawing.Point(342, 16);
            this.btn_Review.Name = "btn_Review";
            this.btn_Review.Size = new System.Drawing.Size(30, 25);
            this.btn_Review.TabIndex = 5;
            this.btn_Review.Text = "...";
            this.btn_Review.UseVisualStyleBackColor = true;
            this.btn_Review.Click += new System.EventHandler(this.btn_Review_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(272, 77);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 25);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Path
            // 
            this.tb_Path.Enabled = false;
            this.tb_Path.Location = new System.Drawing.Point(89, 19);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(245, 20);
            this.tb_Path.TabIndex = 1;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(166, 77);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 25);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Изменить";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_PathFile
            // 
            this.lbl_PathFile.AutoSize = true;
            this.lbl_PathFile.Location = new System.Drawing.Point(6, 22);
            this.lbl_PathFile.Name = "lbl_PathFile";
            this.lbl_PathFile.Size = new System.Drawing.Size(77, 13);
            this.lbl_PathFile.TabIndex = 0;
            this.lbl_PathFile.Text = "Путь к файлу:";
            // 
            // btn_Review_Folder
            // 
            this.btn_Review_Folder.Enabled = false;
            this.btn_Review_Folder.Location = new System.Drawing.Point(342, 47);
            this.btn_Review_Folder.Name = "btn_Review_Folder";
            this.btn_Review_Folder.Size = new System.Drawing.Size(30, 25);
            this.btn_Review_Folder.TabIndex = 8;
            this.btn_Review_Folder.Text = "...";
            this.btn_Review_Folder.UseVisualStyleBackColor = true;
            this.btn_Review_Folder.Click += new System.EventHandler(this.btn_Review_Folder_Click);
            // 
            // tb_Path_Folder
            // 
            this.tb_Path_Folder.Enabled = false;
            this.tb_Path_Folder.Location = new System.Drawing.Point(89, 50);
            this.tb_Path_Folder.Name = "tb_Path_Folder";
            this.tb_Path_Folder.Size = new System.Drawing.Size(245, 20);
            this.tb_Path_Folder.TabIndex = 7;
            // 
            // lbl_Path_Folder
            // 
            this.lbl_Path_Folder.AutoSize = true;
            this.lbl_Path_Folder.Location = new System.Drawing.Point(6, 53);
            this.lbl_Path_Folder.Name = "lbl_Path_Folder";
            this.lbl_Path_Folder.Size = new System.Drawing.Size(76, 13);
            this.lbl_Path_Folder.TabIndex = 6;
            this.lbl_Path_Folder.Text = "Путь к папке:";
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 106);
            this.Controls.Add(this.gb_Result);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.gb_Result.ResumeLayout(false);
            this.gb_Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Result;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_PathFile;
        private System.Windows.Forms.Button btn_Review;
        private System.Windows.Forms.Button btn_Review_Folder;
        private System.Windows.Forms.TextBox tb_Path_Folder;
        private System.Windows.Forms.Label lbl_Path_Folder;
    }
}