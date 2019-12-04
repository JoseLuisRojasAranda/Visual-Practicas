using System;
using System.Threading;
namespace MultiplicacionMatrices
{
    public class MultMat
    {
        private int divisons = 5;
        private int sizeRatio = 20;
        private int size;

        private int[,] matA;
        private int[,] matB;
        private int[,] result;

        public MultMat(int _divisions, int _sizeRatio)
        {
            divisons = _divisions;
            sizeRatio = _sizeRatio;

            size = divisons * sizeRatio;
            System.Console.WriteLine("Tamaño de matrices: " + size);

            matA = GenMatrix(size);
            matB = GenMatrix(size);

            result = new int[size, size];

            System.Console.WriteLine("Tamaño de matrices: " + size);
            System.Console.WriteLine("Numero de hilos: " + divisons * divisons);
            System.Console.WriteLine();
        }

        public int[,] MultThreads() {
            Thread[,] threads = new Thread[divisons, divisons];
            for(int i = 0; i < divisons; i++) {
                for(int j = 0; j < divisons; j++) {
                    int startR = divisons * i;
                    int startC = divisons * j;

                    threads[i, j] = new Thread(() => MultRxC(startR, startC));
                    threads[i, j].Start();
                }
            }

            foreach (var t in threads)
                t.Join();

            return result;
        }

        public int[,] MultIter() {
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < size; k++)
                    {
                        sum += matA[i, k] * matB[k, j];
                    }

                    result[i, j] = sum;
                }
            }

            return result;
        }

        private void MultRxC(int startR, int startC)
        {
            for(int r = startR; r < startR + divisons; r++) {
                for(int c = startC; c < startC + divisons; c++) {
                    int sum = 0;
                    for (int i = 0; i < size; i++)
                        sum += matA[r, i] * matB[i, c];

                    result[r, c] = sum;
                }
            }
        }

        // Metodo que crea matriz con numeros aleatorios
        private int[,] GenMatrix(int n)
        {
            System.Console.WriteLine("Hola " + n);
            int[,] mtrx = new int[n, n];
            System.Console.WriteLine("Adios");
            var rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mtrx[i, j] = 1; //rand.Next(10);
                }
            }

            return mtrx;
        }

        // Metodo que imprie matriz
        private void PrintMtrx(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0}\t", mat[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
