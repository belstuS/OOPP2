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
    public partial class ProductForm : Form
    {
        List<String> type = new List<String>
        {
            "Nutritive",
            "Building",
            "Chancellory",
            "Industrial"
        };
        public ProductForm()
        {
            InitializeComponent();
            productTypeText.DataSource = type;
            this.addProductButton.Enabled = false;
            this.productNameText.Tag = false;
            this.producerOrganizationText.Tag = false;
            this.producerCountryText.Tag = false;
            this.stockmanFNameText.Tag = false;
            this.stockmanLName.Tag = false;
            this.producerAdressText.Tag = false;
            this.stockmanAdressText.Tag = false;
            this.productNameText.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.producerOrganizationText.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.producerCountryText.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.stockmanFNameText.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.stockmanSName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.stockmanLName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.producerAdressText.Validating += new System.ComponentModel.CancelEventHandler(this.richBoxValidated);
            this.stockmanAdressText.Validating += new System.ComponentModel.CancelEventHandler(this.richBoxValidated);
        }

        private void massTrackBar_Scroll(object sender, EventArgs e)
        {
            massValue.Text = productmassTrack.Value.ToString();
        }

        public void global_FormClosed(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }
        private Product CreateProduct()
        {
            Producer producer = new Producer(producerOrganizationText.Text, producerCountryText.Text,
                producerTelephoneText.Text, producerAdressText.Text);
            Stockman stockman = new Stockman(stockmanFNameText.Text, stockmanSName.Text, stockmanLName.Text,
                lessFivebutton.Name, stockmanAdressText.Text);
            Product product = new Product(productNameText.Text, productNumberText.Text, productmassTrack.Value,
                productTypeText.Text, productDate.TodayDate, producer, stockman);
            return product;
        }
        private void richBoxValidated(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RichTextBox rt = (RichTextBox)sender;
            if (string.IsNullOrEmpty(rt.Text))
            {
                rt.BackColor = Color.Pink;
                rt.Tag = false;
            }
            else
            {
                rt.BackColor = Color.Aqua;
                rt.Tag = true;
            }
            ValidateOk();
        }
        private void ValidateOk()
        {
            this.addProductButton.Enabled = (
                (bool)(this.producerAdressText.Tag) &&
                (bool)(this.producerCountryText.Tag) &&
                (bool)(this.productNameText.Tag)&&
                (bool)(this.stockmanLName.Tag) &&
                (bool)(this.stockmanSName.Tag) &&
                (bool)(this.stockmanLName.Tag) &&
                (bool)(this.producerAdressText.Tag) &&
                (bool)(this.stockmanAdressText.Tag)
                );
        }
        private void textBoxValidated(object sender, System.ComponentModel.CancelEventArgs e)
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
        private void addProductButton_Click(object sender, EventArgs e)
        {
                Product product = CreateProduct();
                SaveProduct.serializeProduct(product);
                this.Close();
        }
    }
}