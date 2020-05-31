using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace SiPPOON_PP.Classes
{
    class FTPServer_Class
    {
        FtpWebRequest request;//Переменная для работы с FTP-клиентом
        public FileInfo info { get; set; }//Переменная для хранения имени файла
        public string location { get; set; }//Переменная для хранения пути к файлу
        public void Set_Files()//Метод для загрузки файлов на FTP-сервер
        {
            try
            {
                OpenFileDialog dlg_im = new OpenFileDialog();
                dlg_im.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
                if (dlg_im.ShowDialog() == DialogResult.OK)
                {
                    info = new FileInfo(dlg_im.FileName);
                    request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", "ftp://127.0.0.1", info.Name)));
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential("ilnaz41", "12082000Ilnaz");
                    Stream ftpStream = request.GetRequestStream();
                    FileStream fs = File.OpenRead(info.FullName);
                    byte[] buffer = new byte[1024];
                    int byteRead = 0;
                    double read = 0;
                    do
                    {
                        byteRead = fs.Read(buffer, 0, 1024);
                        ftpStream.Write(buffer, 0, byteRead);
                        read += (double)byteRead;
                    }
                    while (byteRead != 0);
                    fs.Close();
                    ftpStream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string[] Get_Files(ListView listView)//Метод для получения списка файлов, которые находятся на FTP-сервере
        {
            listView.Items.Clear();
            var list = listView;

            request = (FtpWebRequest)WebRequest.Create("ftp://127.0.0.1");
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential("ilnaz41", "12082000Ilnaz");
            using (var response = (FtpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream, true))
                    {
                        while (!reader.EndOfStream)
                            list.Items.Add(reader.ReadLine());
                    }
                }
            }
            List<string> l = new List<string>();
            return l.ToArray();
        }

        public string[] Delete_Files(ListView listView)//Метод для удаления файлов, которые находятся на FTP-сервере
        {
            var list = listView;
            request = (FtpWebRequest)WebRequest.Create("ftp://127.0.0.1/" + list.FocusedItem.Text);
            request.Method = WebRequestMethods.Ftp.DeleteFile;
            request.Credentials = new NetworkCredential("ilnaz41", "12082000Ilnaz");
            list.FocusedItem.Remove();
            using (var response = (FtpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream, true))
                    {
                        while (!reader.EndOfStream)
                            list.Items.Add(reader.ReadLine());
                    }
                }
            }
            List<string> l = new List<string>();
            return l.ToArray();
        }

        public void Get_Image(DataTable dataTable)//Метод, который используется для выгрузки изображений в PictureBox
        {
            try
            {
                string datalocation = dataTable.Rows[0]["Photo_Employee"].ToString();
                location = AppDomain.CurrentDomain.BaseDirectory + "/Сотрудники/" + datalocation.Replace("ftp://127.0.0.1/", "");
                request = (FtpWebRequest)WebRequest.Create(dataTable.Rows[0]["Photo_Employee"].ToString());
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential("ilnaz41", "12082000Ilnaz");
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                FileStream file = File.Create(location);
                byte[] buffer = new byte[512 * 1024];
                int read;
                while ((read = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    file.Write(buffer, 0, read);
                }
                file.Close();
                responseStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
