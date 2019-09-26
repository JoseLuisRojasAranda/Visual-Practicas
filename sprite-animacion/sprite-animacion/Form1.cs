using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprite_animacion
{
    public partial class Form1 : Form
    {
        private int imgX;
        private int imgY;

        private int xDir;
        private int yDir;

        private int velocidad;

        private List<Image> animaciones;
        private Image current;
        private int animIndex;

        Timer t;
        public Form1()
        {
            InitializeComponent();

            t = new Timer();
            t.Interval = 33;
            t.Tick += new EventHandler(this.update_frame);
            t.Start();

            imgX = 100;
            imgY = 100;

            velocidad = 5;

            animaciones = new List<Image>();
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_0.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_1.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_2.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_3.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_4.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_5.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_6.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_7.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_8.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_9.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_10.tiff"));
            animaciones.Add(Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_11.tiff"));

            current = animaciones[0];

            animIndex = 0;


        }

        private void update_frame(object sender, EventArgs e)
        {
            if(xDir != 0  || yDir != 0)
            {
                current = (Image)animaciones[animIndex].Clone();
                animIndex++;
                if (animIndex >= animaciones.Count)
                    animIndex = 0;

                if (xDir == -1)
                    current.RotateFlip(RotateFlipType.RotateNoneFlipX);

                imgX += xDir * velocidad;
                imgY += yDir * velocidad;
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Image img = Image.FromFile(@"C:\Users\Jose Luis\Desktop\Visual-Practicas\resources\sprite_0.tiff");
            e.Graphics.DrawImage(current, imgX, imgY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                xDir = -1;
            }

            if (e.KeyCode == Keys.D)
            {
                xDir = 1;
            }

            if (e.KeyCode == Keys.W)
            {
                yDir = -1;
            }

            if (e.KeyCode == Keys.S)
            {
                yDir = 1;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            {
                xDir = 0;
                animIndex = 0;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S)
            {
                yDir = 0;
                animIndex = 0;
            }
        }
    }
}
