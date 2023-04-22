using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitmapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WYSZUKAJ_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open Image";
                ofd.Filter = "bmp files (*.bmp)|*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(Image.FromFile(ofd.FileName));
                    pictureBox1.Image = bitmap;

                    this.Controls.Add(pictureBox1);
                }
            }
        }

        private void OBROT_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = (Image)bmp;
        }

        private void odbicie_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap tmp = new Bitmap(bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    tmp.SetPixel(x, y, bmp.GetPixel(tmp.Width - x - 1, y));
                }
            }
            pictureBox1.Image = (Image)tmp;
        }

        private void DWAODBICIE_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap tmp = new Bitmap(bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    tmp.SetPixel(x, y, bmp.GetPixel(x, tmp.Height - y - 1));
                }
            }
            pictureBox1.Image = (Image)tmp;
        }
    }
}
