using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase07_imgs
{
    public partial class Form1 : Form
    {
        Bitmap bmap;
        public Form1()
        {
            InitializeComponent();

            bmap = (Bitmap)Image.FromFile(@"C:\Users\Jose Luis\Desktop\manzana.PNG");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

            Color c;
            Color nc;
            
            for(int y = 0; y < bmap.Height; y++)
            {
                for (int x = 0; x < bmap.Width; x++)
                {
                    c = bmap.GetPixel(x, y);
                    nc = Color.FromArgb(255-c.R, 255-c.G, 255-c.B);
                    bmap.SetPixel(x, y, nc);
                }
            }

            e.Graphics.DrawImage(bmap, 100, 100);
        }
    }
}
