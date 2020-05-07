using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SiPPOON_PP
{
    class DB_Procedures
    {
        public SqlCommand cmd = new SqlCommand("Empty", Registry_Class.sql);

        public void spConfiguration(string spName)
        {
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
        }
        public void spAccount_Insert(string Login_Account, string Parol_Account, string Mail, Int32 Role_ID, Int32 Employee_ID)
        {
            spConfiguration("Account_New_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Account", Login_Account);
                cmd.Parameters.AddWithValue("@Parol_Account", Parol_Account);
                cmd.Parameters.AddWithValue("@Mail", Mail);
                cmd.Parameters.AddWithValue("@Role_ID", Role_ID);
                cmd.Parameters.AddWithValue("@Employee_ID", Employee_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spAccount_Update(string Login_Account, string Parol_Account, string Mail, Int32 Role_ID, Int32 Employee_ID)
        {
            spConfiguration("Account_Update_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Account", Login_Account);
                cmd.Parameters.AddWithValue("@Parol_Account", Parol_Account);
                cmd.Parameters.AddWithValue("@Mail", Mail);
                cmd.Parameters.AddWithValue("@Role_ID", Role_ID);
                cmd.Parameters.AddWithValue("@Employee_ID", Employee_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spAccount_Delete(string Login_Account)
        {
            spConfiguration("Account_Delete_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Account", Login_Account);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spEmployee_Insert(string Fam_Employee, string Imya_Employee, string Photo_Employee)
        {
            spConfiguration("Employee_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Fam_Employee", Fam_Employee);
                cmd.Parameters.AddWithValue("@Imya_Employee", Imya_Employee);
                cmd.Parameters.AddWithValue("@Photo_Employee", Photo_Employee);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spEmployee_Update(Int32 ID_Employee, string Fam_Employee, string Imya_Employee, string Photo_Employee)
        {
            spConfiguration("Employee_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Employee", ID_Employee);
                cmd.Parameters.AddWithValue("@Fam_Employee", Fam_Employee);
                cmd.Parameters.AddWithValue("@Imya_Employee", Imya_Employee);
                cmd.Parameters.AddWithValue("@Photo_Employee", Photo_Employee);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spEmployee_Delete(Int32 ID_Employee)
        {
            spConfiguration("Employee_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Employee", ID_Employee);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }
    }
}
