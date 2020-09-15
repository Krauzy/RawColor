using System;
using System.Drawing;
using System.Windows.Forms;

namespace RawColor
{
    class Converter
    {
        private double h;
        private double s;
        private double i;
        private int c;
        private int m;
        private int y;

        public double H { get => h; set => h = value; }
        public double S { get => s; set => s = value; }
        public double I { get => i; set => i = value; }
        public int C { get => c; set => c = value; }
        public int M { get => m; set => m = value; }
        public int Y { get => y; set => y = value; }

        public Converter()
        {

        }

        public void RGBtoHSI(int R, int G, int B)
        {
            double normal_r;
            double normal_g;
            double normal_b;
            if (R == 0 && G == 0 && B == 0)
            {
                normal_r = 0;
                normal_g = 0;
                normal_b = 0;
            }
            else
            {
                normal_r = (double)R / (R + G + B);
                normal_g = (double)G / (R + G + B);
                normal_b = (double)B / (R + G + B);
            }
            double rg = normal_r - normal_g;
            double rb = normal_r - normal_b;
            double gb = normal_g - normal_b;
            // H
            try
            {
                double num = (double)0.5 * (rg + rb);
                double dem = Math.Sqrt(Math.Pow(rg, 2) + (rb * gb));
                //MessageBox.Show("" + dem);
                if (dem == 0)
                    this.H = Math.Acos(1);
                else
                {
                    this.H = Math.Acos(num / dem);
                    if (normal_b > normal_g)
                        this.H = (2 * Math.PI) - H;
                }

                // S
                double min = Math.Min(normal_r, Math.Min(normal_g, normal_b));
                if (min == 0)
                    this.S = 0;
                else
                    this.S = 1 - (3 * min);

                // I
                this.I = (double)(R + G + B) / (3 * 255);


                this.H = (this.H * 180) / Math.PI;
                this.S *= 100;
                this.I *= 255;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public Color HSItoRGB(double H, double S, double I)
        {
            H = (double) (H * Math.PI) / 180;
            S = (double) S / 100;
            I = (double) I / 255;
            try
            {
                double x = 0;
                double y = 0;
                double z = 0;
                int R = 0;
                int G = 0;
                int B = 0;

                if (H < (2 * Math.PI) / 3)
                {
                    x = (I * (1 - S));
                    y = I * (double)(1 + ((double)(S * Math.Cos(H)) / (double)(Math.Cos((double)((double)Math.PI / 3) - H))));
                    z = (double)(3 * I) - (double)(x + y);
                    B = Convert.ToInt32(x * 255);
                    R = Convert.ToInt32(y * 255);
                    G = Convert.ToInt32(z * 255);
                }
                else if (H >= (double)(2 * Math.PI) / 3 && H < (double)(4 * Math.PI) / 3)
                {
                    H = (double)H - (double)(2 * Math.PI) / 3;

                    x = (I * (1 - S));
                    y = I * (double)(1 + ((double)(S * Math.Cos(H)) / (double)(Math.Cos((double)((double)Math.PI / 3) - H))));
                    z = (double)(3 * I) - (double)(x + y);
                    B = Convert.ToInt32(z * 255);
                    R = Convert.ToInt32(x * 255);
                    G = Convert.ToInt32(y * 255);
                }
                else if (H >= (4 * Math.PI) / 3 && H < 2 * Math.PI)
                {
                    H = (double)H - (double)(4 * Math.PI) / 3;

                    x = (I * (1 - S));
                    y = I * (double)(1 + ((double)(S * Math.Cos(H)) / (double)(Math.Cos((double)((double)Math.PI / 3) - H))));
                    z = (double)(3 * I) - (double)(x + y);
                    B = Convert.ToInt32(y * 255);
                    R = Convert.ToInt32(z * 255);
                    G = Convert.ToInt32(x * 255);
                }
                R = (R > 255) ? 255 : R;
                G = (G > 255) ? 255 : G;
                B = (B > 255) ? 255 : B;
                
                R = (R < 0) ? 0 : R;
                G = (G < 0) ? 0 : G;
                B = (B < 0) ? 0 : B;
                return Color.FromArgb(R, G, B);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return Color.FromArgb(0, 0, 0);
            }
        }

        public void RGBtoCMY(int R, int G, int B)
        {
            this.C = 1 - R;
            this.M = 1 - G;
            this.Y = 1 - B;
        }

        public Color CMYtoRGB(int C, int M, int Y)
        {
            int R = 1 - this.C;
            int G = 1 - this.M;
            int B = 1 - this.Y;
            return Color.FromArgb(R, G, B);
        }
    }
}
