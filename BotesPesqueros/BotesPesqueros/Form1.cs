using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotesPesqueros
{
    public partial class Form1 : Form
    {
        private int numBoats = 5;
        private Boat[] boats;
        private Dock dock;
        Timer t;
        public Form1()
        {
            InitializeComponent();

            dock = new Dock();
            boats = new Boat[numBoats];
            for(int i = 0; i < numBoats; i++)
            {
                boats[i] = new Boat(this, dock);
            }

            t = new Timer();
            t.Interval = 33;
            t.Tick += new EventHandler(this.update_frame);
            t.Start();
        }

        private void update_frame(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < numBoats; i++)
            {
                e.Graphics.DrawImage(boats[i].image, boats[i].x, boats[i].y);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < numBoats; i++)
            {
                boats[i].running = false;
            }
        }
    }
}
