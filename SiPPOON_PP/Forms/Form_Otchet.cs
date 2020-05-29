using System;
using System.Windows.Forms;
using System.Threading;

namespace SiPPOON_PP.Forms
{
    public partial class Form_Otchet : Form
    {
        public Form_Otchet()
        {
            InitializeComponent();
        }

        public void dgvOtchetFill()//Метод для заполнения данных о Пользователях
        {
            Fill_Table tables = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    while (dgv_Otchet.Rows.Count != 0)
                        dgv_Otchet.Rows.Remove(dgv_Otchet.Rows[dgv_Otchet.Rows.Count - 1]);
                    tables.dtOtchet_KategoriiFill();
                    dgv_Otchet.DataSource = tables.dtOtchet_Kategorii;
                    dgv_Otchet.Columns[0].HeaderText = "№ п/п";
                    dgv_Otchet.Columns[1].HeaderText = "Наименование объекта";
                    dgv_Otchet.Columns[2].HeaderText = "Количество объектов";
                    dgv_Otchet.Columns[3].HeaderText = "Площадь обследованных объектов, кв.м";
                    dgv_Otchet.Columns[4].HeaderText = "Площадь проезжей части с выявленными нарушениями. 1-му параметру, %";
                    dgv_Otchet.Columns[5].HeaderText = "Площадь проезжей части с выявленными нарушениями. 1-му параметру, кв.м";
                    dgv_Otchet.Columns[6].HeaderText = "Площадь проезжей части с выявленными нарушениями. 2-му параметру, %";
                    dgv_Otchet.Columns[7].HeaderText = "Площадь проезжей части с выявленными нарушениями. 2-му параметру, кв.м";
                    dgv_Otchet.Columns[8].HeaderText = "Площадь проезжей части с выявленными нарушениями. 3-му параметру, %";
                    dgv_Otchet.Columns[9].HeaderText = "Площадь проезжей части с выявленными нарушениями. 3-му параметру, кв.м";
                    dgv_Otchet.Columns[10].HeaderText = "Площадь проезжей части с выявленными нарушениями. 4-му параметру, %";
                    dgv_Otchet.Columns[11].HeaderText = "Площадь проезжей части с выявленными нарушениями. 4-му параметру, кв.м";
                    dgv_Otchet.Columns[12].HeaderText = "Площадь проезжей части без нарушений, %";
                    dgv_Otchet.Columns[13].HeaderText = "Площадь проезжей части без нарушений, кв.м";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void Form_Otchet_Load(object sender, EventArgs e)
        {
            dgvOtchetFill();
        }

        private void dgv_Otchet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Kol.Text = dgv_Otchet.CurrentRow.Cells[2].Value.ToString();
            tb_Ploshad.Text = dgv_Otchet.CurrentRow.Cells[3].Value.ToString();
            tb_Per_One.Text = dgv_Otchet.CurrentRow.Cells[4].Value.ToString();
            tb_Metr_One.Text = dgv_Otchet.CurrentRow.Cells[5].Value.ToString();
            tb_Per_Two.Text = dgv_Otchet.CurrentRow.Cells[6].Value.ToString();
            tb_Metr_Two.Text = dgv_Otchet.CurrentRow.Cells[7].Value.ToString();
            tb_Per_Three.Text = dgv_Otchet.CurrentRow.Cells[8].Value.ToString();
            tb_Metr_Three.Text = dgv_Otchet.CurrentRow.Cells[9].Value.ToString();
            tb_Per_Four.Text = dgv_Otchet.CurrentRow.Cells[10].Value.ToString();
            tb_Metr_Four.Text = dgv_Otchet.CurrentRow.Cells[11].Value.ToString();
            tb_Per_PPCBN.Text = dgv_Otchet.CurrentRow.Cells[12].Value.ToString();
            tb_Metr_PPCBN.Text = dgv_Otchet.CurrentRow.Cells[13].Value.ToString();
        }
    }
}
