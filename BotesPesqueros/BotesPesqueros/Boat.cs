using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace BotesPesqueros
{
    public class Boat
    {
        public float x;                 // x position of the boat
        public float y;                 // y position of the boat

        private float mx;               // position to move in the x axis
        private float my;               // position to move in the y axis
        private int xDir;               // The direction of the movement in the x axis
        private int yDir;               // The direction of the movement in the y axis
        private float velocity = .03f;  // Velocity of the boat

        public Image image;             // Reference to image boat

        private Form form;              // Reference to the foarm object of the window
        private Dock dock;              // Reference to the dock controlling the boats

        // Propiertes for the state of the boat
        public Boolean moving;
        public Boolean waitingSpace;
        public Boolean fishing;
        public Boolean startFishing;

        private int fishingTime;

        public Thread thread;           // Thread with the boat lopp
        public Boolean running = true;  // If the thread is running
        private Stopwatch sw;           // Stopwatch to measuer time in the thread
        private Stopwatch swMv;         // Stopwathc for the movement of the boat

        public Boat(Form form, Dock dock) {
            this.form = form;
            this.dock = dock;

            waitingSpace = true;
            fishing = false;
            startFishing = false;
            moving = false;

            int[] position = dock.AssignPosition(this);
            this.x = position[0];
            this.y = position[1];

            // Reads image file
            image = Image.FromFile(@"C:\Users\jose luis\Desktop\Visual-Practicas\resources\bote.png");

            // Intializes the stopwatches
            sw = new Stopwatch();
            swMv = new Stopwatch();

            // Starts update thread
            thread = new Thread(BoatUpdate);
            thread.Start();
        }

        public void MoveTowards(int x, int y)
        {
            mx = (float)x;
            my = (float)y;

            xDir = (mx > this.x) ? 1 : -1;
            yDir = (my > this.y) ? 1 : -1;

            moving = true;

            swMv.Restart();
        }

        private void BoatUpdate()
        {
            var rand = new Random();
            //sw.Start();
            swMv.Start();
            long dt;
            while (true)
            {
                // Movement
                if ((dt = swMv.ElapsedMilliseconds) > 50)
                {
                    if (moving)
                    {
                        if ((xDir == 1 && mx - x <= 0) || (xDir == -1 && x - mx <= 0))
                            x = mx;
                        else
                            x += xDir * (dt / (velocity * 1000.0f));

                        if ((yDir == 1 && my - y <= 0) || (yDir == -1 && y - my <= 0))
                            y = my;
                        else
                            y += yDir * (dt / (velocity * 1000.0f));

                        if (x != mx || y != my)
                        {
                            //form.Invalidate();
                        }
                        if(x == mx && y == my)
                        {
                            moving = false;
                            if(fishing && !startFishing)
                            {
                                startFishing = true;
                                sw.Restart();
                                fishingTime = rand.Next(5000, 15000);
                            }
                        }
                    }

                    swMv.Restart();
                }

                if(startFishing && sw.ElapsedMilliseconds > fishingTime)
                {
                    fishing = false;
                    startFishing = false;
                    dock.RequestFishing(this);
                    dock.BoatFinishFishing();
                }

                if(running == false)
                {
                    break;
                }
                //*/

                Thread.Sleep(10);
            }
        }
    }
}
