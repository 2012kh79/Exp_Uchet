using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SiPPOON_PP
{
    class DB_Procedures
    {
        public SqlCommand cmd = new SqlCommand("Empty", Registry_Class.sql);

        public void spConfiguration(string spName)//CommandType = Процедуры
        {
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
        }
        public void spAccount_Insert(string Login_Account, string Parol_Account, string Mail, Int32 Role_ID, Int32 Employee_ID)//Метод для добавления Аккаунта
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

        public void spAccount_Update(string Login_Account, string Parol_Account, string Mail, Int32 Role_ID, Int32 Employee_ID)//Метод для изменения данных Аккаунта
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

        public void spAccount_Delete(string Login_Account)//Метод для удаления Аккаунта
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

        public void spEmployee_Insert(string Fam_Employee, string Imya_Employee, string Photo_Employee)//Метод для добавления Сотрудника
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

        public void spEmployee_Update(Int32 ID_Employee, string Fam_Employee, string Imya_Employee, string Photo_Employee)//Метод для изменения данных Сотрудника
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

        public void spEmployee_Delete(Int32 ID_Employee)//Метод для удаления Сотрудника
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

        public void spOtchet_Analisys_Insert(string Naim_Object, int Kol_Object, double Ploshad_Object, double Percent_One, double Metr_One, double Percent_Two, double Metr_Two,
            double Percent_Three, double Metr_Three, double Percent_Four, double Metr_Four, double Percent_PPCBN, double Metr_PPCBN, string Data_Otchet, Int32 Employee_ID)//Метод для добавления объекта площади обследования
        {
            spConfiguration("Otchet_Analisys_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Naim_Object", Naim_Object);
                cmd.Parameters.AddWithValue("@Kol_Object", Kol_Object);
                cmd.Parameters.AddWithValue("@Ploshad_Object", Ploshad_Object);
                cmd.Parameters.AddWithValue("@Percent_One", Percent_One);
                cmd.Parameters.AddWithValue("@Metr_One", Metr_One);
                cmd.Parameters.AddWithValue("@Percent_Two", Percent_Two);
                cmd.Parameters.AddWithValue("@Metr_Two", Metr_Two);
                cmd.Parameters.AddWithValue("@Percent_Three", Percent_Three);
                cmd.Parameters.AddWithValue("@Metr_Three", Metr_Three);
                cmd.Parameters.AddWithValue("@Percent_Four", Percent_Four);
                cmd.Parameters.AddWithValue("@Metr_Four", Metr_Four);
                cmd.Parameters.AddWithValue("@Percent_PPCBN", Percent_PPCBN);
                cmd.Parameters.AddWithValue("@Metr_PPCBN", Metr_PPCBN);
                cmd.Parameters.AddWithValue("@Data_Otchet", Data_Otchet);
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

        public void spOtchet_Analisys_Update(Int32 ID_Analisys, string Naim_Object, int Kol_Object, double Ploshad_Object, double Percent_One, double Metr_One, double Percent_Two, double Metr_Two,
            double Percent_Three, double Metr_Three, double Percent_Four, double Metr_Four, double Percent_PPCBN, double Metr_PPCBN, string Data_Otchet, Int32 Employee_ID)//Метод для изменения площади объекта площади обследования
        {
            spConfiguration("Otchet_Analisys_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Analisys", ID_Analisys);
                cmd.Parameters.AddWithValue("@Naim_Object", Naim_Object);
                cmd.Parameters.AddWithValue("@Kol_Object", Kol_Object);
                cmd.Parameters.AddWithValue("@Ploshad_Object", Ploshad_Object);
                cmd.Parameters.AddWithValue("@Percent_One", Percent_One);
                cmd.Parameters.AddWithValue("@Metr_One", Metr_One);
                cmd.Parameters.AddWithValue("@Percent_Two", Percent_Two);
                cmd.Parameters.AddWithValue("@Metr_Two", Metr_Two);
                cmd.Parameters.AddWithValue("@Percent_Three", Percent_Three);
                cmd.Parameters.AddWithValue("@Metr_Three", Metr_Three);
                cmd.Parameters.AddWithValue("@Percent_Four", Percent_Four);
                cmd.Parameters.AddWithValue("@Metr_Four", Metr_Four);
                cmd.Parameters.AddWithValue("@Percent_PPCBN", Percent_PPCBN);
                cmd.Parameters.AddWithValue("@Metr_PPCBN", Metr_PPCBN);
                cmd.Parameters.AddWithValue("@Data_Otchet", Data_Otchet);
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
    }
}
