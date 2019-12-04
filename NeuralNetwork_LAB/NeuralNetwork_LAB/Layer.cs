using System;
namespace NeuralNetwork_LAB
{
    public class Layer
    {
        public float[,] weights;

        public int numNeurons;
        public int numInputs;

        public float[] Outputs;

        public float[] bias;


        public Layer(int numNeurons, int numInputs)
        {
            this.numNeurons = numNeurons;
            this.numInputs = numInputs;
            weights = new float[numInputs, numNeurons];

            Outputs = new float[numNeurons];
            bias = new float[numNeurons];

            InitializeParams();


        }

        private void InitializeParams()
        {
            var rand = new Random();


            for (int i = 0; i < numInputs; i++)
            {

                for (int j = 0; j < numNeurons; j++)
                {
                    weights[i, j] = (float)rand.Next(-10, 10);


                }
            }

            for (int i = 0; i < numNeurons; i++)
            {
                bias[i] = (float)rand.Next(1, 10);

            }

        }
        public float Activation(float x)
        {

            return (float)Math.Tanh((double)x);

        }


        //create feed : inputs : array de inputs 
        //regresa una array de outputs

        public float [] feed(float [] ins){
            float[] outs = new float[numNeurons];


            for (int i = 0; i < numNeurons; i++)
            {
                for (int j = 0; j < numInputs; j++)
                {

                    outs[i] += ins[j] * weights[j, i];
                }
                outs[i] = Activation(outs[i] + bias[i]);
            }



            return outs;

        }
    }
}
