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
        public ToBraile()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(DargNDropPicBox_DragEnter);
            this.DragDrop += new DragEventHandler(DargNDropPicBox_DragDrop);
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
            if (format == "png" || format == "jpg" || format == "bmp") DargNDropPicBox.Image = Image.FromFile(files[0]);
        }
    }
}
