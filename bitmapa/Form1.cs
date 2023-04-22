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
    }
}
