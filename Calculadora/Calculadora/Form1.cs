using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private float ans;
        private string operation;

        public Calculadora()
        {
            InitializeComponent();
            operation = "";
        }

        private void HandleButton(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            string txt = boton.Text;

            if (txt == "=")
            {
                texto_debug.Text = operation;
                string[] words = operation.Split(' ');
                foreach(var word in words) {
                    System.Console.WriteLine(word);
                }
            }
            else
            {
                if (IsOperation(txt))
                {
                    txt = txt.Insert(0, " ");
                    txt += " ";
                }

                operation += txt;
                texto_mensaje.Text = operation;
            }
        }

        private bool IsOperation(string txt)
        {
            switch(txt)
            {
                case "+":
                    return true;

                case "-":
                    return true;

                case "X":
                    return true;

                case "/":
                    return true;

            }

            return false;
        }
    }
}
