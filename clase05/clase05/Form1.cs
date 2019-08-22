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

namespace clase05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Archivos de texto | *.txt";
            if(dlg.ShowDialog() == DialogResult.OK)
                File.WriteAllText(dlg.FileName, textBox1.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Archivos de texto | *.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
                textBox1.Text = File.ReadAllText(dlg.FileName);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
