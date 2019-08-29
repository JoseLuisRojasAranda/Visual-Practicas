using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase06
{
    public partial class Form1 : Form
    {
        private int rx = 100;
        private int ry = 100;
        private int rw = 100;
        private int rh = 100;

        private int mx;
        private int my;

        private int arx;
        private int ary;

        private Boolean abajo = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(255, 0,0);
            Pen p = new Pen(color);
            SolidBrush b = new SolidBrush(color);

            e.Graphics.DrawRectangle(p, rx, ry, rw, rh);
            e.Graphics.FillRectangle(b, rx, ry, rw, rh);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //rx = e.X;
            //ry = e.Y;
            //this.Refresh();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
           

        }

        private void Form1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (abajo)
            {
                int ex = e.X;
                int ey = e.Y;

               
                rx = arx + (ex - mx);
                ry = ary + (ey - my);
                //Form.Re
                //Application.DoEvents();
                panel1.Invalidate();
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(255, 0, 0);
            Pen p = new Pen(color);
            SolidBrush b = new SolidBrush(color);

            e.Graphics.DrawRectangle(p, rx, ry, rw, rh);
            e.Graphics.FillRectangle(b, rx, ry, rw, rh);

            p.Dispose();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mx = e.X;
            my = e.Y;
            arx = rx;
            ary = ry;
            int ex = e.X;
            int ey = e.Y;

            if (ex >= rx && ex <= rx + rw && ey >= ry && ey <= ry + rh)
                abajo = true;
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            abajo = false;
        }
    }
}
