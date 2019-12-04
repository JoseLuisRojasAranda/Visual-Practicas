using System;
using System.Threading;
namespace OsoYAbejas
{
    public class Oso
    {
        Tarro tarro;

        public Oso(Tarro _tarro)
        {
            tarro = _tarro;
            Thread thread = new Thread(Update);
            thread.Start();
        }

        public void Update()
        {
            while(true)
            {
                if (tarro.llenado)
                {
                    tarro.vaciar();
                    System.Console.WriteLine("Oso comio tarro de miel");
                    //break;
                }
            }
        }
    }
}
