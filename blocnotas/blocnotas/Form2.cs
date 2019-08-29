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
    public partial class f_siguiente : Form
    {
        private Form1 form1Ref;
        private List<int> searchIndices;
        private int selected = 0;
        public f_siguiente(Form1 form1)
        {
            InitializeComponent();
            this.form1Ref = form1;
            this.searchIndices = new List<int>();
        }

        private void Boton_buscar_Click(object sender, EventArgs e)
        {
            List<int> indicesEncontrados = form1Ref.Buscar(textBox1.Text);
            if(indicesEncontrados.Count > 0)
            {
                searchIndices = indicesEncontrados;
                selected = 0;
                form1Ref.SelectSearchWorld(searchIndices[selected], textBox1.Text);
                f_button.Enabled = true;
                f_label.Text = "Se econtro " + searchIndices.Count.ToString() + " coincidencias";
            } else
            {
                f_label.Text = "No se econtro coincidencias";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void F_button_Click(object sender, EventArgs e)
        {
            selected++;
            if(selected >= searchIndices.Count-1)
            {
                form1Ref.SelectSearchWorld(searchIndices[selected], textBox1.Text);
                f_button.Enabled = false;
            } else
            {
                form1Ref.SelectSearchWorld(searchIndices[selected], textBox1.Text);
            }
        }
    }
}
