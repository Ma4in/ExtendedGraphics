using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Imaging;

namespace ExtendedGraphics
{
    public partial class FormFive : Form
    {
        public FormFive()
        {
            InitializeComponent();
        }

        private void гномToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("gnome.jpg");
            SoundPlayer YUUUUU = new SoundPlayer("Gnome.wav");
            YUUUUU.Play();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageFormat img = ImageFormat.Jpeg;
            saveFileDialog1.ShowDialog();
            Rectangle bounds = this.Bounds;
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            try { bitmap.Save(saveFileDialog1.FileName, img); }
            catch
            {
                MessageBox.Show("Nope");
            }
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen one = new Pen(Color.Black, 6);
            SolidBrush brush = new SolidBrush(Color.Blue);
            g.DrawEllipse(one, 200, 200, 200, 200);
            g.FillEllipse(brush, 200, 200, 200, 200);
        }

        private void овалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen one = new Pen(Color.Black, 6);
            SolidBrush brush = new SolidBrush(Color.Wheat);
            g.DrawEllipse(one, 200, 250, 200, 100);
            g.FillEllipse(brush, 200, 250, 200, 100);
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen one = new Pen(Color.Red, 6);
            g.DrawRectangle(one, 200, 200, 200, 200);
        }

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen one = new Pen(Color.Green, 6);
            Point[] tr = new Point[]
            {
                new Point(300, 150),
                new Point(100, 450),
                new Point(450, 450)
                
            };
            g.DrawPolygon(one, tr);
        }

        private void даToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Font font1 = new Font("Arial", 50);
            PointF point = new PointF(200, 500);
            g.DrawString("Yes", font1, Brushes.Red, point);
        }
    }
}
