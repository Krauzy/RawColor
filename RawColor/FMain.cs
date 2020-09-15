using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawColor
{
    public partial class FMain : Form
    {
        private Image img;
        private Image bkp;
        private int tab;
        public FMain()
        {
            InitializeComponent();
            btSave.Visible = false;
            radioOFF.Checked = true;
            bkp = img;
            tab = 0;
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Abrir Imagem";
            open.Filter = "Arquivos de Imagem (*.jpg;*.bmp;*.png;*.gif)|*.jpg;*.bmp;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.img = Image.FromFile(open.FileName);
                    if (img.Width > 513 || img.Height > 426)
                    {
                        if (MessageBox.Show("Imagem muito grande. Deseja comprimir o tamanho dela? \n(comprimir a imagem fará com que as posições dos pixels não sejam exatas)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            picBox.Location = new Point(0, 0);
                            btSave.Location = new Point(471, 384);
                            picBox.Image = this.img;
                            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            btOpenFile.Visible = false;
                            picH.Image = Filtro.toGrayScaleWith_H((Bitmap)this.img);
                            picS.Image = Filtro.toGrayScaleWith_S((Bitmap)this.img);
                            picI.Image = Filtro.toGrayScaleWith_I((Bitmap)this.img);
                            picR.Image = Filtro.toColorScale_RED((Bitmap)this.img);
                            picG.Image = Filtro.toColorScale_GREEN((Bitmap)this.img);
                            picB.Image = Filtro.toColorScale_BLUE((Bitmap)this.img);
                        }
                    }
                    else
                    {
                        int xres = (513 - img.Width) / 2;
                        int yres = (426 - img.Height) / 2;
                        picBox.Location = new Point(xres, yres);
                        btSave.Location = new Point(xres + img.Width - 42, yres + img.Height - 42);
                        picBox.Image = this.img;
                        picBox.SizeMode = PictureBoxSizeMode.AutoSize;
                        btOpenFile.Visible = false;
                        picH.Image = Filtro.toGrayScaleWith_H((Bitmap)this.img);
                        picS.Image = Filtro.toGrayScaleWith_S((Bitmap)this.img);
                        picI.Image = Filtro.toGrayScaleWith_I((Bitmap)this.img);
                        picR.Image = Filtro.toColorScale_RED((Bitmap)this.img);
                        picG.Image = Filtro.toColorScale_GREEN((Bitmap)this.img);
                        picB.Image = Filtro.toColorScale_BLUE((Bitmap)this.img);
                    }
                    btSave.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar imagem!\n" + ex.Message, "Erro ao abrir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Color getColor(int x, int y)
        {
            Bitmap bit = (Bitmap)img;
            if (x < bit.Width && y < bit.Height)
                return bit.GetPixel(x, y);
            else
                return bit.GetPixel(bit.Width - 1, bit.Height - 1);
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (picBox.Image != null)
            {
                base.OnMouseMove(e);
                Point p = e.Location;
                Color c = this.getColor(p.X, p.Y);
                Converter conv = new Converter();
                conv.RGBtoHSI(c.R, c.G, c.B);
                conv.RGBtoCMY(c.R, c.G, c.B);
                ToolTip.SetToolTip(picBox, "R:" + c.R + " G:" + c.G + " B:" + c.B 
                    + "\nH:" + Math.Round(conv.H, 2) + " S:" + Math.Round(conv.S, 2) + " I:" + Math.Round(conv.I, 2)
                    + "\nC:" + conv.C + " M:" + conv.M + " Y:" + conv.Y);
            }
        }

        private void radioON_CheckedChanged(object sender, EventArgs e)
        {
            if(picBox.Image != null)
            {
                if(radioON.Checked)
                {
                    radioOFF.Checked = false;
                    picBox.Image = Filtro.Luminous((Bitmap)img);
                }
                else
                {
                    radioOFF.Checked = true;
                    picBox.Image = bkp;
                }
            }
            
        }

        private void barShine_Scroll(object sender, EventArgs e)
        {
            if(picBox.Image != null)
            {
                if (barShine.Value % 10 != 0)
                {
                    barShine.Value = ((int)barShine.Value / 10) * 10;
                }
                if (barShine.Value != 0)
                    picBox.Image = Filtro.shine((Bitmap)img, barShine.Value / 10);
                else
                    picBox.Image = img;
            }
        }

        private void barHUE_Scroll(object sender, EventArgs e)
        {
            if(picBox.Image != null)
            {
                if (barHUE.Value % 10 != 0)
                {
                    barHUE.Value = ((int)barHUE.Value / 10) * 10;
                }
                picBox.Image = Filtro.HUE((Bitmap)img, barHUE.Value);
            }   
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            bkp = img;
            img = picBox.Image;
        }
    }
}