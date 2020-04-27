namespace SiPPOON_PP
{
    partial class Form_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.tc_Admin = new System.Windows.Forms.TabControl();
            this.tp_Users = new System.Windows.Forms.TabPage();
            this.gb_Rabota_s_dannimy = new System.Windows.Forms.GroupBox();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.lb_Mail = new System.Windows.Forms.Label();
            this.lbl_Employee = new System.Windows.Forms.Label();
            this.cmb_Employee = new System.Windows.Forms.ComboBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.tp_Employee = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_Exit_Sotr = new System.Windows.Forms.PictureBox();
            this.tb_Imya = new System.Windows.Forms.TextBox();
            this.lbl_Imya = new System.Windows.Forms.Label();
            this.lbl_Fam = new System.Windows.Forms.Label();
            this.btn_Delete_Sotrudnik = new System.Windows.Forms.Button();
            this.btn_Update_Sotrudnik = new System.Windows.Forms.Button();
            this.tb_Fam = new System.Windows.Forms.TextBox();
            this.btn_Insert_Sotrudnik = new System.Windows.Forms.Button();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.tc_Admin.SuspendLayout();
            this.tp_Users.SuspendLayout();
            this.gb_Rabota_s_dannimy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.tp_Employee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit_Sotr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_Admin
            // 
            this.tc_Admin.Controls.Add(this.tp_Users);
            this.tc_Admin.Controls.Add(this.tp_Employee);
            this.tc_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Admin.Location = new System.Drawing.Point(0, 0);
            this.tc_Admin.Name = "tc_Admin";
            this.tc_Admin.SelectedIndex = 0;
            this.tc_Admin.Size = new System.Drawing.Size(784, 411);
            this.tc_Admin.TabIndex = 0;
            // 
            // tp_Users
            // 
            this.tp_Users.Controls.Add(this.gb_Rabota_s_dannimy);
            this.tp_Users.Controls.Add(this.dgv_Users);
            this.tp_Users.Location = new System.Drawing.Point(4, 22);
            this.tp_Users.Name = "tp_Users";
            this.tp_Users.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Users.Size = new System.Drawing.Size(776, 385);
            this.tp_Users.TabIndex = 0;
            this.tp_Users.Text = "Пользователи";
            this.tp_Users.UseVisualStyleBackColor = true;
            // 
            // gb_Rabota_s_dannimy
            // 
            this.gb_Rabota_s_dannimy.Controls.Add(this.tb_Mail);
            this.gb_Rabota_s_dannimy.Controls.Add(this.lb_Mail);
            this.gb_Rabota_s_dannimy.Controls.Add(this.lbl_Employee);
            this.gb_Rabota_s_dannimy.Controls.Add(this.cmb_Employee);
            this.gb_Rabota_s_dannimy.Controls.Add(this.pb_Exit);
            this.gb_Rabota_s_dannimy.Controls.Add(this.cmb_Role);
            this.gb_Rabota_s_dannimy.Controls.Add(this.lbl_Role);
            this.gb_Rabota_s_dannimy.Controls.Add(this.tb_Password);
            this.gb_Rabota_s_dannimy.Controls.Add(this.lbl_Password);
            this.gb_Rabota_s_dannimy.Controls.Add(this.lbl_Login);
            this.gb_Rabota_s_dannimy.Controls.Add(this.btn_Delete);
            this.gb_Rabota_s_dannimy.Controls.Add(this.btn_Update);
            this.gb_Rabota_s_dannimy.Controls.Add(this.tb_Login);
            this.gb_Rabota_s_dannimy.Controls.Add(this.btn_Insert);
            this.gb_Rabota_s_dannimy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Rabota_s_dannimy.Location = new System.Drawing.Point(3, 252);
            this.gb_Rabota_s_dannimy.Name = "gb_Rabota_s_dannimy";
            this.gb_Rabota_s_dannimy.Size = new System.Drawing.Size(770, 130);
            this.gb_Rabota_s_dannimy.TabIndex = 3;
            this.gb_Rabota_s_dannimy.TabStop = false;
            this.gb_Rabota_s_dannimy.Text = "Работа с данными";
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(75, 71);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(215, 20);
            this.tb_Mail.TabIndex = 15;
            // 
            // lb_Mail
            // 
            this.lb_Mail.AutoSize = true;
            this.lb_Mail.Location = new System.Drawing.Point(28, 74);
            this.lb_Mail.Name = "lb_Mail";
            this.lb_Mail.Size = new System.Drawing.Size(40, 13);
            this.lb_Mail.TabIndex = 16;
            this.lb_Mail.Text = "Почта:";
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.AutoSize = true;
            this.lbl_Employee.Location = new System.Drawing.Point(320, 45);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(63, 13);
            this.lbl_Employee.TabIndex = 14;
            this.lbl_Employee.Text = "Сотрудник:";
            // 
            // cmb_Employee
            // 
            this.cmb_Employee.FormattingEnabled = true;
            this.cmb_Employee.Location = new System.Drawing.Point(389, 42);
            this.cmb_Employee.Name = "cmb_Employee";
            this.cmb_Employee.Size = new System.Drawing.Size(215, 21);
            this.cmb_Employee.TabIndex = 4;
            // 
            // pb_Exit
            // 
            this.pb_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Exit.Location = new System.Drawing.Point(717, 77);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(50, 50);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Exit.TabIndex = 12;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // cmb_Role
            // 
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Location = new System.Drawing.Point(389, 13);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(215, 21);
            this.cmb_Role.TabIndex = 5;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Location = new System.Drawing.Point(348, 16);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(35, 13);
            this.lbl_Role.TabIndex = 10;
            this.lbl_Role.Text = "Роль:";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(75, 42);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(215, 20);
            this.tb_Password.TabIndex = 2;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(21, 45);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(48, 13);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "Пароль:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(28, 16);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(41, 13);
            this.lbl_Login.TabIndex = 5;
            this.lbl_Login.Text = "Логин:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(215, 101);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(122, 101);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Изменить";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(75, 13);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(215, 20);
            this.tb_Login.TabIndex = 1;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(31, 101);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.Text = "Добавить";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            this.dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Users.Location = new System.Drawing.Point(3, 3);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.Size = new System.Drawing.Size(770, 249);
            this.dgv_Users.TabIndex = 0;
            this.dgv_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Users_CellContentClick);
            // 
            // tp_Employee
            // 
            this.tp_Employee.Controls.Add(this.groupBox1);
            this.tp_Employee.Controls.Add(this.dgv_Employee);
            this.tp_Employee.Location = new System.Drawing.Point(4, 22);
            this.tp_Employee.Name = "tp_Employee";
            this.tp_Employee.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Employee.Size = new System.Drawing.Size(776, 385);
            this.tp_Employee.TabIndex = 1;
            this.tp_Employee.Text = "Сотрудники";
            this.tp_Employee.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_Exit_Sotr);
            this.groupBox1.Controls.Add(this.tb_Imya);
            this.groupBox1.Controls.Add(this.lbl_Imya);
            this.groupBox1.Controls.Add(this.lbl_Fam);
            this.groupBox1.Controls.Add(this.btn_Delete_Sotrudnik);
            this.groupBox1.Controls.Add(this.btn_Update_Sotrudnik);
            this.groupBox1.Controls.Add(this.tb_Fam);
            this.groupBox1.Controls.Add(this.btn_Insert_Sotrudnik);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с данными";
            // 
            // pb_Exit_Sotr
            // 
            this.pb_Exit_Sotr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Exit_Sotr.Location = new System.Drawing.Point(717, 77);
            this.pb_Exit_Sotr.Name = "pb_Exit_Sotr";
            this.pb_Exit_Sotr.Size = new System.Drawing.Size(50, 50);
            this.pb_Exit_Sotr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Exit_Sotr.TabIndex = 12;
            this.pb_Exit_Sotr.TabStop = false;
            this.pb_Exit_Sotr.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // tb_Imya
            // 
            this.tb_Imya.Location = new System.Drawing.Point(75, 42);
            this.tb_Imya.Name = "tb_Imya";
            this.tb_Imya.Size = new System.Drawing.Size(215, 20);
            this.tb_Imya.TabIndex = 2;
            // 
            // lbl_Imya
            // 
            this.lbl_Imya.AutoSize = true;
            this.lbl_Imya.Location = new System.Drawing.Point(36, 45);
            this.lbl_Imya.Name = "lbl_Imya";
            this.lbl_Imya.Size = new System.Drawing.Size(32, 13);
            this.lbl_Imya.TabIndex = 6;
            this.lbl_Imya.Text = "Имя:";
            // 
            // lbl_Fam
            // 
            this.lbl_Fam.AutoSize = true;
            this.lbl_Fam.Location = new System.Drawing.Point(9, 16);
            this.lbl_Fam.Name = "lbl_Fam";
            this.lbl_Fam.Size = new System.Drawing.Size(59, 13);
            this.lbl_Fam.TabIndex = 5;
            this.lbl_Fam.Text = "Фамилия:";
            // 
            // btn_Delete_Sotrudnik
            // 
            this.btn_Delete_Sotrudnik.Location = new System.Drawing.Point(215, 101);
            this.btn_Delete_Sotrudnik.Name = "btn_Delete_Sotrudnik";
            this.btn_Delete_Sotrudnik.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete_Sotrudnik.TabIndex = 6;
            this.btn_Delete_Sotrudnik.Text = "Удалить";
            this.btn_Delete_Sotrudnik.UseVisualStyleBackColor = true;
            this.btn_Delete_Sotrudnik.Click += new System.EventHandler(this.btn_Delete_Sotrudnik_Click);
            // 
            // btn_Update_Sotrudnik
            // 
            this.btn_Update_Sotrudnik.Location = new System.Drawing.Point(122, 101);
            this.btn_Update_Sotrudnik.Name = "btn_Update_Sotrudnik";
            this.btn_Update_Sotrudnik.Size = new System.Drawing.Size(75, 23);
            this.btn_Update_Sotrudnik.TabIndex = 5;
            this.btn_Update_Sotrudnik.Text = "Изменить";
            this.btn_Update_Sotrudnik.UseVisualStyleBackColor = true;
            this.btn_Update_Sotrudnik.Click += new System.EventHandler(this.btn_Update_Sotrudnik_Click);
            // 
            // tb_Fam
            // 
            this.tb_Fam.Location = new System.Drawing.Point(75, 13);
            this.tb_Fam.Name = "tb_Fam";
            this.tb_Fam.Size = new System.Drawing.Size(215, 20);
            this.tb_Fam.TabIndex = 1;
            // 
            // btn_Insert_Sotrudnik
            // 
            this.btn_Insert_Sotrudnik.Location = new System.Drawing.Point(31, 101);
            this.btn_Insert_Sotrudnik.Name = "btn_Insert_Sotrudnik";
            this.btn_Insert_Sotrudnik.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert_Sotrudnik.TabIndex = 4;
            this.btn_Insert_Sotrudnik.Text = "Добавить";
            this.btn_Insert_Sotrudnik.UseVisualStyleBackColor = true;
            this.btn_Insert_Sotrudnik.Click += new System.EventHandler(this.btn_Insert_Sotrudnik_Click);
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            this.dgv_Employee.AllowUserToDeleteRows = false;
            this.dgv_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Employee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Employee.Location = new System.Drawing.Point(3, 3);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.Size = new System.Drawing.Size(770, 249);
            this.dgv_Employee.TabIndex = 4;
            this.dgv_Employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employee_CellContentClick);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tc_Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Админ";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            this.tc_Admin.ResumeLayout(false);
            this.tp_Users.ResumeLayout(false);
            this.gb_Rabota_s_dannimy.ResumeLayout(false);
            this.gb_Rabota_s_dannimy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.tp_Employee.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit_Sotr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Admin;
        private System.Windows.Forms.TabPage tp_Users;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.TabPage tp_Employee;
        private System.Windows.Forms.GroupBox gb_Rabota_s_dannimy;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.ComboBox cmb_Role;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Employee;
        private System.Windows.Forms.ComboBox cmb_Employee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_Exit_Sotr;
        private System.Windows.Forms.TextBox tb_Imya;
        private System.Windows.Forms.Label lbl_Imya;
        private System.Windows.Forms.Label lbl_Fam;
        private System.Windows.Forms.Button btn_Delete_Sotrudnik;
        private System.Windows.Forms.Button btn_Update_Sotrudnik;
        private System.Windows.Forms.TextBox tb_Fam;
        private System.Windows.Forms.Button btn_Insert_Sotrudnik;
        private System.Windows.Forms.DataGridView dgv_Employee;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label lb_Mail;
    }
}