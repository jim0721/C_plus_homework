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
    public partial class Frm_M18_enum : Form
    {
        public Frm_M18_enum()
        {
            InitializeComponent();
        }

        private void btnProdcuts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prodcuts");
        }

        private void btnValidation01_Click(object sender, EventArgs e)
        {
            // Admin -> 1
            // User -> 2
            int Admin = 1, User = 2;

            int Role = 1;

            //Admin = 4;

            if(Role == Admin)
            {
                btnProdcuts.Enabled = true;
            }
            else
            {
                btnProdcuts.Enabled = false;
            }
        }

        private void btnValidation02_Click(object sender, EventArgs e)
        {
            // Admin -> 1
            // User -> 2
            const int Admin = 1, User = 2;

            int Role = 1;

            //Admin = 4;

            if(Role == Admin)
            {
                btnProdcuts.Enabled = true;
            }
            else
            {
                btnProdcuts.Enabled = false;
            }
        }

        private void btnEnum_Click(object sender, EventArgs e)
        {
            //int Role = 1;

            //if(Role == (int)UserRole.Admin)
            //{
            //    btnProdcuts.Enabled=true;
            //}
            //else
            //{
            //    btnProdcuts.Enabled=false;
            //}

            UserRole Role = UserRole.Guest;

            //if (Role == UserRole.Admin)
            //{
            //    btnProdcuts.Enabled = true;
            //}
            //else
            //{
            //    btnProdcuts.Enabled = false;
            //}

            switch (Role)
            {
                case UserRole.Admin:
                    btnProdcuts.Enabled = true;
                    break;
                case UserRole.User:
                    btnProdcuts.Enabled = false;
                    break;
            }


        }
    }
}
