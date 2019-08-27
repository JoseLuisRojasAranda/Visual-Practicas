using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blocnotas
{
    public partial class Form2 : Form
    {
        Form1 form1Ref;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1Ref = form1;
        }

        private void Boton_buscar_Click(object sender, EventArgs e)
        {
            form1Ref.Buscar(textBox1.Text);
        }
    }
}
