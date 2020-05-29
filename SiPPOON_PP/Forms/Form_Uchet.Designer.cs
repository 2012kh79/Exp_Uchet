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
            this.категорияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.категорияToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.категорияToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.категорияToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.категорияToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.округаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зелАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сВАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сЗАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиНАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.юАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.юВАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.юЗАОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_Uchet = new System.Windows.Forms.GroupBox();
            this.gb_Export_Otchet = new System.Windows.Forms.GroupBox();
            this.btn_PDF = new System.Windows.Forms.Button();
            this.btn_Word = new System.Windows.Forms.Button();
            this.mc_Uchet = new System.Windows.Forms.MonthCalendar();
            this.lbl_Proveril = new System.Windows.Forms.Label();
            this.tb_Proveril = new System.Windows.Forms.TextBox();
            this.tb_Comment = new System.Windows.Forms.TextBox();
            this.lbl_Comment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_Data_Uchet = new System.Windows.Forms.MaskedTextBox();
            this.gb_FIlter_Uchet = new System.Windows.Forms.GroupBox();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вКОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Kol_Object = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ploshad_Object = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent_One = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metr_One = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent_Two = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metr_Two = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent_Three = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metr_Three = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent_Four = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metr_Four = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent_PPCBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metr_PPCBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uchet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gb_Uchet.SuspendLayout();
            this.gb_Export_Otchet.SuspendLayout();
            this.gb_FIlter_Uchet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Uchet
            // 
            this.dgv_Uchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Uchet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kol_Object,
            this.Ploshad_Object,
            this.Percent_One,
            this.Metr_One,
            this.Percent_Two,
            this.Metr_Two,
            this.Percent_Three,
            this.Metr_Three,
            this.Percent_Four,
            this.Metr_Four,
            this.Percent_PPCBN,
            this.Metr_PPCBN});
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
            this.печатьToolStripMenuItem,
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
            this.округаToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.категорияToolStripMenuItem,
            this.категорияToolStripMenuItem1,
            this.категорияToolStripMenuItem2,
            this.категорияToolStripMenuItem3,
            this.категорияToolStripMenuItem4,
            this.категорияToolStripMenuItem5,
            this.вКОToolStripMenuItem});
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.категорииToolStripMenuItem.Text = "Категории";
            // 
            // категорияToolStripMenuItem
            // 
            this.категорияToolStripMenuItem.Name = "категорияToolStripMenuItem";
            this.категорияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.категорияToolStripMenuItem.Text = "1 категория";
            this.категорияToolStripMenuItem.Click += new System.EventHandler(this.категорияToolStripMenuItem_Click);
            // 
            // категорияToolStripMenuItem1
            // 
            this.категорияToolStripMenuItem1.Name = "категорияToolStripMenuItem1";
            this.категорияToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.категорияToolStripMenuItem1.Text = "2 категория";
            this.категорияToolStripMenuItem1.Click += new System.EventHandler(this.категорияToolStripMenuItem1_Click);
            // 
            // категорияToolStripMenuItem2
            // 
            this.категорияToolStripMenuItem2.Name = "категорияToolStripMenuItem2";
            this.категорияToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.категорияToolStripMenuItem2.Text = "3 категория";
            this.категорияToolStripMenuItem2.Click += new System.EventHandler(this.категорияToolStripMenuItem2_Click);
            // 
            // категорияToolStripMenuItem3
            // 
            this.категорияToolStripMenuItem3.Name = "категорияToolStripMenuItem3";
            this.категорияToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.категорияToolStripMenuItem3.Text = "4 категория";
            this.категорияToolStripMenuItem3.Click += new System.EventHandler(this.категорияToolStripMenuItem3_Click);
            // 
            // категорияToolStripMenuItem4
            // 
            this.категорияToolStripMenuItem4.Name = "категорияToolStripMenuItem4";
            this.категорияToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.категорияToolStripMenuItem4.Text = "5 категория";
            this.категорияToolStripMenuItem4.Click += new System.EventHandler(this.категорияToolStripMenuItem4_Click);
            // 
            // категорияToolStripMenuItem5
            // 
            this.категорияToolStripMenuItem5.Name = "категорияToolStripMenuItem5";
            this.категорияToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.категорияToolStripMenuItem5.Text = "6 категория";
            this.категорияToolStripMenuItem5.Click += new System.EventHandler(this.категорияToolStripMenuItem5_Click);
            // 
            // округаToolStripMenuItem
            // 
            this.округаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вАОToolStripMenuItem,
            this.зАОToolStripMenuItem,
            this.зелАОToolStripMenuItem,
            this.сАОToolStripMenuItem,
            this.сВАОToolStripMenuItem,
            this.сЗАОToolStripMenuItem,
            this.тиНАОToolStripMenuItem,
            this.цАОToolStripMenuItem,
            this.юАОToolStripMenuItem,
            this.юВАОToolStripMenuItem,
            this.юЗАОToolStripMenuItem});
            this.округаToolStripMenuItem.Name = "округаToolStripMenuItem";
            this.округаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.округаToolStripMenuItem.Text = "Округа";
            // 
            // вАОToolStripMenuItem
            // 
            this.вАОToolStripMenuItem.Name = "вАОToolStripMenuItem";
            this.вАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вАОToolStripMenuItem.Text = "ВАО";
            this.вАОToolStripMenuItem.Click += new System.EventHandler(this.вАОToolStripMenuItem_Click);
            // 
            // зАОToolStripMenuItem
            // 
            this.зАОToolStripMenuItem.Name = "зАОToolStripMenuItem";
            this.зАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зАОToolStripMenuItem.Text = "ЗАО";
            this.зАОToolStripMenuItem.Click += new System.EventHandler(this.зАОToolStripMenuItem_Click);
            // 
            // зелАОToolStripMenuItem
            // 
            this.зелАОToolStripMenuItem.Name = "зелАОToolStripMenuItem";
            this.зелАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зелАОToolStripMenuItem.Text = "ЗелАО";
            this.зелАОToolStripMenuItem.Click += new System.EventHandler(this.зелАОToolStripMenuItem_Click);
            // 
            // сАОToolStripMenuItem
            // 
            this.сАОToolStripMenuItem.Name = "сАОToolStripMenuItem";
            this.сАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сАОToolStripMenuItem.Text = "САО";
            this.сАОToolStripMenuItem.Click += new System.EventHandler(this.сАОToolStripMenuItem_Click);
            // 
            // сВАОToolStripMenuItem
            // 
            this.сВАОToolStripMenuItem.Name = "сВАОToolStripMenuItem";
            this.сВАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сВАОToolStripMenuItem.Text = "СВАО";
            this.сВАОToolStripMenuItem.Click += new System.EventHandler(this.сВАОToolStripMenuItem_Click);
            // 
            // сЗАОToolStripMenuItem
            // 
            this.сЗАОToolStripMenuItem.Name = "сЗАОToolStripMenuItem";
            this.сЗАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сЗАОToolStripMenuItem.Text = "СЗАО";
            this.сЗАОToolStripMenuItem.Click += new System.EventHandler(this.сЗАОToolStripMenuItem_Click);
            // 
            // тиНАОToolStripMenuItem
            // 
            this.тиНАОToolStripMenuItem.Name = "тиНАОToolStripMenuItem";
            this.тиНАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тиНАОToolStripMenuItem.Text = "ТиНАО";
            this.тиНАОToolStripMenuItem.Click += new System.EventHandler(this.тиНАОToolStripMenuItem_Click);
            // 
            // цАОToolStripMenuItem
            // 
            this.цАОToolStripMenuItem.Name = "цАОToolStripMenuItem";
            this.цАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.цАОToolStripMenuItem.Text = "ЦАО";
            this.цАОToolStripMenuItem.Click += new System.EventHandler(this.цАОToolStripMenuItem_Click);
            // 
            // юАОToolStripMenuItem
            // 
            this.юАОToolStripMenuItem.Name = "юАОToolStripMenuItem";
            this.юАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.юАОToolStripMenuItem.Text = "ЮАО";
            this.юАОToolStripMenuItem.Click += new System.EventHandler(this.юАОToolStripMenuItem_Click);
            // 
            // юВАОToolStripMenuItem
            // 
            this.юВАОToolStripMenuItem.Name = "юВАОToolStripMenuItem";
            this.юВАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.юВАОToolStripMenuItem.Text = "ЮВАО";
            this.юВАОToolStripMenuItem.Click += new System.EventHandler(this.юВАОToolStripMenuItem_Click);
            // 
            // юЗАОToolStripMenuItem
            // 
            this.юЗАОToolStripMenuItem.Name = "юЗАОToolStripMenuItem";
            this.юЗАОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.юЗАОToolStripMenuItem.Text = "ЮЗАО";
            this.юЗАОToolStripMenuItem.Click += new System.EventHandler(this.юЗАОToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеToolStripMenuItem,
            this.выдеToolStripMenuItem});
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // всеToolStripMenuItem
            // 
            this.всеToolStripMenuItem.Name = "всеToolStripMenuItem";
            this.всеToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.всеToolStripMenuItem.Text = "Все";
            // 
            // выдеToolStripMenuItem
            // 
            this.выдеToolStripMenuItem.Name = "выдеToolStripMenuItem";
            this.выдеToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.выдеToolStripMenuItem.Text = "Выделенный объект";
            // 
            // gb_Uchet
            // 
            this.gb_Uchet.Controls.Add(this.gb_FIlter_Uchet);
            this.gb_Uchet.Controls.Add(this.mtb_Data_Uchet);
            this.gb_Uchet.Controls.Add(this.label2);
            this.gb_Uchet.Controls.Add(this.tb_Comment);
            this.gb_Uchet.Controls.Add(this.lbl_Comment);
            this.gb_Uchet.Controls.Add(this.tb_Proveril);
            this.gb_Uchet.Controls.Add(this.lbl_Proveril);
            this.gb_Uchet.Controls.Add(this.mc_Uchet);
            this.gb_Uchet.Controls.Add(this.gb_Export_Otchet);
            this.gb_Uchet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Uchet.Location = new System.Drawing.Point(0, 372);
            this.gb_Uchet.Name = "gb_Uchet";
            this.gb_Uchet.Size = new System.Drawing.Size(784, 189);
            this.gb_Uchet.TabIndex = 7;
            this.gb_Uchet.TabStop = false;
            this.gb_Uchet.Text = "Работа с учетными документами";
            // 
            // gb_Export_Otchet
            // 
            this.gb_Export_Otchet.Controls.Add(this.btn_PDF);
            this.gb_Export_Otchet.Controls.Add(this.btn_Word);
            this.gb_Export_Otchet.Location = new System.Drawing.Point(587, 83);
            this.gb_Export_Otchet.Name = "gb_Export_Otchet";
            this.gb_Export_Otchet.Size = new System.Drawing.Size(185, 100);
            this.gb_Export_Otchet.TabIndex = 2;
            this.gb_Export_Otchet.TabStop = false;
            this.gb_Export_Otchet.Text = "Сформировать отчёт в: ";
            // 
            // btn_PDF
            // 
            this.btn_PDF.BackgroundImage = global::SiPPOON_PP.Properties.Resources.PDF;
            this.btn_PDF.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_PDF.Location = new System.Drawing.Point(92, 16);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.Size = new System.Drawing.Size(90, 81);
            this.btn_PDF.TabIndex = 1;
            this.btn_PDF.UseVisualStyleBackColor = true;
            // 
            // btn_Word
            // 
            this.btn_Word.BackgroundImage = global::SiPPOON_PP.Properties.Resources.Word;
            this.btn_Word.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Word.Location = new System.Drawing.Point(3, 16);
            this.btn_Word.Name = "btn_Word";
            this.btn_Word.Size = new System.Drawing.Size(90, 81);
            this.btn_Word.TabIndex = 0;
            this.btn_Word.UseVisualStyleBackColor = true;
            // 
            // mc_Uchet
            // 
            this.mc_Uchet.Location = new System.Drawing.Point(18, 20);
            this.mc_Uchet.Name = "mc_Uchet";
            this.mc_Uchet.TabIndex = 3;
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
            // tb_Proveril
            // 
            this.tb_Proveril.Location = new System.Drawing.Point(285, 130);
            this.tb_Proveril.Name = "tb_Proveril";
            this.tb_Proveril.Size = new System.Drawing.Size(289, 20);
            this.tb_Proveril.TabIndex = 5;
            // 
            // tb_Comment
            // 
            this.tb_Comment.Location = new System.Drawing.Point(285, 160);
            this.tb_Comment.Name = "tb_Comment";
            this.tb_Comment.Size = new System.Drawing.Size(289, 20);
            this.tb_Comment.TabIndex = 7;
            // 
            // lbl_Comment
            // 
            this.lbl_Comment.AutoSize = true;
            this.lbl_Comment.Location = new System.Drawing.Point(199, 163);
            this.lbl_Comment.Name = "lbl_Comment";
            this.lbl_Comment.Size = new System.Drawing.Size(80, 13);
            this.lbl_Comment.TabIndex = 6;
            this.lbl_Comment.Text = "Комментарий:";
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
            // mtb_Data_Uchet
            // 
            this.mtb_Data_Uchet.Location = new System.Drawing.Point(614, 57);
            this.mtb_Data_Uchet.Mask = "00/00/0000-00/00/0000";
            this.mtb_Data_Uchet.Name = "mtb_Data_Uchet";
            this.mtb_Data_Uchet.Size = new System.Drawing.Size(155, 20);
            this.mtb_Data_Uchet.TabIndex = 9;
            this.mtb_Data_Uchet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_Data_Uchet.ValidatingType = typeof(System.DateTime);
            // 
            // gb_FIlter_Uchet
            // 
            this.gb_FIlter_Uchet.Controls.Add(this.textBox1);
            this.gb_FIlter_Uchet.Controls.Add(this.lbl_Search);
            this.gb_FIlter_Uchet.Location = new System.Drawing.Point(202, 20);
            this.gb_FIlter_Uchet.Name = "gb_FIlter_Uchet";
            this.gb_FIlter_Uchet.Size = new System.Drawing.Size(372, 100);
            this.gb_FIlter_Uchet.TabIndex = 10;
            this.gb_FIlter_Uchet.TabStop = false;
            this.gb_FIlter_Uchet.Text = "Фильтр по:";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // вКОToolStripMenuItem
            // 
            this.вКОToolStripMenuItem.Name = "вКОToolStripMenuItem";
            this.вКОToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вКОToolStripMenuItem.Text = "ВКО";
            this.вКОToolStripMenuItem.Click += new System.EventHandler(this.вКОToolStripMenuItem_Click);
            // 
            // Kol_Object
            // 
            this.Kol_Object.HeaderText = "Количество объектов";
            this.Kol_Object.Name = "Kol_Object";
            this.Kol_Object.ReadOnly = true;
            // 
            // Ploshad_Object
            // 
            this.Ploshad_Object.HeaderText = "Площадь обследованных объектов, кв.м";
            this.Ploshad_Object.Name = "Ploshad_Object";
            this.Ploshad_Object.ReadOnly = true;
            // 
            // Percent_One
            // 
            this.Percent_One.HeaderText = "Площадь проезжей части с выявленными нарушениями. 1-му параметру, %";
            this.Percent_One.Name = "Percent_One";
            this.Percent_One.ReadOnly = true;
            // 
            // Metr_One
            // 
            this.Metr_One.HeaderText = "Площадь проезжей части с выявленными нарушениями. 1-му параметру, кв.м";
            this.Metr_One.Name = "Metr_One";
            this.Metr_One.ReadOnly = true;
            // 
            // Percent_Two
            // 
            this.Percent_Two.HeaderText = "Площадь проезжей части с выявленными нарушениями. 2-му параметру, %";
            this.Percent_Two.Name = "Percent_Two";
            this.Percent_Two.ReadOnly = true;
            // 
            // Metr_Two
            // 
            this.Metr_Two.HeaderText = "Площадь проезжей части с выявленными нарушениями. 2-му параметру, кв.м";
            this.Metr_Two.Name = "Metr_Two";
            this.Metr_Two.ReadOnly = true;
            // 
            // Percent_Three
            // 
            this.Percent_Three.HeaderText = "Площадь проезжей части с выявленными нарушениями. 3-му параметру, %";
            this.Percent_Three.Name = "Percent_Three";
            this.Percent_Three.ReadOnly = true;
            // 
            // Metr_Three
            // 
            this.Metr_Three.HeaderText = "Площадь проезжей части с выявленными нарушениями. 3-му параметру, кв.м";
            this.Metr_Three.Name = "Metr_Three";
            this.Metr_Three.ReadOnly = true;
            // 
            // Percent_Four
            // 
            this.Percent_Four.HeaderText = "Площадь проезжей части с выявленными нарушениями. 4-му параметру, %";
            this.Percent_Four.Name = "Percent_Four";
            this.Percent_Four.ReadOnly = true;
            // 
            // Metr_Four
            // 
            this.Metr_Four.HeaderText = "Площадь проезжей части с выявленными нарушениями. 4-му параметру, кв.м";
            this.Metr_Four.Name = "Metr_Four";
            this.Metr_Four.ReadOnly = true;
            // 
            // Percent_PPCBN
            // 
            this.Percent_PPCBN.HeaderText = "Площадь проезжей части без нарушений, %";
            this.Percent_PPCBN.Name = "Percent_PPCBN";
            this.Percent_PPCBN.ReadOnly = true;
            // 
            // Metr_PPCBN
            // 
            this.Metr_PPCBN.HeaderText = "Площадь проезжей части без нарушений, кв.м";
            this.Metr_PPCBN.Name = "Metr_PPCBN";
            this.Metr_PPCBN.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(15, 22);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(42, 13);
            this.lbl_Search.TabIndex = 6;
            this.lbl_Search.Text = "Поиск:";
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
            this.Name = "Form_Uchet";
            this.Text = "Учёт объектов дорожного хозяйства";
            this.Load += new System.EventHandler(this.Form_Uchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uchet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_Uchet.ResumeLayout(false);
            this.gb_Uchet.PerformLayout();
            this.gb_Export_Otchet.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem категорияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem категорияToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem категорияToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem категорияToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem категорияToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem округаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зелАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сВАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сЗАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиНАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem юАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem юВАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem юЗАОToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдеToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_Uchet;
        private System.Windows.Forms.GroupBox gb_Export_Otchet;
        private System.Windows.Forms.Button btn_PDF;
        private System.Windows.Forms.Button btn_Word;
        private System.Windows.Forms.TextBox tb_Proveril;
        private System.Windows.Forms.Label lbl_Proveril;
        private System.Windows.Forms.MonthCalendar mc_Uchet;
        private System.Windows.Forms.TextBox tb_Comment;
        private System.Windows.Forms.Label lbl_Comment;
        private System.Windows.Forms.GroupBox gb_FIlter_Uchet;
        private System.Windows.Forms.MaskedTextBox mtb_Data_Uchet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вКОToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol_Object;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ploshad_Object;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent_One;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metr_One;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent_Two;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metr_Two;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent_Three;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metr_Three;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent_Four;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metr_Four;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent_PPCBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metr_PPCBN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Search;
    }
}