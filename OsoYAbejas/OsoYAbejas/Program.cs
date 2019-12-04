using System;

namespace OsoYAbejas
{
    class Program
    {
        private static int numAbejas;
        private static Abeja[] abjeas;

        static void Main(string[] args)
        {
            System.Console.WriteLine("Programa de Oso y Abjeas");

            //TodosHilos();
            OsoYAbjeas();
        }

        static void TodosHilos() {
            numAbejas = 2;
            Tarro tarro = new Tarro(50);

            Oso oso = new Oso(tarro);

            abjeas = new Abeja[numAbejas];
            for (int i = 0; i < numAbejas; i++)
                abjeas[i] = new Abeja(tarro, 10);
        }

        static void OsoYAbjeas() {
            numAbejas = 2;
            Tarro tarro = new Tarro(50);

            var oso = new Oso(tarro);

            var abjeas = new Abjeas(numAbejas, 10, tarro);
        }
    }
}
