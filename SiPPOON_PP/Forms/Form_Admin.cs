using System;
using System.Windows.Forms;
using System.Threading;
using SiPPOON_PP.Classes;

namespace SiPPOON_PP
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        public void dgvUsersFill()//Метод для заполнения данных о Пользователях
        {
            Fill_Table tables = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    while (dgv_Users.Rows.Count != 0)
                        dgv_Users.Rows.Remove(dgv_Users.Rows[dgv_Users.Rows.Count - 1]);
                    tables.dtAccountFill();
                    dgv_Users.DataSource = tables.dtAccount;
                    dgv_Users.Columns[0].HeaderText = "Логин";
                    dgv_Users.Columns[1].HeaderText = "Пароль";
                    dgv_Users.Columns[2].HeaderText = "Почта";
                    dgv_Users.Columns[3].HeaderText = "Наименование роли";
                    dgv_Users.Columns[4].HeaderText = "Номер сотрудника";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvEmployeeFill()//Метод для заполнения данных о Сотрудниках
        {
            Fill_Table tables = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    while (dgv_Employee.Rows.Count != 0)
                        dgv_Employee.Rows.Remove(dgv_Employee.Rows[dgv_Employee.Rows.Count - 1]);
                    tables.dtEmployeeFill();
                    dgv_Employee.DataSource = tables.dtEmployee;
                    dgv_Employee.Columns[0].HeaderText = "Номер сотрудника";
                    dgv_Employee.Columns[1].HeaderText = "Фамилия сотрудника";
                    dgv_Employee.Columns[2].HeaderText = "Имя сотрудника";
                    dgv_Employee.Columns[3].HeaderText = "Путь к изображению";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            pb_Exit.BackgroundImage = Properties.Resources.Exit;
            pb_Exit_Sotr.BackgroundImage = Properties.Resources.Exit;
            Thread threadPost = new Thread(dgvUsersFill);//Создание переменной, которая будет осуществлять операцию в виде потока, которая содержит метод для заполнения данных о пользователях
            threadPost.Start();
            Thread threadEmployee = new Thread(dgvEmployeeFill);//Создание переменной, которая будет осуществлять операцию в виде потока, которая содержит метод для заполнения данных о сотрудниках
            threadEmployee.Start();
            cmbID_RoleFill();
            cmbID_EmployeeFill();
            FTPServer_Class FTP_Server = new FTPServer_Class();//Создание переменной для обращения к классу, которая необходима для подключения к FTP-серверу
            FTP_Server.Get_Files(lv_Photo);
        }

        private void cmbID_RoleFill()//Метод для заполнения ComboBox "Роли" данными из таблицы SQL 
        {
            Action action = () =>
            {
                try
                {
                    Fill_Table tables = new Fill_Table();
                    tables.dtRoleFill();
                    cmb_Role.DataSource = tables.dtRole;
                    cmb_Role.DisplayMember = "Role";
                    cmb_Role.ValueMember = "Role_name";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void cmbID_EmployeeFill()//Метод для заполнения ComboBox "Сотрудники" данными из таблицы SQL 
        {
            Action action = () =>
            {
                try
                {
                    Fill_Table tables = new Fill_Table();
                    tables.dtEmployeeFill();
                    cmb_Employee.DataSource = tables.dtEmployee;
                    cmb_Employee.DisplayMember = "Employee";
                    cmb_Employee.ValueMember = "ID_Employee";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void btn_Insert_Click(object sender, EventArgs e)//Событие для обработки процедуры добавления Аккаунта
        {
            DB_Procedures procedures = new DB_Procedures();
            if (tb_Login.Text != "" & tb_Password.Text != "" & tb_Mail.Text != "")
            {
                try
                {
                    procedures.spAccount_Insert(tb_Login.Text, Form_Registration.Hash(tb_Password.Text), tb_Mail.Text, cmb_Role.SelectedIndex + 1, Convert.ToInt32(cmb_Employee.SelectedValue.ToString()));
                    tb_Login.Clear();
                    tb_Password.Clear();
                    tb_Mail.Clear();
                    dgvUsersFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка добавления", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Заполните поля данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Update_Click(object sender, EventArgs e)//Событие для обработки процедуры изменения данных Аккаунта
        {
            DB_Procedures procedures = new DB_Procedures();
            if (tb_Login.Text != "" & tb_Password.Text != "" & tb_Mail.Text != "")
            {
                try
                {
                    procedures.spAccount_Update(tb_Login.Text, Form_Registration.Hash(tb_Password.Text), tb_Mail.Text, cmb_Role.SelectedIndex + 1, Convert.ToInt32(cmb_Employee.SelectedValue.ToString()));
                    tb_Login.Clear();
                    tb_Password.Clear();
                    tb_Mail.Clear();
                    dgvUsersFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка изменения", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Заполните поля данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Delete_Click(object sender, EventArgs e)//Событие для обработки процедуры удаления Аккаунта
        {
            DB_Procedures procedures = new DB_Procedures();
            switch (MessageBox.Show("Удалить аккаунт " + tb_Login.Text + "?", "Удаление аккаунта", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedures.spAccount_Delete(dgv_Users.CurrentRow.Cells[0].Value.ToString());
                    dgvUsersFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Insert_Sotrudnik_Click(object sender, EventArgs e)//Событие для обработки процедуры добавления Сотрудника
        {
            DB_Procedures procedures = new DB_Procedures();
            if (tb_Fam.Text != "" & tb_Imya.Text != "")
            {
                try
                {
                    procedures.spEmployee_Insert(tb_Fam.Text, tb_Imya.Text, tb_Path.Text);
                    tb_Fam.Clear();
                    tb_Imya.Clear();
                    tb_Path.Clear();
                    dgvEmployeeFill();
                    cmbID_EmployeeFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка добавления", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Заполните поля данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Update_Sotrudnik_Click(object sender, EventArgs e)//Событие для обработки процедуры изменения данных Сотрудника
        {
            DB_Procedures procedures = new DB_Procedures();
            if (tb_Fam.Text != "" & tb_Imya.Text != "")
            {
                try
                {
                    procedures.spEmployee_Update(Convert.ToInt32(dgv_Employee.CurrentRow.Cells[0].Value.ToString()),tb_Fam.Text, tb_Imya.Text, tb_Path.Text);
                    tb_Fam.Clear();
                    tb_Imya.Clear();
                    tb_Path.Clear();
                    dgvEmployeeFill();
                    cmbID_EmployeeFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка изменения", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Заполните поля данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Delete_Sotrudnik_Click(object sender, EventArgs e)//Событие для обработки процедуры удаления Сотрудника
        {
            DB_Procedures procedures = new DB_Procedures();
            switch (MessageBox.Show("Удалить сотрудника " + tb_Fam.Text + " " + tb_Imya.Text + "?", "Удаление сотрудника", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedures.spEmployee_Delete(Convert.ToInt32(dgv_Employee.CurrentRow.Cells[0].Value.ToString()));
                    dgvEmployeeFill();
                    cmbID_EmployeeFill();
                    break; 
                case DialogResult.No:
                    break;
            }
        }

        private void Form_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Authorize form_authorize = new Form_Authorize();
            form_authorize.Show();
        }

        private void btn_InsertPhoto_Click(object sender, EventArgs e)
        {
            FTPServer_Class FTP_Server = new FTPServer_Class();
            FTP_Server.Set_Files();
            FTP_Server.Get_Files(lv_Photo);
        }

        private void lv_Photo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_DeletePhoto.Enabled = true;
            tb_Path.Text = string.Format("{0}/{1}", "ftp://127.0.0.1", lv_Photo.FocusedItem.Text);
        }

        private void btn_DeletePhoto_Click(object sender, EventArgs e)
        {
            FTPServer_Class FTP_Server = new FTPServer_Class();
            FTP_Server.Delete_Files(lv_Photo);
        }

        private void dgv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Login.Text = dgv_Users.CurrentRow.Cells[0].Value.ToString();
            tb_Password.Text = dgv_Users.CurrentRow.Cells[1].Value.ToString();
            tb_Mail.Text = dgv_Users.CurrentRow.Cells[2].Value.ToString();
            cmb_Role.SelectedValue = dgv_Users.CurrentRow.Cells[3].Value.ToString();
            cmb_Employee.SelectedValue = dgv_Users.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Fam.Text = dgv_Employee.CurrentRow.Cells[1].Value.ToString();
            tb_Imya.Text = dgv_Employee.CurrentRow.Cells[2].Value.ToString();
            tb_Path.Text = dgv_Employee.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
