using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Data.OleDb;
using System;

namespace SiPPOON_PP
{
    class Fill_Table
    {
        public static string connectionString;
        public OleDbConnection conOle = new OleDbConnection(connectionString);//Осуществление подключения к Excel
        public SqlCommand commandSQL = new SqlCommand("", Registry_Class.sql);//Запрос SQL
        public SqlDependency dependency = new SqlDependency();

        public DataTable dtRole = new DataTable("Role");//Создание таблицы для работы с SQL
        public DataTable dtAccount = new DataTable("Account");
        public DataTable dtEmployee = new DataTable("Employee");
        
        public DataTable dtKategoriya_1 = new DataTable("Kategoriya_1");
        public DataTable dtKategoriya_2 = new DataTable("Kategoriya_2");
        public DataTable dtKategoriya_3 = new DataTable("Kategoriya_3");
        public DataTable dtKategoriya_4 = new DataTable("Kategoriya_4");
        public DataTable dtKategoriya_5 = new DataTable("Kategoriya_5");
        public DataTable dtKategoriya_6 = new DataTable("Kategoriya_6");
        public DataTable dtVKO = new DataTable("VKO");

        public DataTable dtOtchet_Analisys_Proverka = new DataTable("Otchet_Analisys_Proverka");
        public DataTable dtOtchet_Kategorii = new DataTable("Otchet_Kategorii");
        public DataTable dtOtchet_Okruga = new DataTable("Otchet_Okruga");

        public DataTable dtVAO = new DataTable("VAO");
        public DataTable dtZAO = new DataTable("ZAO");
        public DataTable dtZelAO = new DataTable("ZelAO");
        public DataTable dtSAO = new DataTable("SAO");
        public DataTable dtSVAO = new DataTable("SVAO");
        public DataTable dtSZAO = new DataTable("SZAO");
        public DataTable dtTiNAO = new DataTable("TiNAO");
        public DataTable dtTSAO = new DataTable("TSAO");
        public DataTable dtYAO = new DataTable("YAO");
        public DataTable dtYVAO = new DataTable("YVAO");
        public DataTable dtYZAO = new DataTable("YZAO");

        public string qrRole = "select [ID_Role],[Role_name] from [Role]",//Переменная, которая хранит в себе запрос на выборку данных из таблицы
        qrAccount = "select [Login_Account],[Parol_Account],[Mail],[Role_name],[Employee_ID] from [Account] inner join [Role] on [Role].[ID_Role] = [Account].[Role_ID] inner join [Employee] on [Employee].[ID_Employee] = [Account].[Employee_ID]",
        qrEmployee = "select [ID_Employee],[Fam_Employee],[Imya_Employee],[Photo_Employee] from [Employee]",
        qrOtchet_Analisys_Proverka = "select * FROM [Otchet_Analisys_Proverka]",
        qrOtchet_Kategorii = "select * FROM [Otchet_Kategorii]",
        qrOtchet_Okruga = "select * FROM [Otchet_Okruga]",

        qrKategoriya_1 = "SELECT * FROM [Категории$A9:AP223]",
        qrKategoriya_2 = "SELECT * FROM [Категории$A224:AP691]",
        qrKategoriya_3 = "SELECT * FROM [Категории$A692:AP3719]",
        qrKategoriya_4 = "SELECT * FROM [Категории$A3720:AP4241]",
        qrKategoriya_5 = "SELECT * FROM [Категории$A4242:AP4592]",
        qrKategoriya_6 = "SELECT * FROM [Категории$A4593:AP4779]",
        qrVKO = "SELECT * FROM [Категории$A4780:AP5337]",

        qrVAO = "SELECT * FROM [Округа$A384:AP903]",
        qrZAO = "SELECT * FROM [Округа$A904:AP1388]",
        qrZelAO = "SELECT * FROM [Округа$A1389:AP1500]",
        qrSAO = "SELECT * FROM [Округа$A1501:AP2094]",
        qrSVAO = "SELECT * FROM [Округа$A2095:AP2709]",
        qrSZAO = "SELECT * FROM [Округа$A2710:AP3007]",
        qrTiNAO = "SELECT * FROM [Округа$A3008:AP3170]",
        qrTSAO = "SELECT * FROM [Округа$A3171:AP4123]",
        qrYAO = "SELECT * FROM [Округа$A4124:AP4531]",
        qrYVAO = "SELECT * FROM [Округа$A4532:AP5048]",
        qrYZAO = "SELECT * FROM [Округа$A5049:AP5347]";

        public void Table(DataGridView dgv, DataTable data)//Метод для заполнения таблицы DataGridView данными из DataTable
        {
            int i = 0;
            dgv.Rows.Clear();
            foreach (DataRow dr in data.Rows)
            {
                dgv.Rows.Add();
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    dgv.Rows[i].Cells[j + 1].Value = dr.ItemArray[j];
                    if (j == 0)
                        dgv.Rows[i].Cells[j].Value = false;
                }
                i++;
            }
            dgv.Rows[i-1].DefaultCellStyle.BackColor = Color.Yellow;
                dgv.Rows[i-1].Cells[3].Value = "Итог:";
        }

