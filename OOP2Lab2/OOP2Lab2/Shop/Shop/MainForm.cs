using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void addProductButton_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.ShowDialog();
        }
        private void PrintProducts(List<Product> products)
        {
            int number = 1;
            foreach (Product product in products)
            {
                productInformText.Text += "№" + number.ToString() + "\n"+  product.ToString();
                number++;
            }
        }
        private void showProductsButton_Click(object sender, EventArgs e)
        {
            productInformText.Clear();
            List<Product> products = SaveProduct.deserializeProducts();
            if (products != null)
            {
                PrintProducts(products);
            }
        }
    }
}
