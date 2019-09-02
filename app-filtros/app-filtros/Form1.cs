using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_filtros
{
    public partial class Form1 : Form
    {
        private Bitmap image;
        private Bitmap image_original;
        public Form1()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void B_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //dlg.Filter = "Imagenes";
            if (dlg.ShowDialog() == DialogResult.OK) {
                Image img = Image.FromFile(dlg.FileName);
                image = ResizeImage(img, 300, 300);
                image_original = (Bitmap)image.Clone();
                this.Invalidate();

                // Activa botones
                b_reset.Enabled = true;
                b_qrojo.Enabled = true;
                b_qverde.Enabled = true;
                b_qazul.Enabled = true;
                b_trojo.Enabled = true;
                b_tverde.Enabled = true;
                b_tazul.Enabled = true;
                b_grises.Enabled = true;
                b_blancoNegro.Enabled = true;
                b_negativo.Enabled = true;
                b_sepia.Enabled = true;

                listBox1.Items.Clear();
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void B_reset_Click(object sender, EventArgs e)
        {
            if(image != null)
            {
                image = (Bitmap)image_original.Clone();
                listBox1.Items.Clear();
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           if(image != null)
            {
                e.Graphics.DrawImage(image, 50, 80);
            }
        }

        private void B_qrojo_Click(object sender, EventArgs e)
        {
            if(image != null)
            {
                Color c;
                Color cn;
                for(int y = 0; y < image.Height; y++)
                {
                    for(int x = 0; x < image.Width; x++)
                    {
                        c = image.GetPixel(x, y);
                        cn = Color.FromArgb(0, c.G, c.B);

                        image.SetPixel(x, y, cn);
                    }
                }

                listBox1.Items.Add("Quitar Rojo.");
                this.Invalidate();
            }
        }

        private void B_qverde_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Color c;
                Color cn;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        c = image.GetPixel(x, y);
                        cn = Color.FromArgb(c.R, 0, c.B);

                        image.SetPixel(x, y, cn);
                    }
                }

                listBox1.Items.Add("Quitar Verde.");
                this.Invalidate();
            }
        }

        private void B_qazul_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Color c;
                Color cn;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        c = image.GetPixel(x, y);
                        cn = Color.FromArgb(c.R, c.G, 0);

                        image.SetPixel(x, y, cn);
                    }
                }

                listBox1.Items.Add("Quitar Azul.");
                this.Invalidate();
            }
        }

        private void B_trojo_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Color c;
                Color cn;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        c = image.GetPixel(x, y);
                        cn = Color.FromArgb(255, c.G, c.B);

                        image.SetPixel(x, y, cn);
                    }
                }

                listBox1.Items.Add("Todo Rojo.");
                this.Invalidate();
            }
        }

        private void B_tverde_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Color c;
                Color cn;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        c = image.GetPixel(x, y);
                        cn = Color.FromArgb(c.R, 255, c.B);

                        image.SetPixel(x, y, cn);
                    }
                }

                listBox1.Items.Add("Todo Verde.");
                this.Invalidate();
            }
        }

        private void B_tazul_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Color c;
                Color cn;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        c = image.GetPixel(x, y);
                        cn = Color.FromArgb(c.R, c.G, 255);

                        image.SetPixel(x, y, cn);
                    }
                }

                listBox1.Items.Add("Todo Azul.");
                this.Invalidate();
            }
        }

        private void B_grises_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Color c;
                Color cn;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        c = image.GetPixel(x, y);
                        float promedio = (c.R + c.G + c.B) / 3;
                        cn = Color.FromArgb((int)promedio, (int)promedio, (int)promedio);

                        image.SetPixel(x, y, cn);
                    }
                }

                listBox1.Items.Add("Escala de grises.");
                this.Invalidate();
            }
        }

        private void B_blancoNegro_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Color c;
                Color cn;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        c = image.GetPixel(x, y);
                        float promedio = (c.R + c.G + c.B) / 3;
                        int actual = 255;
                        if (promedio < 127)
                            actual = 0;
                        cn = Color.FromArgb(actual, actual, actual);

                        image.SetPixel(x, y, cn);
                    }
                }

                listBox1.Items.Add("Blanco y negro.");
                this.Invalidate();
            }
        }

        private void B_negativo_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Color c;
                Color cn;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        c = image.GetPixel(x, y);
                        cn = Color.FromArgb(255-c.R, 255-c.G, 255-c.B);

                        image.SetPixel(x, y, cn);
                    }
                }

                listBox1.Items.Add("Negativo");
                this.Invalidate();
            }
        }

        private void B_sepia_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Color c;
                Color cn;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        c = image.GetPixel(x, y);

                        int tr = (int)(0.393f * c.R + 0.769f * c.G + 0.189f * c.B);
                        int tg = (int)(0.393f * c.R + 0.686f * c.G + 0.189f * c.B);
                        int tb = (int)(0.272f * c.R + 0.534f * c.G + 0.131 * c.B);

                        int r; int g; int b;

                        if (tr > 255)
                            r = 255;
                        else
                            r = tr;

                        if (tg > 255)
                            g = 255;
                        else
                            g = tg;

                        if (tb > 255)
                            b = 255;
                        else
                            b = tb;



                        cn = Color.FromArgb(r, g, b);

                        image.SetPixel(x, y, cn);
                    }
                }

                listBox1.Items.Add("Sepia.");
                this.Invalidate();
            }
        }
    }
}
