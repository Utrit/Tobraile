using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToBraile
{
    public partial class ToBraile : Form
    {
        ImageWork workwithimage = new ImageWork();
        Bitmap gimage = null;
        const string version = "v0.1.1";
        public ToBraile()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(DargNDropPicBox_DragEnter);
            this.DragDrop += new DragEventHandler(DargNDropPicBox_DragDrop);
            label1.Text = "Made by Utrit " + version;
        }

        private void DargNDropPicBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;

        }

        private void DargNDropPicBox_DragDrop(object sender, DragEventArgs e)
        {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string path = files[0];
                string format = path.Substring(path.LastIndexOf('.')+1, 3);

            if (format == "png" || format == "jpg" || format == "bmp") gimage = (Bitmap)Bitmap.FromFile(path);
                DargNDropPicBox.Image = gimage;
        }
        private void inputw_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (int.Parse(inputw.Text) < 1) inputw.Text = "1";
                if (int.Parse(inputw.Text) > 256) inputw.Text = "256";
            }
            catch { inputw.Text = "1"; }
        }
        private void inputh_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (int.Parse(inputh.Text) < 1) inputh.Text = "1";
                if (int.Parse(inputh.Text) > 256) inputh.Text = "256";
            }
            catch { inputh.Text = "1"; }
        }
        private char getbraile(int x, int y, Bitmap image)
        {
            int size = 10240;
            try
            {
                
                if (image.GetPixel(x, y).R > 0) size += 1;
                if (image.GetPixel(x, y + 1).R > 0) size += 2;
                if (image.GetPixel(x, y + 2).R > 0) size += 4;
                if (image.GetPixel(x + 1, y).R > 0) size += 8;
                if (image.GetPixel(x + 1, y + 1).R > 0) size += 16;
                if (image.GetPixel(x + 1, y + 2).R > 0) size += 32;
                if (image.GetPixel(x, y + 3).R > 0) size += 64;
                if (image.GetPixel(x + 1, y + 3).R > 0) size += 128;
                return (char)size;
            }
            catch
            {
                return (char)size;
            }

        }
        private string GenerateBraile(Bitmap image)
        {
            string res = "";
            for (int i = 0; i <image.Height/4; i++) {
                res += "\n";
                for (int j = 0; j <image.Width/2; j++) {
                    res+=getbraile(j * 2, i * 4, image);
                }
            }
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (gimage != null)
            {
                Bitmap bwimage = null;
                if (FitCheck.Checked)
                {
                     bwimage = workwithimage.resizeImage(gimage, new Size(int.Parse(inputw.Text), int.Parse(inputh.Text)));
                }
                else
                {
                    if(gimage.Width>256 || gimage.Height > 256)
                    {
                         bwimage = workwithimage.cropImage(gimage,new Rectangle(0,0,256, 256));
                    }
                    else
                    {
                        bwimage = gimage;
                    }
                }
                if (bwimage != null)
                {
                    bwimage = workwithimage.MakeBW(bwimage);
                    bwimage = workwithimage.dithering(bwimage);
                    Clipboard.Clear();
                    Clipboard.SetText(GenerateBraile(bwimage));
                    DargNDropPicBox.Image = bwimage;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gimage != null)
            {
                gimage = workwithimage.MakeNegative(gimage);
                DargNDropPicBox.Image = gimage;
            }
        }
    }
}
