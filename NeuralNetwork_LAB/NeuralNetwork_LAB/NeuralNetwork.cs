using System;
namespace NeuralNetwork_LAB
{
    public class NeuralNetwork
    {
        public int numLayers;
        public int numInputs;
        public int numOutputs;
        public int layerNeurons;
        public Layer[] layers;


        public NeuralNetwork(int numLayers, int numInputs, int numOutputs, int layerNeurons)
        {
            this.numLayers = numLayers;
            this.numInputs = numInputs;
            this.numOutputs = numOutputs;
            this.layerNeurons = layerNeurons;
            layers = new Layer[numLayers];

            Build();
        }

        private void Build()
        {
            for (int i = 0; i < numLayers; i++)
            {

                if (i == 0)
                {
                    layers[i] = new Layer(layerNeurons, numInputs);
                }
                else if (i == numLayers - 1)
                {
                    layers[i] = new Layer(numOutputs, layerNeurons);
                }
                else
                {
                    layers[i] = new Layer(layerNeurons, layerNeurons);
                }
            }


        }

        public float[] Feedforward(float[] ins)
        {

            float[] outff = null;

            for (int i = 0; i < numLayers; i++)
            {
                if (i == 0) { outff = layers[i].feed(ins); }
                outff = layers[i].feed(outff);
            }

            return outff;

        }

    }
}

// create feedforwaers in: arry de inputs regresa el output  array d ela ultima capa.

