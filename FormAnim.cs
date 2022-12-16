using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedGraphics
{
    public partial class FormAnim : Form
    {
        public FormAnim()
        {
            InitializeComponent();
        }

        private void FormAnim_Load(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen penB = new Pen(Color.Black, 2f);
            Pen penR = new Pen(Color.Red, 2f);
            Pen penG = new Pen(Color.Green, 2f);
            Pen penBlue = new Pen(Color.Blue, 2f);
            Font drawFont = new Font("Arial", 14);
            SolidBrush brush = new SolidBrush(Color.Blue);
            StringFormat stringFormat = new StringFormat();
            stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            graphics.DrawLine(penBlue, 10, 225, 586, 225);
            graphics.DrawLine(penBlue, 293, 10, 293, 450);

            PointF PointF1 = new PointF(287, 100);
            graphics.DrawString("-  1", drawFont, brush, PointF1);
            PointF PointF2 = new PointF(287, 325);
            graphics.DrawString("-  -1", drawFont, brush, PointF2);


            Point[] PBlack = new Point[1000];
            Point[] PRed = new Point[1000];
            Point[] PGReen = new Point[1000];

            for (int i = 0; i < 1000; i++)
            {
                PBlack[i] = new Point(i, (int)(Math.Cos((double)i / 30) * 112 + 225));
                PRed[i] = new Point(i + 5, (int)(Math.Cos((double)i / 30) * 112 + 225));
                PGReen[i] = new Point(i + 10, (int)(Math.Cos((double)i / 30) * 112 + 225));

            }
            for (int i = 0; i < 999; i++)
            {
                graphics.DrawLine(penB, PBlack[i], PBlack[i+1]);
                graphics.DrawLine(penR, PRed[i], PRed[i+1]);
                graphics.DrawLine(penG, PGReen[i], PGReen[i+1]);
                Thread.Sleep(1);
            }
            this.Close();
        }
    }
}
