﻿using System;
using System.Windows.Forms;
using System.IO;

namespace SiPPOON_PP
{
    public partial class Form_Configuration : Form
    {
        public static string document_default_path;//Хранит путь по умолчанию
        public Form_Configuration()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DocumentSave();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            document_default_path = tbPut.Text;//Присвоение переменной значения из TextBox
            Close();
        }

        private void DocumentSave()//Метод для хранения файла в определенной директории
        {
            document_default_path = tbPut.Text;
            if (!Directory.Exists(document_default_path))
                Directory.CreateDirectory(document_default_path);
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbPut.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Form_Configuration_FormClosing(object sender, FormClosingEventArgs e)
        {
            document_default_path = tbPut.Text;
        }
    }
}
