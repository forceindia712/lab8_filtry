using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Grafika
{
    public partial class Form1 : Form
    {
        private int szer = 0, wys = 0;
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
            bitmap = (Bitmap)this.pictureBox1.Image;

            wys = pictureBox1.Image.Height;
            szer = pictureBox1.Image.Width;
        }

        //Robertsa I
        private void button2_Click(object sender, EventArgs e)
        {
            {
                Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
                Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

                double R1 = 0, G1 = 0, B1 = 0;

                int[,] macierz = new int[,] { { 0, 0, 0 }, { 0, 1, -1 }, { 0, 0, 0 } };


                for (int i = 1; i < wys - 1; i++)
                {
                    for (int j = 1; j < szer - 1; j++)
                    {

                        R1 = 0; G1 = 0; B1 = 0;

                        for (int k = -1; k <= 1; k++)
                        {
                            for (int l = -1; l <= 1; l++)
                            {
                                Color p = bitmapCopy.GetPixel(j + k, i + l);

                                int r = (int)p.R;
                                int g = (int)p.G;
                                int b = (int)p.B;

                                R1 += r * macierz[k + 1, l + 1];
                                G1 += g * macierz[k + 1, l + 1];
                                B1 += b * macierz[k + 1, l + 1];

                            }
                        }

                        R1 = Math.Abs(R1);
                        G1 = Math.Abs(G1);
                        B1 = Math.Abs(B1);


                        if (R1 < 0 || R1 > 255) R1 = 0;
                        if (G1 < 0 || G1 > 255) G1 = 0;
                        if (B1 < 0 || B1 > 255) B1 = 0;


                        bitmapEdited.SetPixel(j, i, Color.FromArgb((int)R1, (int)G1, (int)B1));
                    }
                }

                pictureBox2.Image = bitmapEdited;
            }
        }

        //Prewitta I
        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

            double R1 = 0, G1 = 0, B1 = 0;

            int[,] macierz = new int[,] { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };


            for (int i = 1; i < wys - 1; i++)
            {
                for (int j = 1; j < szer - 1; j++)
                {

                    R1 = 0; G1 = 0; B1 = 0;

                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            Color p = bitmapCopy.GetPixel(j + k, i + l);

                            int r = (int)p.R;
                            int g = (int)p.G;
                            int b = (int)p.B;

                            R1 += r * macierz[k + 1, l + 1];
                            G1 += g * macierz[k + 1, l + 1];
                            B1 += b * macierz[k + 1, l + 1];

                        }
                    }

                    R1 = Math.Abs(R1);
                    G1 = Math.Abs(G1);
                    B1 = Math.Abs(B1);


                    if (R1 < 0 || R1 > 255) R1 = 0;
                    if (G1 < 0 || G1 > 255) G1 = 0;
                    if (B1 < 0 || B1 > 255) B1 = 0;


                    bitmapEdited.SetPixel(j, i, Color.FromArgb((int)R1, (int)G1, (int)B1));
                }
            }

            pictureBox2.Image = bitmapEdited;
        }

        //Robertsa II
        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

            double R1 = 0, G1 = 0, B1 = 0;

            int[,] macierz = new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, -1, 0 } };


            for (int i = 1; i < wys - 1; i++)
            {
                for (int j = 1; j < szer - 1; j++)
                {

                    R1 = 0; G1 = 0; B1 = 0;

                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            Color p = bitmapCopy.GetPixel(j + k, i + l);

                            int r = (int)p.R;
                            int g = (int)p.G;
                            int b = (int)p.B;

                            R1 += r * macierz[k + 1, l + 1];
                            G1 += g * macierz[k + 1, l + 1];
                            B1 += b * macierz[k + 1, l + 1];

                        }
                    }

                    R1 = Math.Abs(R1);
                    G1 = Math.Abs(G1);
                    B1 = Math.Abs(B1);


                    if (R1 < 0 || R1 > 255) R1 = 0;
                    if (G1 < 0 || G1 > 255) G1 = 0;
                    if (B1 < 0 || B1 > 255) B1 = 0;


                    bitmapEdited.SetPixel(j, i, Color.FromArgb((int)R1, (int)G1, (int)B1));
                }
            }

            pictureBox2.Image = bitmapEdited;
        }

        //Prewitta II
        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

            double R1 = 0, G1 = 0, B1 = 0;

            int[,] macierz = new int[,] { { 1, 0, -1 }, { 1, 0, -1 }, { 1, 0, -1 } };


            for (int i = 1; i < wys - 1; i++)
            {
                for (int j = 1; j < szer - 1; j++)
                {

                    R1 = 0; G1 = 0; B1 = 0;

                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            Color p = bitmapCopy.GetPixel(j + k, i + l);

                            int r = (int)p.R;
                            int g = (int)p.G;
                            int b = (int)p.B;

                            R1 += r * macierz[k + 1, l + 1];
                            G1 += g * macierz[k + 1, l + 1];
                            B1 += b * macierz[k + 1, l + 1];

                        }
                    }

                    R1 = Math.Abs(R1);
                    G1 = Math.Abs(G1);
                    B1 = Math.Abs(B1);


                    if (R1 < 0 || R1 > 255) R1 = 0;
                    if (G1 < 0 || G1 > 255) G1 = 0;
                    if (B1 < 0 || B1 > 255) B1 = 0;


                    bitmapEdited.SetPixel(j, i, Color.FromArgb((int)R1, (int)G1, (int)B1));
                }
            }

            pictureBox2.Image = bitmapEdited;
        }

        //Sobela I
        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

            double R1 = 0, G1 = 0, B1 = 0;

            int[,] macierz = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };

            for (int i = 1; i < wys - 1; i++)
            {
                for (int j = 1; j < szer - 1; j++)
                {

                    R1 = 0; G1 = 0; B1 = 0;

                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            Color p = bitmapCopy.GetPixel(j + k, i + l);

                            int r = (int)p.R;
                            int g = (int)p.G;
                            int b = (int)p.B;

                            R1 += r * macierz[k + 1, l + 1];
                            G1 += g * macierz[k + 1, l + 1];
                            B1 += b * macierz[k + 1, l + 1];

                        }
                    }

                    R1 = Math.Abs(R1);
                    G1 = Math.Abs(G1);
                    B1 = Math.Abs(B1);


                    if (R1 < 0 || R1 > 255) R1 = 0;
                    if (G1 < 0 || G1 > 255) G1 = 0;
                    if (B1 < 0 || B1 > 255) B1 = 0;


                    bitmapEdited.SetPixel(j, i, Color.FromArgb((int)R1, (int)G1, (int)B1));
                }
            }

            pictureBox2.Image = bitmapEdited;
        }

        //Sobela II
        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

            double R1 = 0, G1 = 0, B1 = 0;

            int[,] macierz = new int[,] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };


            for (int i = 1; i < wys - 1; i++)
            {
                for (int j = 1; j < szer - 1; j++)
                {

                    R1 = 0; G1 = 0; B1 = 0;

                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            Color p = bitmapCopy.GetPixel(j + k, i + l);

                            int r = (int)p.R;
                            int g = (int)p.G;
                            int b = (int)p.B;

                            R1 += r * macierz[k + 1, l + 1];
                            G1 += g * macierz[k + 1, l + 1];
                            B1 += b * macierz[k + 1, l + 1];

                        }
                    }

                    R1 = Math.Abs(R1);
                    G1 = Math.Abs(G1);
                    B1 = Math.Abs(B1);


                    if (R1 < 0 || R1 > 255) R1 = 0;
                    if (G1 < 0 || G1 > 255) G1 = 0;
                    if (B1 < 0 || B1 > 255) B1 = 0;


                    bitmapEdited.SetPixel(j, i, Color.FromArgb((int)R1, (int)G1, (int)B1));
                }
            }

            pictureBox2.Image = bitmapEdited;
        }

        //Laplas
        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

            double R1 = 0, G1 = 0, B1 = 0;

            int[,] macierz = new int[,] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };


            for (int i = 1; i < wys - 1; i++)
            {
                for (int j = 1; j < szer - 1; j++)
                {

                    R1 = 0; G1 = 0; B1 = 0;

                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            Color p = bitmapCopy.GetPixel(j + k, i + l);

                            int r = (int)p.R;
                            int g = (int)p.G;
                            int b = (int)p.B;

                            R1 += r * macierz[k + 1, l + 1];
                            G1 += g * macierz[k + 1, l + 1];
                            B1 += b * macierz[k + 1, l + 1];

                        }
                    }

                    R1 = Math.Abs(R1);
                    G1 = Math.Abs(G1);
                    B1 = Math.Abs(B1);


                    if (R1 < 0 || R1 > 255) R1 = 0;
                    if (G1 < 0 || G1 > 255) G1 = 0;
                    if (B1 < 0 || B1 > 255) B1 = 0;


                    bitmapEdited.SetPixel(j, i, Color.FromArgb((int)R1, (int)G1, (int)B1));
                }
            }

            pictureBox2.Image = bitmapEdited;
        }

        //Min
        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

            for (int x = 0; x < szer - 1; ++x)
            {
                int x0 = Math.Max(0, x - (int)numericUpDown1.Value);
                int x1 = Math.Min(szer - 1, x + (int)numericUpDown1.Value);

                for (int y = 0; y < wys - 1; ++y)
                {
                    int y0 = Math.Max(0, y - (int)numericUpDown1.Value);
                    int y1 = Math.Min(wys - 1, y + (int)numericUpDown1.Value);

                    Color P = bitmap.GetPixel(x, y);

                    for (int u = x0; u < x1; ++u)
                    {
                        for (int v = y0; v < y1; ++v)
                        {
                            if (bitmap.GetPixel(u, v).R > P.R & bitmap.GetPixel(u, v).G > P.G & bitmap.GetPixel(u, v).B > P.B)
                            {
                                P = bitmap.GetPixel(u, v);
                            }
                        }
                    }

                    bitmapCopy.SetPixel(x, y, P);
                }
            }
            pictureBox2.Image = bitmapCopy;
        }

        //Max
        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();


            for (int x = 0; x < szer - 1; ++x)
            {
                int x0 = Math.Max(0, x - (int)numericUpDown1.Value);
                int x1 = Math.Min(szer - 1, x + (int)numericUpDown1.Value);

                for (int y = 0; y < wys - 1; ++y)
                {
                    int y0 = Math.Max(0, y - (int)numericUpDown1.Value);
                    int y1 = Math.Min(wys - 1, y + (int)numericUpDown1.Value);

                    Color P = bitmap.GetPixel(x, y);

                    for (int u = x0; u < x1; ++u)
                    {
                        for (int v = y0; v < y1; ++v)
                        {
                            if (bitmap.GetPixel(u, v).R < P.R & bitmap.GetPixel(u, v).G < P.G & bitmap.GetPixel(u, v).B < P.B)
                            {
                                P = bitmap.GetPixel(u, v);
                            }
                        }
                    }

                    bitmapCopy.SetPixel(x, y, P);
                }
            }
            pictureBox2.Image = bitmapCopy;
        }

        //Median
        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();
            for (int y = 1; y < wys - 1; y++)
            {
                for (int x = 1; x < szer - 1; x++)
                {
                    Point[] arrayP = new Point[] {  new Point(x - 1, y - 1), new Point(x - 0, y - 1),
                                                    new Point(x + 1, y - 1), new Point(x - 1, y - 0),
                                                    new Point(x - 0, y - 0), new Point(x + 1, y - 0),
                                                    new Point(x - 1, y + 1), new Point(x - 0, y + 1),
                                                    new Point(x + 1, y + 1)};

                    int A = 0, R = 0, G = 0, B = 0;
                    foreach (Point item in arrayP)
                    {
                        A += bitmapCopy.GetPixel(item.X, item.Y).A/9;
                        R += bitmapCopy.GetPixel(item.X, item.Y).R/9;
                        G += bitmapCopy.GetPixel(item.X, item.Y).G/9;
                        B += bitmapCopy.GetPixel(item.X, item.Y).B/9;
                    }
                    int sredniaARGB = 0x01000000 * A + 0x00010000 * R + 0x00000100 * G + 0x00000001 * B;

                    bitmapCopy.SetPixel(x, y, Color.FromArgb(sredniaARGB));
                }
            }
            pictureBox2.Image = bitmapCopy;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Wczytaj
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                bitmap = (Bitmap)this.pictureBox1.Image;

                wys = pictureBox1.Image.Height;
                szer = pictureBox1.Image.Width;
            }
        }
    }
}
