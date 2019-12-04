using System;
using System.Diagnostics;

namespace NeuralNetwork_LAB
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            NeuralNetwork nn = new NeuralNetwork(10, 5, 3, 5000);

            float[] input = { 1.0f, 0.3f, 0.6f, 0.9f, 1.0f };
            float[] input2 = { 1.0f, 0.3f, 0.6f, 0.9f, 1.0f };
            float[] output;

            NeuralWorker worker = new NeuralWorker(nn, 25);

            Console.WriteLine("FeedForward iterativo");
            var watch = new Stopwatch();
            watch.Start();
            output = nn.Feedforward(input);
            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds);
            //for (int i = 0; i < output.Length; i++)
              //  System.Console.WriteLine(output[i]);

            Console.WriteLine("FeedForward paralelo");
            watch.Restart();
            output = worker.FeedForward(input2);
            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds);
            //for (int i = 0; i < output.Length; i++)
              //  System.Console.WriteLine(output[i]);

        }
    }
}
