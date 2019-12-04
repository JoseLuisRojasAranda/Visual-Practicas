using System;
using System.Threading;

namespace OsoYAbejas
{
    public class Abeja
    {
        private Tarro tarro;
        private int capacidad;
        private Thread thread;

        public Abeja(Tarro _tarro, int _capacidad)
        {
            capacidad = _capacidad;
            tarro = _tarro;
            thread = new Thread(Update);
            thread.Start();
        }

        public void Update()
        {
            var rand = new Random();

            while (true)
            {
                //Thread.Sleep(rand.Next(200, 1000));

                if (!tarro.llenando)
                {
                    tarro.llenar(capacidad);
                }

            
            }
        }
    }
}
