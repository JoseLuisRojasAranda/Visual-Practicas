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

        private int waitingX;
        private int waitingY;
        private int waitingS;

        public Dock()
        {
            waitingX = 100;
            waitingY = 350;
            waitingS = 100;
            waitingQ = new ConcurrentQueue<Boat>();
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
    }
}
