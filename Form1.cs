using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen penB = new Pen(Color.Black, 2f);
            Pen penR = new Pen(Color.Red, 2f);
            Pen penG = new Pen(Color.Green, 2f);
            Pen penBlue = new Pen(Color.Blue, 2f);
            Font drawFont = new Font("Arial", 14);
            SolidBrush brush = new SolidBrush(Color.Blue);
            StringFormat stringFormat = new StringFormat();
            stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            graphics.DrawLine(penBlue, 10, 225, 586, 225);
            graphics.DrawLine(penBlue, 293, 10 , 293, 450);

            PointF PointF1 = new PointF(287, 100);
            graphics.DrawString("-  1", drawFont, brush, PointF1);
            PointF PointF2 = new PointF(287, 325);
            graphics.DrawString("-  -1", drawFont, brush, PointF2);


            Point[] PBlack = new Point[1000];
            Point[] PRed = new Point[1000];
            Point[] PGReen = new Point[1000];

            for (int i = 0; i < 1000; i++)
            {
                PBlack[i] = new Point(i,(int)(Math.Cos((double)i/30)*112 + 225));
                PRed[i] = new Point(i+5, (int)(Math.Cos((double)i / 30) * 112 + 225));
                PGReen[i] = new Point(i+10, (int)(Math.Cos((double)i / 30) * 112 + 225));
                  
            }
            graphics.DrawLines(penB, PBlack);
            graphics.DrawLines(penR, PRed);
            graphics.DrawLines(penG, PGReen);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ImageFormat img = ImageFormat.Jpeg;
            saveFileDialog1.ShowDialog();
            Rectangle bounds = this.Bounds;
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            try { bitmap.Save(saveFileDialog1.FileName, img); }
            catch { MessageBox.Show("Изображение не сохранено"); }
        }

        private void buttonAnimeWindow_Click(object sender, EventArgs e)
        {
            Form Anim = new FormAnim();
            Anim.Show();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            Form Five = new FormFive();
            Five.Show();
        }
    }
}
