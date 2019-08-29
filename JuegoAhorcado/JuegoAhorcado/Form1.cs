using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoAhorcado
{
    public partial class Form1 : Form
    {
        private string palabra;
        private List<char> letrasAdivinadas;
        private int intentos;
        public Form1()
        {
            InitializeComponent();

            IniciarJuego();
        }

        private void IniciarJuego()
        {
            palabra = "VISUALI";
            letrasAdivinadas = new List<char>();
            GeneraPalabraVista();
            intentos = 3;
            VisualizarIntentos();

            adivinar_button.Enabled = true;
        }

        private void VisualizarIntentos()
        {
            string gen = "Intentos: ";
            for (int i = 0; i < intentos; i++)
                gen += "*";

            intentos_label.Text = gen;
        }

        private void GeneraPalabraVista()
        {
            Random rnd = new Random();
            int p = rnd.Next(0, palabra.Length);
            letrasAdivinadas.Add(palabra[p]);
            VisualizaPalabra();
        }

        private void VisualizaPalabra()
        {
            string gen = "Palabra: ";
            for(int i = 0; i < palabra.Length; i++)
            {
                if(EsLetraAdivinada(palabra[i]))
                {
                    gen += palabra[i];
                } else
                {
                    gen += "_";
                }
            }

            palabra_label.Text = gen;
        }

        private bool EsLetraDePalabra(char l)
        {
            for(int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == l)
                    return true;
            }

            return false;
        }

        private bool EsLetraAdivinada(char l)
        {
            for(int i = 0; i < letrasAdivinadas.Count; i++)
            {
                if (l == letrasAdivinadas[i])
                    return true;
            }

            return false;
        }

        private void EquivocoJugador()
        {
            intentos--;
            VisualizarIntentos();
            
            if(intentos == 0)
            {
                PerdioJugador();
            }
        }

        private void AdivinoPalabra()
        {
            letrasAdivinadas.Clear();
            for(int i = 0; i < palabra.Length; i++)
            {
                letrasAdivinadas.Add(palabra[i]);
            }

            VisualizaPalabra();
            GanoJugador();
        }

        private void GanoJugador()
        {
            adivinar_button.Enabled = false;
            System.Console.WriteLine("Gano jugador");
            DialogResult res = MessageBox.Show("Ganaste! ¿Deseas volver a jugar?", "Ganaste", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
                IniciarJuego();
            else
                this.Close();
        }

        private void PerdioJugador()
        {
            adivinar_button.Enabled = false;
            System.Console.WriteLine("Perdio jugador");
            DialogResult res = MessageBox.Show("Perdiste. ¿Deseas volver a jugar?", "Perdiste", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
                IniciarJuego();
            else
                this.Close();
        }

        private bool ChecarPalabra()
        {
            for(int i = 0; i < palabra.Length; i++)
            {
                if (!EsLetraAdivinada(palabra[i]))
                    return false;
            }

            return true;
        }

        private void Adivinar_button_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if(input.Length == 0)
            {
                EquivocoJugador();
            }
            else
            {
                input = input.ToUpper();
                if(input.Length > 1)
                {
                    if (input == palabra)
                        AdivinoPalabra();
                    else
                        EquivocoJugador();
                } 
                else
                {
                    if (EsLetraDePalabra(input[0]) && !EsLetraAdivinada(input[0]))
                    {
                        letrasAdivinadas.Add(input[0]);
                        VisualizaPalabra();
                        if (ChecarPalabra())
                            GanoJugador();
                    }
                    else
                        EquivocoJugador();
                }
             }

            textBox1.Text = "";
        }
    }
}
