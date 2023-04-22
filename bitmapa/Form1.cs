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

        private void zielony_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    if (g > b + 20 && g > r + 20)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(a, 255, 255, 255));
                    }

                    pictureBox1.Image = bmp;
                }
            }
        }

        private void NEGATYW_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                    pictureBox1.Image = bmp;
                }
            }
        }
    }
}
