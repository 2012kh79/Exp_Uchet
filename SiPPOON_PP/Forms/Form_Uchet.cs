using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiPPOON_PP.Forms
{
    public partial class Form_Uchet : Form
    {
        public Form_Uchet()
        {
            InitializeComponent();
        }

        private void OtchetKategoriya_1Fill()
        {
            Fill_Table tables = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    while (dgv_Uchet.Rows.Count != 0)
                        dgv_Uchet.Rows.Remove(dgv_Uchet.Rows[dgv_Uchet.Rows.Count - 1]);
                    tables.dtOtchet_Kategoriya_1Fill();
                    dgv_Uchet.DataSource = tables.dtOtchet_Kategoriya_1;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void OtchetKategoriya_2Fill()
        {
            Fill_Table tables = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    while (dgv_Uchet.Rows.Count != 0)
                        dgv_Uchet.Rows.Remove(dgv_Uchet.Rows[dgv_Uchet.Rows.Count - 1]);
                    tables.dtOtchet_Kategoriya_2Fill();
                    dgv_Uchet.DataSource = tables.dtOtchet_Kategoriya_2;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void OtchetKategoriya_3Fill()
        {
            Fill_Table tables = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    while (dgv_Uchet.Rows.Count != 0)
                        dgv_Uchet.Rows.Remove(dgv_Uchet.Rows[dgv_Uchet.Rows.Count - 1]);
                    tables.dtOtchet_Kategoriya_3Fill();
                    dgv_Uchet.DataSource = tables.dtOtchet_Kategoriya_3;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void OtchetKategoriya_4Fill()
        {
            Fill_Table tables = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    while (dgv_Uchet.Rows.Count != 0)
                        dgv_Uchet.Rows.Remove(dgv_Uchet.Rows[dgv_Uchet.Rows.Count - 1]);
                    tables.dtOtchet_Kategoriya_4Fill();
                    dgv_Uchet.DataSource = tables.dtOtchet_Kategoriya_4;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void OtchetKategoriya_5Fill()
        {
            Fill_Table tables = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    while (dgv_Uchet.Rows.Count != 0)
                        dgv_Uchet.Rows.Remove(dgv_Uchet.Rows[dgv_Uchet.Rows.Count - 1]);
                    tables.dtOtchet_Kategoriya_5Fill();
                    dgv_Uchet.DataSource = tables.dtOtchet_Kategoriya_5;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void OtchetKategoriya_6Fill()
        {
            Fill_Table tables = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    while (dgv_Uchet.Rows.Count != 0)
                        dgv_Uchet.Rows.Remove(dgv_Uchet.Rows[dgv_Uchet.Rows.Count - 1]);
                    tables.dtOtchet_Kategoriya_6Fill();
                    dgv_Uchet.DataSource = tables.dtOtchet_Kategoriya_6;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void OtchetVKOFill()
        {
            Fill_Table tables = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    while (dgv_Uchet.Rows.Count != 0)
                        dgv_Uchet.Rows.Remove(dgv_Uchet.Rows[dgv_Uchet.Rows.Count - 1]);
                    tables.dtOtchet_VKOFill();
                    dgv_Uchet.DataSource = tables.dtOtchet_VKO;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void Form_Uchet_Load(object sender, EventArgs e)
        {

        }

        private void категорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtchetKategoriya_1Fill();
        }

        private void категорияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OtchetKategoriya_2Fill();
        }

        private void категорияToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OtchetKategoriya_3Fill();
        }

        private void категорияToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OtchetKategoriya_4Fill();
        }

        private void категорияToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OtchetKategoriya_5Fill();
        }

        private void категорияToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OtchetKategoriya_6Fill();
        }

        private void вКОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtchetVKOFill();
        }

        private void вАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void зАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void зелАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сВАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сЗАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void тиНАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void цАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void юАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void юВАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void юЗАОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
