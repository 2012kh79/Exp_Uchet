namespace SiPPOON_PP.Forms
{
    partial class Form_Uchet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Uchet));
            this.dgv_Uchet = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.округаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеОбъектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_Uchet = new System.Windows.Forms.GroupBox();
            this.btn_Word = new System.Windows.Forms.Button();
            this.gb_FIlter_Uchet = new System.Windows.Forms.GroupBox();
            this.rb_Clear_Filter = new System.Windows.Forms.RadioButton();
            this.rb_Filter_Data = new System.Windows.Forms.RadioButton();
            this.rb_Filter_Sotrudnik = new System.Windows.Forms.RadioButton();
            this.lbl_Sotrudnik = new System.Windows.Forms.Label();
            this.cmb_Filter_Sotrudnik = new System.Windows.Forms.ComboBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.mtb_Data_Uchet = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Proveril = new System.Windows.Forms.TextBox();
            this.lbl_Proveril = new System.Windows.Forms.Label();
            this.mc_Uchet = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uchet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gb_Uchet.SuspendLayout();
            this.gb_FIlter_Uchet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Uchet
            // 
            this.dgv_Uchet.AllowUserToAddRows = false;
            this.dgv_Uchet.AllowUserToDeleteRows = false;
            this.dgv_Uchet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Uchet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Uchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Uchet.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Uchet.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Uchet.Location = new System.Drawing.Point(0, 24);
            this.dgv_Uchet.Name = "dgv_Uchet";
            this.dgv_Uchet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_Uchet.Size = new System.Drawing.Size(784, 348);
            this.dgv_Uchet.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.категорииToolStripMenuItem,
            this.округаToolStripMenuItem,
            this.всеОбъектыToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.категорииToolStripMenuItem.Text = "Категории";
            this.категорииToolStripMenuItem.Click += new System.EventHandler(this.категорииToolStripMenuItem_Click);
            // 
            // округаToolStripMenuItem
            // 
            this.округаToolStripMenuItem.Name = "округаToolStripMenuItem";
            this.округаToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.округаToolStripMenuItem.Text = "Округа";
            this.округаToolStripMenuItem.Click += new System.EventHandler(this.округаToolStripMenuItem_Click);
            // 
            // всеОбъектыToolStripMenuItem
            // 
            this.всеОбъектыToolStripMenuItem.Name = "всеОбъектыToolStripMenuItem";
            this.всеОбъектыToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.всеОбъектыToolStripMenuItem.Text = "Все объекты";
            this.всеОбъектыToolStripMenuItem.Click += new System.EventHandler(this.всеОбъектыToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // gb_Uchet
            // 
            this.gb_Uchet.Controls.Add(this.btn_Word);
            this.gb_Uchet.Controls.Add(this.gb_FIlter_Uchet);
            this.gb_Uchet.Controls.Add(this.mtb_Data_Uchet);
            this.gb_Uchet.Controls.Add(this.label2);
            this.gb_Uchet.Controls.Add(this.tb_Proveril);
            this.gb_Uchet.Controls.Add(this.lbl_Proveril);
            this.gb_Uchet.Controls.Add(this.mc_Uchet);
            this.gb_Uchet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Uchet.Location = new System.Drawing.Point(0, 372);
            this.gb_Uchet.Name = "gb_Uchet";
            this.gb_Uchet.Size = new System.Drawing.Size(784, 189);
            this.gb_Uchet.TabIndex = 7;
            this.gb_Uchet.TabStop = false;
            this.gb_Uchet.Text = "Работа с учетными документами";
            // 
            // btn_Word
            // 
            this.btn_Word.BackgroundImage = global::SiPPOON_PP.Properties.Resources.Word;
            this.btn_Word.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Word.Location = new System.Drawing.Point(645, 90);
            this.btn_Word.Name = "btn_Word";
            this.btn_Word.Size = new System.Drawing.Size(90, 80);
            this.btn_Word.TabIndex = 0;
            this.btn_Word.UseVisualStyleBackColor = true;
            this.btn_Word.Click += new System.EventHandler(this.btn_Word_Click);
            // 
            // gb_FIlter_Uchet
            // 
            this.gb_FIlter_Uchet.Controls.Add(this.rb_Clear_Filter);
            this.gb_FIlter_Uchet.Controls.Add(this.rb_Filter_Data);
            this.gb_FIlter_Uchet.Controls.Add(this.rb_Filter_Sotrudnik);
            this.gb_FIlter_Uchet.Controls.Add(this.lbl_Sotrudnik);
            this.gb_FIlter_Uchet.Controls.Add(this.cmb_Filter_Sotrudnik);
            this.gb_FIlter_Uchet.Controls.Add(this.tb_Search);
            this.gb_FIlter_Uchet.Controls.Add(this.lbl_Search);
            this.gb_FIlter_Uchet.Location = new System.Drawing.Point(202, 20);
            this.gb_FIlter_Uchet.Name = "gb_FIlter_Uchet";
            this.gb_FIlter_Uchet.Size = new System.Drawing.Size(372, 100);
            this.gb_FIlter_Uchet.TabIndex = 10;
            this.gb_FIlter_Uchet.TabStop = false;
            this.gb_FIlter_Uchet.Text = "Фильтр по:";
            // 
            // rb_Clear_Filter
            // 
            this.rb_Clear_Filter.AutoSize = true;
            this.rb_Clear_Filter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Clear_Filter.Checked = true;
            this.rb_Clear_Filter.Location = new System.Drawing.Point(220, 75);
            this.rb_Clear_Filter.Name = "rb_Clear_Filter";
            this.rb_Clear_Filter.Size = new System.Drawing.Size(115, 17);
            this.rb_Clear_Filter.TabIndex = 18;
            this.rb_Clear_Filter.TabStop = true;
            this.rb_Clear_Filter.Text = "Очистить фильтр:";
            this.rb_Clear_Filter.UseVisualStyleBackColor = true;
            this.rb_Clear_Filter.CheckedChanged += new System.EventHandler(this.rb_Clear_Filter_CheckedChanged);
            // 
            // rb_Filter_Data
            // 
            this.rb_Filter_Data.AutoSize = true;
            this.rb_Filter_Data.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Filter_Data.Location = new System.Drawing.Point(48, 75);
            this.rb_Filter_Data.Name = "rb_Filter_Data";
            this.rb_Filter_Data.Size = new System.Drawing.Size(54, 17);
            this.rb_Filter_Data.TabIndex = 17;
            this.rb_Filter_Data.Text = "Дате:";
            this.rb_Filter_Data.UseVisualStyleBackColor = true;
            this.rb_Filter_Data.CheckedChanged += new System.EventHandler(this.rb_Filter_Data_CheckedChanged);
            // 
            // rb_Filter_Sotrudnik
            // 
            this.rb_Filter_Sotrudnik.AutoSize = true;
            this.rb_Filter_Sotrudnik.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Filter_Sotrudnik.Location = new System.Drawing.Point(120, 75);
            this.rb_Filter_Sotrudnik.Name = "rb_Filter_Sotrudnik";
            this.rb_Filter_Sotrudnik.Size = new System.Drawing.Size(82, 17);
            this.rb_Filter_Sotrudnik.TabIndex = 16;
            this.rb_Filter_Sotrudnik.Text = "Состояние:";
            this.rb_Filter_Sotrudnik.UseVisualStyleBackColor = true;
            this.rb_Filter_Sotrudnik.CheckedChanged += new System.EventHandler(this.rb_Filter_Sotrudnik_CheckedChanged);
            // 
            // lbl_Sotrudnik
            // 
            this.lbl_Sotrudnik.AutoSize = true;
            this.lbl_Sotrudnik.Location = new System.Drawing.Point(15, 50);
            this.lbl_Sotrudnik.Name = "lbl_Sotrudnik";
            this.lbl_Sotrudnik.Size = new System.Drawing.Size(68, 13);
            this.lbl_Sotrudnik.TabIndex = 14;
            this.lbl_Sotrudnik.Text = "Сотруднику:";
            // 
            // cmb_Filter_Sotrudnik
            // 
            this.cmb_Filter_Sotrudnik.FormattingEnabled = true;
            this.cmb_Filter_Sotrudnik.Location = new System.Drawing.Point(89, 47);
            this.cmb_Filter_Sotrudnik.Name = "cmb_Filter_Sotrudnik";
            this.cmb_Filter_Sotrudnik.Size = new System.Drawing.Size(263, 21);
            this.cmb_Filter_Sotrudnik.TabIndex = 13;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(89, 17);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(263, 20);
            this.tb_Search.TabIndex = 7;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(41, 20);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(42, 13);
            this.lbl_Search.TabIndex = 6;
            this.lbl_Search.Text = "Поиск:";
            // 
            // mtb_Data_Uchet
            // 
            this.mtb_Data_Uchet.Enabled = false;
            this.mtb_Data_Uchet.Location = new System.Drawing.Point(614, 57);
            this.mtb_Data_Uchet.Mask = "00/00/0000-00/00/0000";
            this.mtb_Data_Uchet.Name = "mtb_Data_Uchet";
            this.mtb_Data_Uchet.Size = new System.Drawing.Size(155, 20);
            this.mtb_Data_Uchet.TabIndex = 9;
            this.mtb_Data_Uchet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_Data_Uchet.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "от:";
            // 
            // tb_Proveril
            // 
            this.tb_Proveril.Enabled = false;
            this.tb_Proveril.Location = new System.Drawing.Point(285, 130);
            this.tb_Proveril.Name = "tb_Proveril";
            this.tb_Proveril.Size = new System.Drawing.Size(289, 20);
            this.tb_Proveril.TabIndex = 5;
            // 
            // lbl_Proveril
            // 
            this.lbl_Proveril.AutoSize = true;
            this.lbl_Proveril.Location = new System.Drawing.Point(219, 133);
            this.lbl_Proveril.Name = "lbl_Proveril";
            this.lbl_Proveril.Size = new System.Drawing.Size(60, 13);
            this.lbl_Proveril.TabIndex = 4;
            this.lbl_Proveril.Text = "Проверил:";
            // 
            // mc_Uchet
            // 
            this.mc_Uchet.Location = new System.Drawing.Point(18, 20);
            this.mc_Uchet.MaxSelectionCount = 15;
            this.mc_Uchet.Name = "mc_Uchet";
            this.mc_Uchet.TabIndex = 3;
            this.mc_Uchet.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_Uchet_DateChanged);
            // 
            // Form_Uchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gb_Uchet);
            this.Controls.Add(this.dgv_Uchet);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Uchet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт объектов дорожного хозяйства";
            this.Load += new System.EventHandler(this.Form_Uchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uchet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_Uchet.ResumeLayout(false);
            this.gb_Uchet.PerformLayout();
            this.gb_FIlter_Uchet.ResumeLayout(false);
            this.gb_FIlter_Uchet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Uchet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem округаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.GroupBox gb_Uchet;
        private System.Windows.Forms.TextBox tb_Proveril;
        private System.Windows.Forms.Label lbl_Proveril;
        private System.Windows.Forms.MonthCalendar mc_Uchet;
        private System.Windows.Forms.GroupBox gb_FIlter_Uchet;
        private System.Windows.Forms.MaskedTextBox mtb_Data_Uchet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.ToolStripMenuItem всеОбъектыToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Sotrudnik;
        private System.Windows.Forms.ComboBox cmb_Filter_Sotrudnik;
        private System.Windows.Forms.RadioButton rb_Filter_Sotrudnik;
        private System.Windows.Forms.RadioButton rb_Filter_Data;
        private System.Windows.Forms.RadioButton rb_Clear_Filter;
        private System.Windows.Forms.Button btn_Word;
    }
}