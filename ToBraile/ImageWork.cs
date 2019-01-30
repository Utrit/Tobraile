using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// compile with: /unsafe
namespace ToBraile
{
    public class ImageWork
    {
        public Bitmap MakeBW(Bitmap imageinput)
        {
            for (int i = 0; i < imageinput.Height; i++)
                for (int j = 0; j < imageinput.Width; j++)
                {
                    imageinput.SetPixel(j, i, GetMiddleColor(imageinput.GetPixel(j, i)));
                }
            return imageinput;
        }
        public Bitmap MakeNegative(Bitmap imageinput)
        {
            for (int i = 0; i < imageinput.Height; i++)
                for (int j = 0; j < imageinput.Width; j++) {
                    imageinput.SetPixel(j, i, ReversRgb(imageinput.GetPixel(j, i)));
                }
            return imageinput;
        }
        private Color ReversRgb(Color colorinput)
        {
            return Color.FromArgb(255 - colorinput.R, 255 - colorinput.G, 255 - colorinput.B);
        }
        private Color GetMiddleColor(Color colorinput)
        {
            int channel = (colorinput.R + colorinput.G + colorinput.B) / 3;
            return Color.FromArgb(channel, channel, channel);
        }
        private void seterror(int brig, int x, int y, Bitmap image){
            if ((x > image.Width-1) || (y > image.Height - 1) || (x < 0) || (y < 0)) return;          
            int dbrig = brig+image.GetPixel(x, y).R;
            if (dbrig > 255) dbrig = 255;
            if (dbrig < 0) dbrig = 0;
            image.SetPixel(x, y, Color.FromArgb(dbrig, dbrig, dbrig));
        }
        public Bitmap dithering(Bitmap imageinput)
        {
            for (int i = 0; i < imageinput.Height; i++)
                for (int j = 0; j < imageinput.Width; j++)
                {
                    int brig = imageinput.GetPixel(j, i).R;
                    if (brig > 128)
                    {
                        imageinput.SetPixel(j, i, Color.White);
                        brig = brig-256;
                    }
                    else imageinput.SetPixel(j, i, Color.Black);
                    seterror(brig/16*7, j + 1, i, imageinput);
                    seterror(brig/16, j+1, i+1, imageinput);
                    seterror(brig/16*5, j, i+1, imageinput);
                    seterror(brig/16*3, j-1, i+1, imageinput);
                    
                }
            return imageinput;
        }
        public Bitmap resizeImage(Bitmap imgToResize, Size size)
        {
            return (new Bitmap(imgToResize, size));
        }
        public Bitmap cropImage(Bitmap imgToCrop, Rectangle size)
        {
            Bitmap nb = imgToCrop.Clone(size,System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            return nb;
        }

    }
}