        private void dtFill_SQL (DataTable table, string query)//Метод для заполнения таблиц DataTable данными из SQL-запроса
        {
            try
            {
                commandSQL.Notification = null;
                commandSQL.CommandText = query;
                dependency.AddCommandDependency(commandSQL);
                SqlDependency.Start(Registry_Class.sql.ConnectionString);
                Registry_Class.sql.Open();
                table.Load(commandSQL.ExecuteReader());
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

        public void dtFill_Ole (DataTable table, string query)//Метод для заполнения таблиц DataTable данными из OLE-запроса
        {
            try
            {
                OleDbCommand commandOle = new OleDbCommand("", conOle);
                commandOle.CommandText = query;
                conOle.Open();
                OleDbDataAdapter sda = new OleDbDataAdapter(commandOle);
                sda.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conOle.Close();
            }
        }

        public void dtRoleFill()//Метод для заполнения Ролей
        {
            dtFill_SQL(dtRole, qrRole);
        }

        public void dtAccountFill()//Метод для заполнения Аккаунта
        {
            dtFill_SQL(dtAccount, qrAccount);
        }

        public void dtEmployeeFill()//Метод для заполнения Сотрудника
        {
            dtFill_SQL(dtEmployee, qrEmployee);
        }

        public void dtKategoriya_1Fill()//Метод для заполнения справочника "Категории1"
        {
            dtFill_Ole(dtKategoriya_1, qrKategoriya_1);
        }

        public void dtKategoriya_2Fill()//Метод для заполнения справочника "Категории2"
        {
            dtFill_Ole(dtKategoriya_2, qrKategoriya_2);
        }

        public void dtKategoriya_3Fill()//Метод для заполнения справочника "Категории3"
        {
            dtFill_Ole(dtKategoriya_3, qrKategoriya_3);
        }

        public void dtKategoriya_4Fill()//Метод для заполнения справочника "Категории4"
        {
            dtFill_Ole(dtKategoriya_4, qrKategoriya_4);
        }

        public void dtKategoriya_5Fill()//Метод для заполнения справочника "Категории5"
        {
            dtFill_Ole(dtKategoriya_5, qrKategoriya_5);
        }

        public void dtKategoriya_6Fill()//Метод для заполнения справочника "Категории6"
        {
            dtFill_Ole(dtKategoriya_6, qrKategoriya_6);
        }

        public void dtVKOFill()//Метод для заполнения справочника "ВКО"
        {
            dtFill_Ole(dtVKO, qrVKO);
        }

        public void dtVAOFill()//Метод для заполнения справочника "ВАО"
        {
            dtFill_Ole(dtVAO, qrVAO);
        }

        public void dtZAOFill()//Метод для заполнения справочника "ЗАО"
        {
            dtFill_Ole(dtZAO, qrZAO);
        }

        public void dtZelAoFill()//Метод для заполнения справочника "ЗелАО"
        {
            dtFill_Ole(dtZelAO, qrZelAO);
        }

        public void dtSVAOFill()//Метод для заполнения справочника "СВАО"
        {
            dtFill_Ole(dtSVAO, qrSVAO);
        }

        public void dtSAOFill()//Метод для заполнения справочника "САО"
        {
            dtFill_Ole(dtSAO, qrSAO);
        }

        public void dtSZAOFill()//Метод для заполнения справочника "СЗАО"
        {
            dtFill_Ole(dtSZAO, qrSZAO);
        }

        public void dtTiNAOFill()//Метод для заполнения справочника "ТиНАО"
        {
            dtFill_Ole(dtTiNAO, qrTiNAO);
        }

        public void dtTSAOFill()//Метод для заполнения справочника "ЦАО"
        {
            dtFill_Ole(dtTSAO, qrTSAO);
        }

        public void dtYAOFill()//Метод для заполнения справочника "ЮАО"
        {
            dtFill_Ole(dtYAO, qrYAO);
        }

        public void dtYVAOFill()//Метод для заполнения справочника "ЮВАО"
        {
            dtFill_Ole(dtYVAO, qrYVAO);
        }

        public void dtYZAOFill()//Метод для заполнения справочника "ЮЗАО"
        {
            dtFill_Ole(dtYZAO, qrYZAO);
        }

        public void dtOtchet_Analisys_ProverkaFill()//Метод для заполнения отчета "Категория 1"
        {
            dtFill_SQL(dtOtchet_Analisys_Proverka, qrOtchet_Analisys_Proverka);
        }

        public void dtOtchet_KategoriiFill()//Метод для заполнения Сотрудника
        {
            dtFill_SQL(dtOtchet_Kategorii, qrOtchet_Kategorii);
        }

        public void dtOtchet_OkrugaFill()//Метод для заполнения отчета "Округа"
        {
            dtFill_SQL(dtOtchet_Okruga, qrOtchet_Okruga);
        }
    }
}
