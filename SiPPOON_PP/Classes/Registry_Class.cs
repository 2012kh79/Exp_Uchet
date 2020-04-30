using System;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace SiPPOON_PP
{
    class Registry_Class
    {
        public static string DS = "Empty", DSSN = "Empty", IC = "Empty", UI = "Empty", PW = "Empty";
        public static SqlConnection sql = new SqlConnection();
        public static string error_message = "App:start: " + DateTime.Now.ToLongDateString();

        public void Registry_Get()
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("SiPPOON_PP");
            try
            {
                DS = key.GetValue("DS").ToString();
                DSSN = key.GetValue("DSSN").ToString();
                IC = key.GetValue("IC").ToString();
                UI = key.GetValue("UI").ToString();
                PW = key.GetValue("PW").ToString();
            }
            catch
            {
                key.SetValue("DS", "Empty");
                key.SetValue("DSSN", "Empty");
                key.SetValue("IC", "Empty");
                key.SetValue("UI", "Empty");
                key.SetValue("PW", "Empty");
            }
            finally
            {
                sql.ConnectionString = "Data Source = " + DS + "\\" + DSSN +
                   "; Initial Catalog = " + IC + "; Persist Security Info = true; " +
                    "User ID = " + UI + "; Password = \"" + PW + "\"";
            }
        }

        public void Registry_Set(string ds, string dssn, string ic, string ui, string pw)
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("SiPPOON_PP");
            try
            {
                key.SetValue("DS", ds);
                key.SetValue("DSSN", dssn);
                key.SetValue("IC", ic);
                key.SetValue("UI", ui);
                key.SetValue("PW", pw);
                Registry_Get();
            }
            catch (Exception ex)
            {
                error_message += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
        }
    }
}
