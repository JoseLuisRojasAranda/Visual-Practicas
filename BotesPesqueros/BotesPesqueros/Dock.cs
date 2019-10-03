using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BotesPesqueros
{
    public class Dock
    {
        public ConcurrentQueue<Boat> waitingQ;      // Queue with boats waiting to go fishing

        private int maxBoatsFishing = 3;
        private int boatsFishing = 0;

        private int waitingX = 250;
        private int waitingY = 380;
        private int waitingS = 100;

        private int fishingAreaX = 50;
        private int fishingAreaY = 50;
        private int fishingAreaWidth = 500;
        private int fishingAreaHeight = 200;

        private Thread thread;

        public Boolean running = true;  // If the thread is running

        public Dock()
        {
            waitingQ = new ConcurrentQueue<Boat>();
        }

        public void Start()
        {
            thread = new Thread(DockUpdate);
            thread.Start();
        }

        private void DockUpdate() {
            var random = new Random();
            while (true)
            {
                if(boatsFishing < maxBoatsFishing && waitingQ.Count > 0)
                {
                    boatsFishing++;
                    SendBoatToFishing();
                    Thread.Sleep(random.Next(1000, 2000));
                }

                if(running == false)
                {
                    break;
                }

                Thread.Sleep(50);
            }
        }

        private void SendBoatToFishing()
        {
            Boat boat;
            if(waitingQ.TryDequeue(out boat))
            {
                var random = new Random();
                boat.MoveTowards(fishingAreaX + random.Next(fishingAreaWidth), 
                    fishingAreaY + random.Next(fishingAreaHeight));
                boat.fishing = true;


                Boat[] boats = waitingQ.ToArray();
                for(int i = 0; i < boats.Length; i++) {
                    boats[i].MoveTowards(waitingX + (i) * waitingS, waitingY);
                }
            }
        }

        // Called by the boat to request a space to fish
        // if there is space aviable, if not its added to the queue
        public void RequestFishing(Boat boat)
        {
            waitingQ.Enqueue(boat);
            int qSize = waitingQ.Count;

            boat.MoveTowards(waitingX + (qSize - 1) * waitingS, waitingY);
            boat.waitingSpace = false;
        }

        // Called by the Form construcutor to assing some initial space to the boat
        // in the dock
        public int[] AssignPosition(Boat boat)
        {
            int[] position = new int[2];
            waitingQ.Enqueue(boat);
            int qSize = waitingQ.Count;

            position[0] = waitingX + (qSize - 1) * waitingS;
            position[1] = waitingY;
            boat.waitingSpace = false;

            return position;
        }

        // Method called by the boat when it ends fishing
        public void BoatFinishFishing()
        {
            boatsFishing--;
        }
    }
}
