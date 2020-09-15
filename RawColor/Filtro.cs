using System.Drawing;
using System.Drawing.Imaging;

namespace RawColor
{
    class Filtro
    {
        public static Bitmap Luminous(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap btmIn = new Bitmap(img);
            Bitmap btmOut = new Bitmap(img);

            BitmapData btmDataIn = btmIn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData btmDataOut = btmOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In;
                byte* Out;
                int stride = btmDataIn.Stride;

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    byte* lin_in = (byte*)btmDataIn.Scan0.ToPointer() + y * stride;
                    byte* lin_out = (byte*)btmDataOut.Scan0.ToPointer() + y * stride;

                    for (int x = 0; x < width; x++)
                    {
                        In = lin_in + x * 3;
                        b = *(In++);
                        g = *(In++);
                        r = *(In++);
                        //
                        double grey = ((0.299) * r + (0.587) * g + (0.114) * b);
                        //
                        Out = lin_out + x * 3;
                        *(Out++) = (byte)grey;
                        *(Out++) = (byte)grey;
                        *(Out++) = (byte)grey;
                    }
                }
                btmIn.UnlockBits(btmDataIn);
                btmOut.UnlockBits(btmDataOut);

                return btmOut;
            }
        }

        public static Bitmap toGrayScaleWith_H(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap btmIn = new Bitmap(img);
            Bitmap btmOut = new Bitmap(img);

            BitmapData btmDataIn = btmIn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData btmDataOut = btmOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In;
                byte* Out;
                int stride = btmDataIn.Stride;

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    byte* lin_in = (byte*)btmDataIn.Scan0.ToPointer() + y * stride;
                    byte* lin_out = (byte*)btmDataOut.Scan0.ToPointer() + y * stride;

                    for (int x = 0; x < width; x++)
                    {
                        In = lin_in + x * 3;
                        b = *(In++);
                        g = *(In++);
                        r = *(In++);
                        Converter con = new Converter();
                        con.RGBtoHSI(r, g, b);
                        int scale = (int)(con.H * 255) / 360;
                        Out = lin_out + x * 3;
                        *(Out++) = (byte)scale;
                        *(Out++) = (byte)scale;
                        *(Out++) = (byte)scale;
                    }
                }
                btmIn.UnlockBits(btmDataIn);
                btmOut.UnlockBits(btmDataOut);

                return btmOut;
            }
        }

        public static Bitmap toGrayScaleWith_S(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap btmIn = new Bitmap(img);
            Bitmap btmOut = new Bitmap(img);

            BitmapData btmDataIn = btmIn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData btmDataOut = btmOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In;
                byte* Out;
                int stride = btmDataIn.Stride;

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    byte* lin_in = (byte*)btmDataIn.Scan0.ToPointer() + y * stride;
                    byte* lin_out = (byte*)btmDataOut.Scan0.ToPointer() + y * stride;

                    for (int x = 0; x < width; x++)
                    {
                        In = lin_in + x * 3;
                        b = *(In++);
                        g = *(In++);
                        r = *(In++);
                        Converter con = new Converter();
                        con.RGBtoHSI(r, g, b);
                        int scale = (int)(con.S * 255) / 100;
                        Out = lin_out + x * 3;
                        *(Out++) = (byte)scale;
                        *(Out++) = (byte)scale;
                        *(Out++) = (byte)scale;
                    }
                }
                btmIn.UnlockBits(btmDataIn);
                btmOut.UnlockBits(btmDataOut);

                return btmOut;
            }
        }

        public static Bitmap toGrayScaleWith_I(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap btmIn = new Bitmap(img);
            Bitmap btmOut = new Bitmap(img);

            BitmapData btmDataIn = btmIn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData btmDataOut = btmOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In;
                byte* Out;
                int stride = btmDataIn.Stride;

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    byte* lin_in = (byte*)btmDataIn.Scan0.ToPointer() + y * stride;
                    byte* lin_out = (byte*)btmDataOut.Scan0.ToPointer() + y * stride;

                    for (int x = 0; x < width; x++)
                    {
                        In = lin_in + x * 3;
                        b = *(In++);
                        g = *(In++);
                        r = *(In++);
                        Converter con = new Converter();
                        con.RGBtoHSI(r, g, b);
                        int scale = (int)con.I;
                        Out = lin_out + x * 3;
                        *(Out++) = (byte)scale;
                        *(Out++) = (byte)scale;
                        *(Out++) = (byte)scale;
                    }
                }
                btmIn.UnlockBits(btmDataIn);
                btmOut.UnlockBits(btmDataOut);

                return btmOut;
            }
        }

        public static Bitmap toColorScale_RED(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap btmIn = new Bitmap(img);
            Bitmap btmOut = new Bitmap(img);

            BitmapData btmDataIn = btmIn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData btmDataOut = btmOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In;
                byte* Out;
                int stride = btmDataIn.Stride;

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    byte* lin_in = (byte*)btmDataIn.Scan0.ToPointer() + y * stride;
                    byte* lin_out = (byte*)btmDataOut.Scan0.ToPointer() + y * stride;

                    for (int x = 0; x < width; x++)
                    {
                        In = lin_in + x * 3;
                        b = *(In++);
                        g = *(In++);
                        r = *(In++);
                        Out = lin_out + x * 3;
                        *(Out++) = (byte)0;
                        *(Out++) = (byte)0;
                        *(Out++) = (byte)r;
                    }
                }
                btmIn.UnlockBits(btmDataIn);
                btmOut.UnlockBits(btmDataOut);

                return btmOut;
            }
        }

        public static Bitmap toColorScale_BLUE(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap btmIn = new Bitmap(img);
            Bitmap btmOut = new Bitmap(img);

            BitmapData btmDataIn = btmIn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData btmDataOut = btmOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In;
                byte* Out;
                int stride = btmDataIn.Stride;

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    byte* lin_in = (byte*)btmDataIn.Scan0.ToPointer() + y * stride;
                    byte* lin_out = (byte*)btmDataOut.Scan0.ToPointer() + y * stride;

                    for (int x = 0; x < width; x++)
                    {
                        In = lin_in + x * 3;
                        b = *(In++);
                        g = *(In++);
                        r = *(In++);
                        Out = lin_out + x * 3;
                        *(Out++) = (byte)b;
                        *(Out++) = (byte)0;
                        *(Out++) = (byte)0;
                    }
                }
                btmIn.UnlockBits(btmDataIn);
                btmOut.UnlockBits(btmDataOut);

                return btmOut;
            }
        }

        public static Bitmap toColorScale_GREEN(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap btmIn = new Bitmap(img);
            Bitmap btmOut = new Bitmap(img);

            BitmapData btmDataIn = btmIn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData btmDataOut = btmOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In;
                byte* Out;
                int stride = btmDataIn.Stride;

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    byte* lin_in = (byte*)btmDataIn.Scan0.ToPointer() + y * stride;
                    byte* lin_out = (byte*)btmDataOut.Scan0.ToPointer() + y * stride;

                    for (int x = 0; x < width; x++)
                    {
                        In = lin_in + x * 3;
                        b = *(In++);
                        g = *(In++);
                        r = *(In++);
                        Out = lin_out + x * 3;
                        *(Out++) = (byte)0;
                        *(Out++) = (byte)g;
                        *(Out++) = (byte)0;
                    }
                }
                btmIn.UnlockBits(btmDataIn);
                btmOut.UnlockBits(btmDataOut);

                return btmOut;
            }
        }

        public static Bitmap shine(Bitmap img, double porcetagem)
        {
            porcetagem = (porcetagem == 0) ? 1 : porcetagem;
            int width = img.Width;
            int height = img.Height;
            Bitmap btmIn = new Bitmap(img);
            Bitmap btmOut = new Bitmap(img);

            BitmapData btmDataIn = btmIn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData btmDataOut = btmOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In;
                byte* Out;
                int stride = btmDataIn.Stride;

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    byte* lin_in = (byte*)btmDataIn.Scan0.ToPointer() + y * stride;
                    byte* lin_out = (byte*)btmDataOut.Scan0.ToPointer() + y * stride;

                    for (int x = 0; x < width; x++)
                    {
                        In = lin_in + x * 3;
                        b = *(In++);
                        g = *(In++);
                        r = *(In++);
                        Converter conv = new Converter();
                        conv.RGBtoHSI(r, g, b);
                        double H = conv.H;
                        double S = conv.S;
                        double I = conv.I;
                        I /= 255;
                        I += I * porcetagem;
                        I *= 255;
                        I = (I > 255) ? 255 : I;
                        Color cor = conv.HSItoRGB(H, S, I);
                        Out = lin_out + x * 3;
                        *(Out++) = (byte)cor.B;
                        *(Out++) = (byte)cor.G;
                        *(Out++) = (byte)cor.R;
                    }
                }
                btmIn.UnlockBits(btmDataIn);
                btmOut.UnlockBits(btmDataOut);

                return btmOut;
            }
        }

        public static Bitmap HUE(Bitmap img, int angle)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap btmIn = new Bitmap(img);
            Bitmap btmOut = new Bitmap(img);

            BitmapData btmDataIn = btmIn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData btmDataOut = btmOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In;
                byte* Out;
                int stride = btmDataIn.Stride;

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    byte* lin_in = (byte*)btmDataIn.Scan0.ToPointer() + y * stride;
                    byte* lin_out = (byte*)btmDataOut.Scan0.ToPointer() + y * stride;

                    for (int x = 0; x < width; x++)
                    {
                        In = lin_in + x * 3;
                        b = *(In++);
                        g = *(In++);
                        r = *(In++);
                        Converter conv = new Converter();
                        conv.RGBtoHSI(r, g, b);
                        double H = conv.H;
                        double S = conv.S;
                        double I = conv.I;
                        H -= angle;
                        H = (H < 0) ? 0 : H;
                        Color cor = conv.HSItoRGB(H, S, I);
                        Out = lin_out + x * 3;
                        *(Out++) = (byte)cor.B;
                        *(Out++) = (byte)cor.G;
                        *(Out++) = (byte)cor.R;
                    }
                }
                btmIn.UnlockBits(btmDataIn);
                btmOut.UnlockBits(btmDataOut);

                return btmOut;
            }
        }
    }
}
