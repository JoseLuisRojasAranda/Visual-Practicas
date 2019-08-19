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
            membersList.RemoveAt(0);

            if(membersList.Count > 0)
            {
                if (membersList.Count % 2 != 0)
                {
                    ErrorCalculadora();
                    return;
                }

                for (int i = 0; i < membersList.Count; i+=2)
                {
                    float n;
                    try
                    {
                        n = loadNum(membersList[i + 1]);
                    } catch(CalculadoraException e)
                    {
                        ErrorCalculadora();
                        return;
                    }
                    
                    switch (membersList[i])
                    {
                        case "+":
                            aux += n;
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

                case "-":
                    return true;

                case "X":
                    return true;

                case "/":
                    return true;

            }

            return false;
        }

        private void ErrorCalculadora()
        {
            texto_mensaje.Text = "Error";
            ans = 0;
        }
    }
}
