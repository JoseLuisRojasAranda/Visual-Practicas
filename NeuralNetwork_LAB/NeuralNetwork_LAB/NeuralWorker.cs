using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace NeuralNetwork_LAB
{
    public class FeedJob {
        // Clase que guarda la informacion sobre el trabajo y lo que va realizar el hilo
        public int layer;                   // Numero de la layer
        public Layer jobLayer;              // Referencia a la capa donde se esta trabajando
        public float[] jobInput;            // Input a la capa
        public float[] jobOutput;           // Output de la capa
        public int startingIndex;           // El indice donde empieza las neuronas del job
        public int finishIndex;             // El indice donde termina las neuronas del job

        public FeedJob(int layer, Layer jobLayer, float[] jobInput, float[] jobOutput, int startingIndex, int finishIndex) {
            this.layer = layer;
            this.jobLayer = jobLayer;
            this.jobInput = jobInput;
            this.jobOutput = jobOutput;
            this.startingIndex = startingIndex;
            this.finishIndex = finishIndex;
        }

        // Metodo que realiza la operaciones de la red nueronal
        public void DoJob() {
            // Recoorre todas las neuronas asignadas, asegurnadose de que el no exista overflow
            // Solo realiza la computacion de esas capas
            //Console.WriteLine("Start Index: " + startingIndex);
            //Console.WriteLine("Finishing Index: " + finishIndex);

            for (int i = startingIndex; i < jobLayer.numNeurons && i < finishIndex; i++) {
                //Console.WriteLine("Index: " + i);
                jobOutput[i] = 0;

                for (int j = 0; j < jobLayer.numInputs; j++) {
                    jobOutput[i] += jobLayer.weights[j, i] * jobInput[j];
                }

                jobOutput[i] = jobLayer.Activation(jobOutput[i] + jobLayer.bias[i]);
            }

        }
    }

    public class NeuralWorker
    {
        // Clase encargada de realizar la computacion de feedforward de la red nueronal
        // usando hilos, con una estructura de jobs

        public NeuralNetwork net;                   // Referencia a la red neuronal
        public int numWorkers;                      // Numero maximo de threads que puede crear
        public Thread[] workers;                    // Arreglo con los threads
        public ConcurrentQueue<FeedJob> dueJobs;              // Trabajos pendientes a hacer
        private int minWorkLoad = 10;               // Minimo de neuronas que procesa cada capa

        public float[][] activations;               // Arreglo que va guardando las activaciones
        public float[] outputActivation;            // Arreglo con las activaciones de la ultima capa

        public float[] input;                       // Arreglo con input a la red
        
        public NeuralWorker(NeuralNetwork net, int numWorkers)
        {
            this.net = net;
            this.numWorkers = numWorkers;
            workers = new Thread[this.numWorkers];
            dueJobs = new ConcurrentQueue<FeedJob>();

            activations = new float[net.numLayers][];

            outputActivation = new float[net.numOutputs];

            //CreateJobs();
        }

        // Metodo que realiza el feedforward de la red nueronal
        public float[] FeedForward(float[] input) {
            this.input = input;
            CreateJobs();

            Thread scheduler = new Thread(ScheduleJobs);
            scheduler.Start();
            scheduler.Join();

            return activations[activations.Length - 1];
        }

        // Metodo que empieza a realizar los trabajos
        private void ScheduleJobs() {
            int currentLayer = 0;
            FeedJob job;
            while(dueJobs.Count > 0) {
                int workerCount = 0;
                while(dueJobs.TryPeek(out job)) {
                    if(job.layer == currentLayer) {
                        if(dueJobs.TryDequeue(out job)) {
                            workers[workerCount] = new Thread(() => DoJob(job));
                            workers[workerCount].Start();
                            workerCount++;
                            //Console.WriteLine("Job performed");
                        }
                    }
                    else {
                        break;
                    }
                }

                foreach(var worker in workers) {
                    if(worker != null)
                        worker.Join();
                }

                currentLayer++;
            }
        }

        private void DoJob(FeedJob job) {
            if(job != null)
                job.DoJob();
        }

        // Metodo que crea todos los trabajos de las capas
        private void CreateJobs() {
            // Recorre todas las capas de la red
            for(int i = 0; i < net.numLayers; i++) {
                int numNeurons = net.layers[i].numNeurons;
                activations[i] = new float[numNeurons];

                // Escoge en input adecuado y outpud donde se va guardar
                float[] inputL; float[] outputL;

                if (i == 0)
                    inputL = input;
                else
                    inputL = activations[i-1];

                outputL = activations[i];

                // Checa como se van a distribuir el trabajo en los hilos
                int load = (int)Math.Floor((double)numNeurons / numWorkers);

                // Si el load promedio es menor que el load minimo, se pone el load minimo
                // esto va a causar que no todos los workers hagan algo
                if(load < minWorkLoad) {
                    load = minWorkLoad;
                }

                // Espicifica los indices que cada worker va a trabajar en
                int start;
                int end = 0;
                int jobsCreated = 0;

                // Crea los jobs, conforme el load actual y el numero de neuronas pendientes
                while(jobsCreated < numWorkers && numNeurons > 0)
                {
                    jobsCreated++;

                    start = end;

                    // Si es el ultimo job asegura que se agrege todo el trabajo necesario
                    if (jobsCreated == numWorkers) {
                        end += numNeurons;
                        numNeurons = 0;
                    } else {
                        end += load;
                        numNeurons -= load;
                    }

                    var job = new FeedJob(i, net.layers[i], inputL, outputL, start, end);
                    dueJobs.Enqueue(job);

                    // Debugging
                    //System.Console.WriteLine("Job created, starts: " + start + " ends: " + end);
                }
            }
        }
    }
}
