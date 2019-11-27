using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System;

namespace SiPPOON_PP
{
    class Fill_Table
    {
        public DataGridView dataGrid;
        public SqlCommand command = new SqlCommand("", Registry_Class.sql);
        public SqlDependency dependency = new SqlDependency();
        public DataTable dtRole = new DataTable("Role");
        public DataTable dtAccount = new DataTable("Account");
        public DataTable dtEmployee = new DataTable("Employee");
        public string qrRole = "select [ID_Role],[Role_name] from [Role]",
            qrAccount = "select [Login_Account],[Parol_Account],[Mail],[Role_name],[Employee_ID] from [Account] inner join [Role] on [Role].[ID_Role] = [Account].[Role_ID]"
            + " inner join [Employee] on [Employee].[ID_Employee] = [Account].[Employee_ID]",
        qrEmployee = "select [ID_Employee],[Fam_Employee],[Imya_Employee] from [Employee]";
        public void Table(DataGridView dgv, DataTable data)
        {
            int i = 0;
            dgv.Rows.Clear();
            foreach (DataRow dr in data.Rows)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = false;
                dgv.Rows[i].Cells[1].Value = dr.ItemArray[0];
                dgv.Rows[i].Cells[2].Value = dr.ItemArray[1];
                dgv.Rows[i].Cells[3].Value = dr.ItemArray[2];
                dgv.Rows[i].Cells[4].Value = dr.ItemArray[3];
                dgv.Rows[i].Cells[5].Value = dr.ItemArray[4];
                dgv.Rows[i].Cells[6].Value = dr.ItemArray[5];
                dgv.Rows[i].Cells[7].Value = dr.ItemArray[6];
                dgv.Rows[i].Cells[8].Value = dr.ItemArray[7];
                dgv.Rows[i].Cells[9].Value = dr.ItemArray[8];
                dgv.Rows[i].Cells[10].Value = dr.ItemArray[9];
                dgv.Rows[i].Cells[11].Value = dr.ItemArray[10];
                dgv.Rows[i].Cells[12].Value = dr.ItemArray[11];
                dgv.Rows[i].Cells[13].Value = dr.ItemArray[12];
                dgv.Rows[i].Cells[14].Value = dr.ItemArray[13];
                dgv.Rows[i].Cells[15].Value = dr.ItemArray[14];
                dgv.Rows[i].Cells[16].Value = dr.ItemArray[15];
                dgv.Rows[i].Cells[17].Value = dr.ItemArray[16];
                dgv.Rows[i].Cells[18].Value = dr.ItemArray[17];
                dgv.Rows[i].Cells[19].Value = dr.ItemArray[18];
                dgv.Rows[i].Cells[20].Value = dr.ItemArray[19];
                dgv.Rows[i].Cells[21].Value = dr.ItemArray[20];
                dgv.Rows[i].Cells[22].Value = dr.ItemArray[21];
                dgv.Rows[i].Cells[23].Value = dr.ItemArray[22];
                dgv.Rows[i].Cells[24].Value = dr.ItemArray[23];
                dgv.Rows[i].Cells[25].Value = dr.ItemArray[24];
                dgv.Rows[i].Cells[26].Value = dr.ItemArray[25];
                dgv.Rows[i].Cells[27].Value = dr.ItemArray[26];
                dgv.Rows[i].Cells[28].Value = dr.ItemArray[27];
                dgv.Rows[i].Cells[29].Value = dr.ItemArray[28];
                dgv.Rows[i].Cells[30].Value = dr.ItemArray[29];
                dgv.Rows[i].Cells[31].Value = dr.ItemArray[30];
                dgv.Rows[i].Cells[32].Value = dr.ItemArray[31];
                dgv.Rows[i].Cells[33].Value = dr.ItemArray[32];
                dgv.Rows[i].Cells[34].Value = dr.ItemArray[33];
                dgv.Rows[i].Cells[35].Value = dr.ItemArray[34];
                dgv.Rows[i].Cells[36].Value = dr.ItemArray[35];
                dgv.Rows[i].Cells[37].Value = dr.ItemArray[36];
                dgv.Rows[i].Cells[38].Value = dr.ItemArray[37];
                dgv.Rows[i].Cells[39].Value = dr.ItemArray[38];
                dgv.Rows[i].Cells[40].Value = dr.ItemArray[39];
                dgv.Rows[i].Cells[41].Value = dr.ItemArray[40];
                dgv.Rows[i].Cells[42].Value = dr.ItemArray[41];
                i++;
            }
            dgv.Rows[i-1].DefaultCellStyle.BackColor = Color.Yellow;
                dgv.Rows[i-1].Cells[3].Value = "Итог:";
        }

        private void dtFill(DataTable table, string query)//Метод для заполнения таблиц
        {
            try
            {
                command.Notification = null;
                command.CommandText = query;
                dependency.AddCommandDependency(command);
                SqlDependency.Start(Registry_Class.sql.ConnectionString);
                Registry_Class.sql.Open();
                table.Load(command.ExecuteReader());
                SqlDependency.Stop(Registry_Class.sql.ConnectionString);
            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void dtRoleFill()//Метод для заполнения ролей
        {
            dtFill(dtRole, qrRole);
        }

        public void dtAccountFill()
        {
            dtFill(dtAccount, qrAccount);
        }

        public void dtEmployeeFill()
        {
            dtFill(dtEmployee, qrEmployee);
        }
    }
}
