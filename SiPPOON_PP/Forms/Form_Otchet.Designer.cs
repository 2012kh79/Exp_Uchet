namespace SiPPOON_PP.Forms
{
    partial class Form_Otchet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Otchet));
            this.tc_Otchet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb_Otchet = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.lbl_Metr_Four = new System.Windows.Forms.Label();
            this.lbl_Metr_Three = new System.Windows.Forms.Label();
            this.lbl_Metr_PPCBN = new System.Windows.Forms.Label();
            this.lbl_PPCBN_Percent = new System.Windows.Forms.Label();
            this.lbl_Four_Percent = new System.Windows.Forms.Label();
            this.lbl_Three_Percent = new System.Windows.Forms.Label();
            this.lbl_Two_Percent = new System.Windows.Forms.Label();
            this.lbl_Metr_Two = new System.Windows.Forms.Label();
            this.lbl_Metr_One = new System.Windows.Forms.Label();
            this.lbl_One_Percent = new System.Windows.Forms.Label();
            this.tb_Metr_PPCBN = new System.Windows.Forms.TextBox();
            this.tb_Per_PPCBN = new System.Windows.Forms.TextBox();
            this.tb_Metr_Four = new System.Windows.Forms.TextBox();
            this.tb_Per_Four = new System.Windows.Forms.TextBox();
            this.tb_Metr_Three = new System.Windows.Forms.TextBox();
            this.tb_Per_Three = new System.Windows.Forms.TextBox();
            this.tb_Metr_Two = new System.Windows.Forms.TextBox();
            this.tb_Per_Two = new System.Windows.Forms.TextBox();
            this.tb_Metr_One = new System.Windows.Forms.TextBox();
            this.tb_Per_One = new System.Windows.Forms.TextBox();
            this.tb_Ploshad = new System.Windows.Forms.TextBox();
            this.lbl_Ploshad = new System.Windows.Forms.Label();
            this.tb_Kol = new System.Windows.Forms.TextBox();
            this.lbl_Kol = new System.Windows.Forms.Label();
            this.dgv_Otchet = new System.Windows.Forms.DataGridView();
            this.tc_Otchet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_Otchet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Otchet)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_Otchet
            // 
            this.tc_Otchet.Controls.Add(this.tabPage1);
            this.tc_Otchet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Otchet.Location = new System.Drawing.Point(0, 0);
            this.tc_Otchet.Name = "tc_Otchet";
            this.tc_Otchet.SelectedIndex = 0;
            this.tc_Otchet.Size = new System.Drawing.Size(784, 561);
            this.tc_Otchet.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb_Otchet);
            this.tabPage1.Controls.Add(this.dgv_Otchet);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отчёт по категориям";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb_Otchet
            // 
            this.gb_Otchet.Controls.Add(this.btn_Delete);
            this.gb_Otchet.Controls.Add(this.btn_Update);
            this.gb_Otchet.Controls.Add(this.btn_Insert);
            this.gb_Otchet.Controls.Add(this.lbl_Metr_Four);
            this.gb_Otchet.Controls.Add(this.lbl_Metr_Three);
            this.gb_Otchet.Controls.Add(this.lbl_Metr_PPCBN);
            this.gb_Otchet.Controls.Add(this.lbl_PPCBN_Percent);
            this.gb_Otchet.Controls.Add(this.lbl_Four_Percent);
            this.gb_Otchet.Controls.Add(this.lbl_Three_Percent);
            this.gb_Otchet.Controls.Add(this.lbl_Two_Percent);
            this.gb_Otchet.Controls.Add(this.lbl_Metr_Two);
            this.gb_Otchet.Controls.Add(this.lbl_Metr_One);
            this.gb_Otchet.Controls.Add(this.lbl_One_Percent);
            this.gb_Otchet.Controls.Add(this.tb_Metr_PPCBN);
            this.gb_Otchet.Controls.Add(this.tb_Per_PPCBN);
            this.gb_Otchet.Controls.Add(this.tb_Metr_Four);
            this.gb_Otchet.Controls.Add(this.tb_Per_Four);
            this.gb_Otchet.Controls.Add(this.tb_Metr_Three);
            this.gb_Otchet.Controls.Add(this.tb_Per_Three);
            this.gb_Otchet.Controls.Add(this.tb_Metr_Two);
            this.gb_Otchet.Controls.Add(this.tb_Per_Two);
            this.gb_Otchet.Controls.Add(this.tb_Metr_One);
            this.gb_Otchet.Controls.Add(this.tb_Per_One);
            this.gb_Otchet.Controls.Add(this.tb_Ploshad);
            this.gb_Otchet.Controls.Add(this.lbl_Ploshad);
            this.gb_Otchet.Controls.Add(this.tb_Kol);
            this.gb_Otchet.Controls.Add(this.lbl_Kol);
            this.gb_Otchet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Otchet.Location = new System.Drawing.Point(3, 303);
            this.gb_Otchet.Name = "gb_Otchet";
            this.gb_Otchet.Size = new System.Drawing.Size(770, 229);
            this.gb_Otchet.TabIndex = 1;
            this.gb_Otchet.TabStop = false;
            this.gb_Otchet.Text = "Сведения о выявленных отклонениях";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(673, 200);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 25);
            this.btn_Delete.TabIndex = 31;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(573, 200);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 25);
            this.btn_Update.TabIndex = 30;
            this.btn_Update.Text = "Изменить";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(473, 200);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 25);
            this.btn_Insert.TabIndex = 29;
            this.btn_Insert.Text = "Добавить";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // lbl_Metr_Four
            // 
            this.lbl_Metr_Four.AutoSize = true;
            this.lbl_Metr_Four.Location = new System.Drawing.Point(454, 113);
            this.lbl_Metr_Four.Name = "lbl_Metr_Four";
            this.lbl_Metr_Four.Size = new System.Drawing.Size(118, 13);
            this.lbl_Metr_Four.TabIndex = 28;
            this.lbl_Metr_Four.Text = "4-му параметру, кв.м:";
            // 
            // lbl_Metr_Three
            // 
            this.lbl_Metr_Three.AutoSize = true;
            this.lbl_Metr_Three.Location = new System.Drawing.Point(454, 53);
            this.lbl_Metr_Three.Name = "lbl_Metr_Three";
            this.lbl_Metr_Three.Size = new System.Drawing.Size(118, 13);
            this.lbl_Metr_Three.TabIndex = 27;
            this.lbl_Metr_Three.Text = "3-му параметру, кв.м:";
            // 
            // lbl_Metr_PPCBN
            // 
            this.lbl_Metr_PPCBN.AutoSize = true;
            this.lbl_Metr_PPCBN.Location = new System.Drawing.Point(388, 173);
            this.lbl_Metr_PPCBN.Name = "lbl_Metr_PPCBN";
            this.lbl_Metr_PPCBN.Size = new System.Drawing.Size(184, 13);
            this.lbl_Metr_PPCBN.TabIndex = 26;
            this.lbl_Metr_PPCBN.Text = "Площадь ПЧ без нарушений, кв.м:";
            this.lbl_Metr_PPCBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PPCBN_Percent
            // 
            this.lbl_PPCBN_Percent.AutoSize = true;
            this.lbl_PPCBN_Percent.Location = new System.Drawing.Point(403, 143);
            this.lbl_PPCBN_Percent.Name = "lbl_PPCBN_Percent";
            this.lbl_PPCBN_Percent.Size = new System.Drawing.Size(169, 13);
            this.lbl_PPCBN_Percent.TabIndex = 25;
            this.lbl_PPCBN_Percent.Text = "Площадь ПЧ без нарушений, %:";
            this.lbl_PPCBN_Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Four_Percent
            // 
            this.lbl_Four_Percent.AutoSize = true;
            this.lbl_Four_Percent.Location = new System.Drawing.Point(469, 83);
            this.lbl_Four_Percent.Name = "lbl_Four_Percent";
            this.lbl_Four_Percent.Size = new System.Drawing.Size(103, 13);
            this.lbl_Four_Percent.TabIndex = 24;
            this.lbl_Four_Percent.Text = "4-му параметру, %:";
            // 
            // lbl_Three_Percent
            // 
            this.lbl_Three_Percent.AutoSize = true;
            this.lbl_Three_Percent.Location = new System.Drawing.Point(469, 23);
            this.lbl_Three_Percent.Name = "lbl_Three_Percent";
            this.lbl_Three_Percent.Size = new System.Drawing.Size(103, 13);
            this.lbl_Three_Percent.TabIndex = 23;
            this.lbl_Three_Percent.Text = "3-му параметру, %:";
            // 
            // lbl_Two_Percent
            // 
            this.lbl_Two_Percent.AutoSize = true;
            this.lbl_Two_Percent.Location = new System.Drawing.Point(100, 143);
            this.lbl_Two_Percent.Name = "lbl_Two_Percent";
            this.lbl_Two_Percent.Size = new System.Drawing.Size(103, 13);
            this.lbl_Two_Percent.TabIndex = 22;
            this.lbl_Two_Percent.Text = "2-му параметру, %:";
            // 
            // lbl_Metr_Two
            // 
            this.lbl_Metr_Two.AutoSize = true;
            this.lbl_Metr_Two.Location = new System.Drawing.Point(85, 173);
            this.lbl_Metr_Two.Name = "lbl_Metr_Two";
            this.lbl_Metr_Two.Size = new System.Drawing.Size(118, 13);
            this.lbl_Metr_Two.TabIndex = 20;
            this.lbl_Metr_Two.Text = "2-му параметру, кв.м:";
            // 
            // lbl_Metr_One
            // 
            this.lbl_Metr_One.AutoSize = true;
            this.lbl_Metr_One.Location = new System.Drawing.Point(85, 113);
            this.lbl_Metr_One.Name = "lbl_Metr_One";
            this.lbl_Metr_One.Size = new System.Drawing.Size(118, 13);
            this.lbl_Metr_One.TabIndex = 18;
            this.lbl_Metr_One.Text = "1-му параметру, кв.м:";
            // 
            // lbl_One_Percent
            // 
            this.lbl_One_Percent.AutoSize = true;
            this.lbl_One_Percent.Location = new System.Drawing.Point(100, 83);
            this.lbl_One_Percent.Name = "lbl_One_Percent";
            this.lbl_One_Percent.Size = new System.Drawing.Size(103, 13);
            this.lbl_One_Percent.TabIndex = 17;
            this.lbl_One_Percent.Text = "1-му параметру, %:";
            // 
            // tb_Metr_PPCBN
            // 
            this.tb_Metr_PPCBN.Enabled = false;
            this.tb_Metr_PPCBN.Location = new System.Drawing.Point(578, 170);
            this.tb_Metr_PPCBN.Name = "tb_Metr_PPCBN";
            this.tb_Metr_PPCBN.Size = new System.Drawing.Size(170, 20);
            this.tb_Metr_PPCBN.TabIndex = 16;
            // 
            // tb_Per_PPCBN
            // 
            this.tb_Per_PPCBN.Enabled = false;
            this.tb_Per_PPCBN.Location = new System.Drawing.Point(578, 140);
            this.tb_Per_PPCBN.Name = "tb_Per_PPCBN";
            this.tb_Per_PPCBN.Size = new System.Drawing.Size(170, 20);
            this.tb_Per_PPCBN.TabIndex = 15;
            // 
            // tb_Metr_Four
            // 
            this.tb_Metr_Four.Enabled = false;
            this.tb_Metr_Four.Location = new System.Drawing.Point(578, 110);
            this.tb_Metr_Four.Name = "tb_Metr_Four";
            this.tb_Metr_Four.Size = new System.Drawing.Size(170, 20);
            this.tb_Metr_Four.TabIndex = 14;
            // 
            // tb_Per_Four
            // 
            this.tb_Per_Four.Enabled = false;
            this.tb_Per_Four.Location = new System.Drawing.Point(578, 80);
            this.tb_Per_Four.Name = "tb_Per_Four";
            this.tb_Per_Four.Size = new System.Drawing.Size(170, 20);
            this.tb_Per_Four.TabIndex = 13;
            // 
            // tb_Metr_Three
            // 
            this.tb_Metr_Three.Enabled = false;
            this.tb_Metr_Three.Location = new System.Drawing.Point(578, 50);
            this.tb_Metr_Three.Name = "tb_Metr_Three";
            this.tb_Metr_Three.Size = new System.Drawing.Size(170, 20);
            this.tb_Metr_Three.TabIndex = 12;
            // 
            // tb_Per_Three
            // 
            this.tb_Per_Three.Enabled = false;
            this.tb_Per_Three.Location = new System.Drawing.Point(578, 20);
            this.tb_Per_Three.Name = "tb_Per_Three";
            this.tb_Per_Three.Size = new System.Drawing.Size(170, 20);
            this.tb_Per_Three.TabIndex = 11;
            // 
            // tb_Metr_Two
            // 
            this.tb_Metr_Two.Enabled = false;
            this.tb_Metr_Two.Location = new System.Drawing.Point(209, 170);
            this.tb_Metr_Two.Name = "tb_Metr_Two";
            this.tb_Metr_Two.Size = new System.Drawing.Size(170, 20);
            this.tb_Metr_Two.TabIndex = 10;
            // 
            // tb_Per_Two
            // 
            this.tb_Per_Two.Enabled = false;
            this.tb_Per_Two.Location = new System.Drawing.Point(209, 140);
            this.tb_Per_Two.Name = "tb_Per_Two";
            this.tb_Per_Two.Size = new System.Drawing.Size(170, 20);
            this.tb_Per_Two.TabIndex = 9;
            // 
            // tb_Metr_One
            // 
            this.tb_Metr_One.Enabled = false;
            this.tb_Metr_One.Location = new System.Drawing.Point(209, 110);
            this.tb_Metr_One.Name = "tb_Metr_One";
            this.tb_Metr_One.Size = new System.Drawing.Size(170, 20);
            this.tb_Metr_One.TabIndex = 8;
            // 
            // tb_Per_One
            // 
            this.tb_Per_One.Enabled = false;
            this.tb_Per_One.Location = new System.Drawing.Point(209, 80);
            this.tb_Per_One.Name = "tb_Per_One";
            this.tb_Per_One.Size = new System.Drawing.Size(170, 20);
            this.tb_Per_One.TabIndex = 7;
            // 
            // tb_Ploshad
            // 
            this.tb_Ploshad.Enabled = false;
            this.tb_Ploshad.Location = new System.Drawing.Point(209, 50);
            this.tb_Ploshad.Name = "tb_Ploshad";
            this.tb_Ploshad.Size = new System.Drawing.Size(170, 20);
            this.tb_Ploshad.TabIndex = 6;
            // 
            // lbl_Ploshad
            // 
            this.lbl_Ploshad.AutoSize = true;
            this.lbl_Ploshad.Location = new System.Drawing.Point(33, 53);
            this.lbl_Ploshad.Name = "lbl_Ploshad";
            this.lbl_Ploshad.Size = new System.Drawing.Size(170, 13);
            this.lbl_Ploshad.TabIndex = 6;
            this.lbl_Ploshad.Text = "Площадь проезжей части, кв.м:";
            // 
            // tb_Kol
            // 
            this.tb_Kol.Enabled = false;
            this.tb_Kol.Location = new System.Drawing.Point(209, 20);
            this.tb_Kol.Name = "tb_Kol";
            this.tb_Kol.Size = new System.Drawing.Size(170, 20);
            this.tb_Kol.TabIndex = 5;
            // 
            // lbl_Kol
            // 
            this.lbl_Kol.AutoSize = true;
            this.lbl_Kol.Location = new System.Drawing.Point(10, 23);
            this.lbl_Kol.Name = "lbl_Kol";
            this.lbl_Kol.Size = new System.Drawing.Size(193, 13);
            this.lbl_Kol.TabIndex = 4;
            this.lbl_Kol.Text = "Количество дорожных объектов, шт:";
            // 
            // dgv_Otchet
            // 
            this.dgv_Otchet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Otchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Otchet.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Otchet.Location = new System.Drawing.Point(3, 3);
            this.dgv_Otchet.Name = "dgv_Otchet";
            this.dgv_Otchet.ReadOnly = true;
            this.dgv_Otchet.Size = new System.Drawing.Size(770, 300);
            this.dgv_Otchet.TabIndex = 0;
            this.dgv_Otchet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Otchet_CellClick);
            // 
            // Form_Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tc_Otchet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Otchet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отчёт по анализу";
            this.Load += new System.EventHandler(this.Form_Otchet_Load);
            this.tc_Otchet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb_Otchet.ResumeLayout(false);
            this.gb_Otchet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Otchet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Otchet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_Otchet;
        private System.Windows.Forms.GroupBox gb_Otchet;
        private System.Windows.Forms.TextBox tb_Ploshad;
        private System.Windows.Forms.Label lbl_Ploshad;
        private System.Windows.Forms.TextBox tb_Kol;
        private System.Windows.Forms.Label lbl_Kol;
        private System.Windows.Forms.Label lbl_Metr_Four;
        private System.Windows.Forms.Label lbl_Metr_Three;
        private System.Windows.Forms.Label lbl_Metr_PPCBN;
        private System.Windows.Forms.Label lbl_PPCBN_Percent;
        private System.Windows.Forms.Label lbl_Four_Percent;
        private System.Windows.Forms.Label lbl_Three_Percent;
        private System.Windows.Forms.Label lbl_Two_Percent;
        private System.Windows.Forms.Label lbl_Metr_Two;
        private System.Windows.Forms.Label lbl_Metr_One;
        private System.Windows.Forms.Label lbl_One_Percent;
        private System.Windows.Forms.TextBox tb_Metr_PPCBN;
        private System.Windows.Forms.TextBox tb_Per_PPCBN;
        private System.Windows.Forms.TextBox tb_Metr_Four;
        private System.Windows.Forms.TextBox tb_Per_Four;
        private System.Windows.Forms.TextBox tb_Metr_Three;
        private System.Windows.Forms.TextBox tb_Per_Three;
        private System.Windows.Forms.TextBox tb_Metr_Two;
        private System.Windows.Forms.TextBox tb_Per_Two;
        private System.Windows.Forms.TextBox tb_Metr_One;
        private System.Windows.Forms.TextBox tb_Per_One;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
    }
}