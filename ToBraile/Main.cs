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
        string version = "v0.0.0";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (gimage != null)
            {
                Bitmap bwimage = workwithimage.resizeImage(gimage, new Size(int.Parse(inputw.Text), int.Parse(inputh.Text)));
                bwimage = workwithimage.MakeBW(bwimage);
                bwimage = workwithimage.dithering(bwimage);
                DargNDropPicBox.Image = bwimage;
            }
        }

    
    }
}
