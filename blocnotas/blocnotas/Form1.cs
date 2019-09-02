using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace blocnotas
{
    public partial class Form1 : Form
    {
        private string fileName;
        private string filePath;
        private Boolean guardado;
        private Boolean editado;
        public Form1()
        {
            InitializeComponent();

            textBox.TextChanged += new System.EventHandler(this.ModificoTexto);
            fileName = "untitled.txt";
            guardado = false;
            editado = false;
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void AumentarFont(object sender, EventArgs e)
        {
            Font _font = textBox.Font;
            textBox.Font = new Font(_font.Name, _font.Size + 1, _font.Style, _font.Unit);
        }

        private void ReducirFont(object sender, EventArgs e)
        {
            Font _font = textBox.Font;
            textBox.Font = new Font(_font.Name, _font.Size - 1, _font.Style, _font.Unit);
        }

        private void ModificoTexto(object sender, EventArgs e)
        {
            this.Text = "* " + fileName;
            editado = true;
        }

        private void OpcionGuardar(object sender, EventArgs e)
        {
            if(guardado == false)
            {
                MenuGuardar(this, null);
            } else
            {
                File.WriteAllText(filePath, textBox.Text);
                this.Text = fileName;
                editado = false;
            }
        }

        public void MenuGuardar(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Archivos de text | *.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, textBox.Text);

                filePath = dlg.FileName;
                fileName = Path.GetFileNameWithoutExtension(filePath);

                this.Text = fileName;
                guardado = true;
                editado = false;
            }
        }

        private void MenuNuevo(object sender, EventArgs e)
        {
            DialogResult result;
            if (editado == true)
                result = MessageBox.Show("¿Deseas continuar sin guardar?",
                    "Atencion", MessageBoxButtons.YesNo);
            else
                result = DialogResult.Yes;

            if(result == DialogResult.Yes)
            {
                textBox.ResetText();

                guardado = false;
                editado = false;
                fileName = "untitled.txt";
            }
        }

        private void MenuAbrir(object sender, EventArgs e)
        {

            DialogResult result;
            if (editado == true)
                result = MessageBox.Show("¿Deseas continuar sin guardar?",
                    "Atencion", MessageBoxButtons.YesNo);
            else
                result = DialogResult.Yes;

            if (result == DialogResult.Yes)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Archivos de texto | *.txt";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = File.ReadAllText(dlg.FileName);
                    filePath = dlg.FileName;
                    fileName = dlg.SafeFileName;

                    this.Text = fileName;
                    guardado = true;
                    editado = false;
                    //System.Console.WriteLine(dlg.InitialDirectory);
                }
            }
        }

        private void Deshacer(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void Cortar(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void Copiar(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void Pegar(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void AbrirBuscar(object sender, EventArgs e)
        {
            f_siguiente form2 = new f_siguiente(this);
            form2.Show();
        }

        public List<int> Buscar(string txt)
        {
            int buscarRes = 0;
            List<int> indices = new List<int>();

            while (buscarRes != -1)
            {
                buscarRes = textBox.Find(txt, buscarRes, RichTextBoxFinds.MatchCase);

                if (buscarRes != -1)
                {
                    indices.Add(buscarRes);
                    //string texto = textBox.Text;
                    //textBox.SelectionStart = buscarRes;
                    //System.Console.WriteLine(buscarRes);
                    buscarRes++;
                }
            }

            return indices;
        }

        public void SelectSearchWorld(int i, string txt)
        {
            textBox.Find(txt, i, RichTextBoxFinds.MatchCase);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (editado == true)
                result = MessageBox.Show("¿Deseas continuar sin guardar?",
                    "Atencion", MessageBoxButtons.YesNo);
            else
                result = DialogResult.Yes;

            if (result == DialogResult.No)
                e.Cancel = true;
            
        }

        private void SeleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }
    }
}
