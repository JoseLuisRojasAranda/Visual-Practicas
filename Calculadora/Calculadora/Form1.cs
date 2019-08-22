using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private float ans;
        private float aux;
        private string operation;
        private int num_member;

        public Calculadora()
        {
            InitializeComponent();
            operation = "";
            ans = 0.0f;
            num_member = 0;
        }

        private void HandleButton(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            string txt = boton.Text;

            if (txt == "=")
            {
                if (num_member > 0)
                {
                    DoOperation();
                    operation = "";
                    num_member = 0;
                }
            }
            else
            {
                if (IsOperation(txt))
                {
                    txt = txt.Insert(0, " ");
                    txt += " ";

                    if (num_member == 0)
                        txt = txt.Insert(0, "ans");
                }

                operation += txt;
                texto_mensaje.Text = operation;
                num_member ++;
            }
        }

        private float loadNum(string mem)
        {
            if (mem == "ans")
                return ans;

            float res;
            try {
                res = float.Parse(mem, CultureInfo.InvariantCulture.NumberFormat);
            } catch (Exception e)
            {
                throw (new CalculadoraException("Numero no valido"));
            }

            return res;
        }

        private void DoOperation() {
            string[] members = operation.Split(' ');
            List<string> membersList = members.ToList();

            try
            {
                aux = loadNum(membersList[0]);
            } catch(CalculadoraException e)
            {
                ErrorCalculadora();
                return;
            }

            if (membersList[membersList.Count - 1] != "!")
                membersList.RemoveAt(0);

            if(membersList.Count > 0)
            {
                if (membersList[membersList.Count-1] != "!" && membersList.Count % 2 != 0)
                {
                    ErrorCalculadora();
                    return;
                }

                for (int i = 0; i < membersList.Count-1; i+=2)
                {
                    float n;
                    string op = " ";
                    try
                    {
                        n = loadNum(membersList[i + 1]);
                    } catch(CalculadoraException e)
                    {
                        System.Console.WriteLine("Hola");
                        System.Console.WriteLine(membersList[i]);
                        if (membersList[i] == "!")
                        {
                           
                            op = "!";
                            //n = loadNum(membersList[i]);
                            n = aux;
                        }
                        else
                        {
                            ErrorCalculadora();
                            return;
                        }
                    }

                    if(op == " ")
                        op = membersList[i];

                    switch (op)
                    {
                        case "+":
                            aux += n;
                            break;

                        case "--":
                            aux -= n;
                            break;

                        case "X":
                            aux *= n;
                            break;

                        case "/":
                            aux /= n;
                            break;

                        case "^":
                            aux = (float)Math.Pow((double)aux, (double)n);
                            break;

                        case "!":
                            float aux2 = aux;
                            if (aux2 == 0)
                            {
                                aux = 1;
                            }
                            else
                            {
                                for (int a = (int)aux2 - 1; a > 1; a--)
                                    aux2 *= a;

                                aux = aux2;
                            }
                            
                            break;
                    }
                }
            }

            texto_mensaje.Text = aux.ToString();
            ans = aux;
        }

        private bool IsOperation(string txt)
        {
            switch(txt)
            {
                case "+":
                    return true;

                case "--":
                    return true;

                case "X":
                    return true;

                case "/":
                    return true;

                case "^":
                    return true;

                case "!":
                    return true;

            }

            return false;
        }

        private void ErrorCalculadora()
        {
            texto_mensaje.Text = "Error";
            ans = 0;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
