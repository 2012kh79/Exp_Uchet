using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SiPPOON_PP
{
    public partial class Form_Zastavka : Form
    {
        public Form_Zastavka()
        {
            InitializeComponent();
        }

        private void Form_Zastavka_Load(object sender, EventArgs e)
        {
            GraphicsPath gr = new GraphicsPath();
            Point p1, p2, p3, p4;
            p1 = new Point(110, 165);
            p2 = new Point(110, 265);
            p3 = new Point(130, 245);
            p4 = new Point(130, 185);
            Point[] poly = { p1, p2, p3, p4 };
            gr.AddPolygon(poly);
            Point p5, p6, p7, p8;
            p5 = new Point(145, 125);
            p6 = new Point(245, 125);
            p7 = new Point(225, 145);
            p8 = new Point(165, 145);
            Point[] poly1 = { p5, p6, p7, p8 };
            gr.AddPolygon(poly1);
            Point p9, p10, p11, p12;
            p9 = new Point(275, 165);
            p10 = new Point(275, 265);
            p11 = new Point(255, 245);
            p12 = new Point(255, 185);
            Point[] poly2 = { p9, p10, p11, p12 };
            gr.AddPolygon(poly2);
            Point p13, p14, p15, p16;
            p13 = new Point(145, 305);
            p14 = new Point(245, 305);
            p15 = new Point(225, 285);
            p16 = new Point(165, 285);
            Point[] poly3 = { p13, p14, p15, p16 };
            gr.AddPolygon(poly3);
            gr.AddEllipse(20, 40, 345, 350);
            gr.AddEllipse(70, 90, 245, 250);
            gr.AddString("Э", this.Font.FontFamily, 1, 144,
            new Point(115, 135), StringFormat.GenericDefault);
            Region r = new Region(gr);
            this.Region = r;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity != 1)
                Opacity += 0.01;
            else
            {
                timer1.Enabled = false;
                Form_Authorize form_authorize = new Form_Authorize();
                form_authorize.Show();
                this.Hide();
            }
        }
    }
}
