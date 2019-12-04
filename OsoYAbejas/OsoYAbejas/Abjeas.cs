using System;
using System.Threading;

namespace OsoYAbejas
{
    public class Abjeas
    {
        private int numAbjeas;
        private int capacidad;
        private int abejaIndex;
        private Tarro tarro;

        public Abjeas(int _numAbjeas, int _capacidad, Tarro _tarro)
        {
            numAbjeas = _numAbjeas;
            capacidad = _capacidad;
            abejaIndex = 0;
            tarro = _tarro;

            Thread thread = new Thread(Update);
            thread.Start();
        }

        public void Update()
        {
            while (true)
            {
                if(!tarro.llenando)
                {
                    tarro.llenar(capacidad);
                    abejaIndex++;

                    if (abejaIndex == numAbjeas)
                        abejaIndex = 0;
                }
            }
        }
    }
}
