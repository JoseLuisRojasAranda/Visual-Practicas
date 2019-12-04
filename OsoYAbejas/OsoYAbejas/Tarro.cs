using System;
using System.Threading;

namespace OsoYAbejas
{
    public class Tarro
    {
        private int capacidad;
        private int nivel;
        public Boolean llenando;
        public Boolean llenado;

        public Tarro(int _capacidad)
        {
            capacidad = _capacidad;
            nivel = 0;
            llenado = false;
            llenando = false;
        }

        public void llenar(int cantidad) {
            llenando = true;
            Thread.Sleep(100);

            System.Console.WriteLine("Abjea llenando");

            for (int i = 0; i < cantidad; i++)
                nivel++;

            System.Console.WriteLine("Nivel: " + nivel);
            if (nivel >= capacidad)
            {
                llenado = true;
            }
            else
                llenando = false;
        }

        public void vaciar()
        {
            nivel = 0;
            llenado = false;
            llenando = false;
        }
    }
}
