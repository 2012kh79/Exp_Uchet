using System;
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
            btnConfirm.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
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
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPut.Text = folderBrowserDialog1.SelectedPath;
                btnConfirm.Enabled = true;
            }
        }

        private void Form_Configuration_FormClosing(object sender, FormClosingEventArgs e)
        {
            document_default_path = tbPut.Text;
            btnConfirm.Enabled = false;
        }
    }
}
