using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Picture_Viewer : Form
    {

        public Picture_Viewer()
        {
            InitializeComponent();
        }

        private void Picture_Viewer_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (ListViewItem itm in listView1.SelectedItems)
            {
                int imgIndex = itm.ImageIndex;
                if (imgIndex >= 0 && imgIndex < this.imageList1.Images.Count)
                {
                    Picture picture = new Picture();
                    picture.pictureBox1.Image = this.imageList1.Images[imgIndex];
                                          //pictureBox1.Image = this.imageList1.Images[imgIndex];
                    picture.ShowDialog(); //show出picture表單
                }
            }
        }
    }
}
