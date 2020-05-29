using SiPPOON_PP.Classes;
using System;
using System.Windows.Forms;

namespace SiPPOON_PP.Forms
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            tb_Path.Text = Form_Main.Location_Result;
            tb_Path_Folder.Text = Form_Main.Location_Folder;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
            btn_Review.Enabled = true;
            btn_Review_Folder.Enabled = true;
            btn_Update.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            XML xml_doc = new XML();
            btn_Save.Enabled = false;
            btn_Review.Enabled = false;
            btn_Review_Folder.Enabled = false;
            btn_Update.Enabled = true;
            xml_doc.XML_Write(tb_Path.Text, tb_Path_Folder.Text);
            Form_Main.Location_Result = tb_Path.Text;
            Form_Main.Location_Folder = tb_Path_Folder.Text;
        }

        private void btn_Review_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg_im = new OpenFileDialog();
            dlg_im.Filter = "Excel File|*.xls;*.xlsx;*.xlsm";
            if (dlg_im.ShowDialog() == DialogResult.OK)
                tb_Path.Text = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dlg_im.FileName + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
        }

        private void btn_Review_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                tb_Path_Folder.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
