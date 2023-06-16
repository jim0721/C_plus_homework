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
    public partial class Frm_M30_泛用集合List : Form
    {
        public Frm_M30_泛用集合List()
        {
            InitializeComponent();
        }

        public void ShowProducts()
        {
            labShow.Text = "產品\n----------\n";
            decimal totalPrice = 0;
            //for (int i = 0; i < lsProduct.Count; i++)
            //{
            //    labShow.Text += $"名稱: {lsProduct[i].Name} ," +
            //        $" 單價: {lsProduct[i].UnitPrice:C0}\n";
            //    totalPrice += lsProduct[i].UnitPrice;
            //}
            foreach(Product pro  in lsProduct)
            {
                labShow.Text += $"名稱: {pro.Name} ," +
                    $" 單價: {pro.UnitPrice:C0}\n";
                totalPrice += pro.UnitPrice;
            }

            labShow.Text += $"----------\n產品數量: {lsProduct.Count}";

            if (lsProduct.Count > 0)
            {
                labShow.Text += $" 平均單價: {totalPrice / lsProduct.Count:C1}";
            }
        }

        List<Product> lsProduct = new List<Product>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = txtProductName.Text;
            pro.UnitPrice = decimal.Parse(txtProductPrice.Text);

            lsProduct.Add(pro);

            ShowProducts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //lsProduct.Add("string");
            //lsProduct.Add(100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = txtProductName.Text;
            pro.UnitPrice = decimal.Parse(txtProductPrice.Text);

            lsProduct.Insert(0, pro);

            ShowProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsProduct.RemoveAt(0);
            ShowProducts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lsProduct.Clear();
            ShowProducts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void labShow_Click(object sender, EventArgs e)
        {

        }
    }
}
