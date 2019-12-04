using System;

namespace MultiplicacionMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplicacion de matrices");
            MultMat mult = new MultMat(2, 50000);

            // Usando hilos
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("AxB Threads:");
            int[,] resT = mult.MultThreads();
            watch.Stop();
            System.Console.WriteLine("Tiempo: " + watch.ElapsedMilliseconds);
            System.Console.WriteLine();

            /*
            // De forma iterativa
            watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("AxB Iterativo:");
            resT = mult.MultIter();
            watch.Stop();
            System.Console.WriteLine("Tiempo: " + watch.ElapsedMilliseconds / 1000);
            System.Console.WriteLine();
            //*/
        }
    }
}
