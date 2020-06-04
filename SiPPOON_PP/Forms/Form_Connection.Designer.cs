namespace SiPPOON_PP.Forms
{
    partial class Form_Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Connection));
            this.lblConnection = new System.Windows.Forms.Label();
            this.pnlConnection = new System.Windows.Forms.Panel();
            this.statusConect = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnProverka = new System.Windows.Forms.Button();
            this.tbPassword_server = new System.Windows.Forms.TextBox();
            this.tbUser_server = new System.Windows.Forms.TextBox();
            this.cmbIst_server = new System.Windows.Forms.ComboBox();
            this.cmbNazv_server = new System.Windows.Forms.ComboBox();
            this.cmbAdres_server = new System.Windows.Forms.ComboBox();
            this.lblSpisok = new System.Windows.Forms.Label();
            this.lblPassword_User = new System.Windows.Forms.Label();
            this.lblUserServer = new System.Windows.Forms.Label();
            this.lblNazv_server = new System.Windows.Forms.Label();
            this.lblAdres_server = new System.Windows.Forms.Label();
            this.pnlConnection.SuspendLayout();
            this.statusConect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConnection.Location = new System.Drawing.Point(48, 9);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(199, 20);
            this.lblConnection.TabIndex = 1;
            this.lblConnection.Text = "Настройка подключения";
            // 
            // pnlConnection
            // 
            this.pnlConnection.Controls.Add(this.statusConect);
            this.pnlConnection.Controls.Add(this.btnCancel);
            this.pnlConnection.Controls.Add(this.btnConnect);
            this.pnlConnection.Controls.Add(this.btnProverka);
            this.pnlConnection.Controls.Add(this.tbPassword_server);
            this.pnlConnection.Controls.Add(this.tbUser_server);
            this.pnlConnection.Controls.Add(this.cmbIst_server);
            this.pnlConnection.Controls.Add(this.cmbNazv_server);
            this.pnlConnection.Controls.Add(this.cmbAdres_server);
            this.pnlConnection.Controls.Add(this.lblSpisok);
            this.pnlConnection.Controls.Add(this.lblPassword_User);
            this.pnlConnection.Controls.Add(this.lblUserServer);
            this.pnlConnection.Controls.Add(this.lblNazv_server);
            this.pnlConnection.Controls.Add(this.lblAdres_server);
            this.pnlConnection.Location = new System.Drawing.Point(15, 35);
            this.pnlConnection.Name = "pnlConnection";
            this.pnlConnection.Size = new System.Drawing.Size(255, 266);
            this.pnlConnection.TabIndex = 2;
            // 
            // statusConect
            // 
            this.statusConect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusConect.Location = new System.Drawing.Point(0, 244);
            this.statusConect.Name = "statusConect";
            this.statusConect.Size = new System.Drawing.Size(255, 22);
            this.statusConect.TabIndex = 13;
            this.statusConect.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(12, 17);
            this.tsslStatus.Text = "-";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(175, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 25);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(89, 206);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(80, 25);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Подключить";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnProverka
            // 
            this.btnProverka.Location = new System.Drawing.Point(3, 206);
            this.btnProverka.Name = "btnProverka";
            this.btnProverka.Size = new System.Drawing.Size(80, 25);
            this.btnProverka.TabIndex = 10;
            this.btnProverka.Text = "Проверка";
            this.btnProverka.UseVisualStyleBackColor = true;
            this.btnProverka.Click += new System.EventHandler(this.btnProverka_Click);
            // 
            // tbPassword_server
            // 
            this.tbPassword_server.Location = new System.Drawing.Point(3, 140);
            this.tbPassword_server.Name = "tbPassword_server";
            this.tbPassword_server.Size = new System.Drawing.Size(249, 20);
            this.tbPassword_server.TabIndex = 9;
            // 
            // tbUser_server
            // 
            this.tbUser_server.Location = new System.Drawing.Point(3, 101);
            this.tbUser_server.Name = "tbUser_server";
            this.tbUser_server.Size = new System.Drawing.Size(249, 20);
            this.tbUser_server.TabIndex = 8;
            // 
            // cmbIst_server
            // 
            this.cmbIst_server.FormattingEnabled = true;
            this.cmbIst_server.Location = new System.Drawing.Point(3, 179);
            this.cmbIst_server.Name = "cmbIst_server";
            this.cmbIst_server.Size = new System.Drawing.Size(249, 21);
            this.cmbIst_server.TabIndex = 7;
            // 
            // cmbNazv_server
            // 
            this.cmbNazv_server.FormattingEnabled = true;
            this.cmbNazv_server.Location = new System.Drawing.Point(3, 61);
            this.cmbNazv_server.Name = "cmbNazv_server";
            this.cmbNazv_server.Size = new System.Drawing.Size(249, 21);
            this.cmbNazv_server.TabIndex = 6;
            // 
            // cmbAdres_server
            // 
            this.cmbAdres_server.FormattingEnabled = true;
            this.cmbAdres_server.Location = new System.Drawing.Point(3, 21);
            this.cmbAdres_server.Name = "cmbAdres_server";
            this.cmbAdres_server.Size = new System.Drawing.Size(249, 21);
            this.cmbAdres_server.TabIndex = 5;
            // 
            // lblSpisok
            // 
            this.lblSpisok.AutoSize = true;
            this.lblSpisok.Location = new System.Drawing.Point(7, 163);
            this.lblSpisok.Name = "lblSpisok";
            this.lblSpisok.Size = new System.Drawing.Size(150, 13);
            this.lblSpisok.TabIndex = 4;
            this.lblSpisok.Text = "Список источников сервера";
            // 
            // lblPassword_User
            // 
            this.lblPassword_User.AutoSize = true;
            this.lblPassword_User.Location = new System.Drawing.Point(7, 124);
            this.lblPassword_User.Name = "lblPassword_User";
            this.lblPassword_User.Size = new System.Drawing.Size(119, 13);
            this.lblPassword_User.TabIndex = 3;
            this.lblPassword_User.Text = "Пароль пользователя";
            // 
            // lblUserServer
            // 
            this.lblUserServer.AutoSize = true;
            this.lblUserServer.Location = new System.Drawing.Point(7, 85);
            this.lblUserServer.Name = "lblUserServer";
            this.lblUserServer.Size = new System.Drawing.Size(125, 13);
            this.lblUserServer.TabIndex = 2;
            this.lblUserServer.Text = "Пользователь сервера";
            // 
            // lblNazv_server
            // 
            this.lblNazv_server.AutoSize = true;
            this.lblNazv_server.Location = new System.Drawing.Point(7, 45);
            this.lblNazv_server.Name = "lblNazv_server";
            this.lblNazv_server.Size = new System.Drawing.Size(102, 13);
            this.lblNazv_server.TabIndex = 1;
            this.lblNazv_server.Text = "Название сервера";
            // 
            // lblAdres_server
            // 
            this.lblAdres_server.AutoSize = true;
            this.lblAdres_server.Location = new System.Drawing.Point(7, 5);
            this.lblAdres_server.Name = "lblAdres_server";
            this.lblAdres_server.Size = new System.Drawing.Size(83, 13);
            this.lblAdres_server.TabIndex = 0;
            this.lblAdres_server.Text = "Адрес сервера";
            // 
            // Form_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.pnlConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка подключения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Connection_FormClosing);
            this.Load += new System.EventHandler(this.Form_Connection_Load);
            this.pnlConnection.ResumeLayout(false);
            this.pnlConnection.PerformLayout();
            this.statusConect.ResumeLayout(false);
            this.statusConect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Panel pnlConnection;
        private System.Windows.Forms.StatusStrip statusConect;
        public System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnProverka;
        private System.Windows.Forms.TextBox tbPassword_server;
        private System.Windows.Forms.TextBox tbUser_server;
        private System.Windows.Forms.ComboBox cmbIst_server;
        private System.Windows.Forms.ComboBox cmbNazv_server;
        private System.Windows.Forms.ComboBox cmbAdres_server;
        private System.Windows.Forms.Label lblSpisok;
        private System.Windows.Forms.Label lblPassword_User;
        private System.Windows.Forms.Label lblUserServer;
        private System.Windows.Forms.Label lblNazv_server;
        private System.Windows.Forms.Label lblAdres_server;
    }
}