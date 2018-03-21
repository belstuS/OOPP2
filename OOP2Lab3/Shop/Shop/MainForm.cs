using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Shop
{
    public partial class MainForm : Form
    {
        public static List<String> type = new List<String>
        {
            "Nutritive",
            "Building",
            "Chancellory",
            "Industrial"
        };
        List<Product> products = JsonSave.deserializeProducts<List<Product>>();
        IEnumerable<Product> workProducts = new List<Product>();
        public MainForm()
        {
            InitializeComponent();
            searchComboBox.DataSource = type;
            this.Load += new EventHandler(UpdateWorkers);
            this.Load += new EventHandler(UpdateInformLabel);
            this.searchButton.Click += new EventHandler(UpdateWorkers);
            this.addStripMenuItem1.Click += new EventHandler(UpdateInformLabel);
        }
        private void PrintProducts(IEnumerable<Product> products)
        {
            productInformText.Clear();
            int number = 1;
            foreach (Product product in products)
            {
                productInformText.Text += "№" + number.ToString() + "\n"+  product.ToString();
                number++;
            }
        }
        private void checkCheckBoxs(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrEmpty(tb.Text))
            {
                tb.BackColor = Color.Pink;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = Color.Aqua;
                tb.Tag = true;
            }
        }
        #region Buttons
        private void showProductsButton_Click(object sender, EventArgs e)
        {
            if (products != null)
            {
                PrintProducts(products);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (nameCheckBox.Checked == true)
            {
                workProducts = ProductSort.SearchByName(workProducts, searchNameText.Text);
            }
            if (typeCheckBox.Checked == true)
            {
                workProducts = ProductSort.SearchByType(workProducts, searchComboBox.Text);
            }
            if (priceCheckBox.Checked == true)
            {
                workProducts = ProductSort.SearchByPrice(workProducts, minPriceBar.Value);
            }
            PrintProducts(workProducts);
        }

        #endregion
        #region Update
        private void minPriceBar_Scroll(object sender, EventArgs e)
        {
            this.priceValueLabel.Text = minPriceBar.Value.ToString();
        }
        private void UpdateInformLabel(object sender, EventArgs e)
        {
            informationLabel.Text = "Count of products: " + products.Count.ToString() + "\n" +
                DateTime.Today.ToShortDateString();
        }
        private void UpdateWorkers(object sender, EventArgs e)
        {
            workProducts = new List<Product>(products);
        }
        private void UpdateProducts()
        {
            products = JsonSave.deserializeProducts<List<Product>>();
            workProducts = new List<Product>(products);
        }
        #endregion
        #region Menu
        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ann Babako, 2018", "Information", MessageBoxButtons.OK);
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintProducts(ProductSort.SortByName(workProducts));
        }
        private void dateSortItemMenu_Click_1(object sender, EventArgs e)
        {
            PrintProducts(ProductSort.SortByDate(workProducts));
        }

        private void priceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PrintProducts(ProductSort.SortByPrice(workProducts));
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSave.Serialize<List<Product>>((List<Product>)workProducts, "searchResult.xml");
        }

        private void sortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XmlSave.Serialize<List<Product>>((List<Product>)workProducts, "sortResult.xml");
        }
        private void cleanWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productInformText.Clear();
        }
        #endregion

        private void closeMenuButton_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == false)
            {
                menuStrip1.Visible = true;
            }
            else
            {
                menuStrip1.Visible = false;
            }
        }

        private void addStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.ShowDialog();
            UpdateProducts();
        }
    }
}
