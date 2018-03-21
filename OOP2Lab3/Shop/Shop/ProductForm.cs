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
            #region TagsFalse
            productTypeText.DataSource = type;
            this.addJSONButton.Enabled = false;
            this.productNameText.Tag = false;
            this.producerOrganizationText.Tag = false;
            this.producerCountryText.Tag = false;
            this.stockmanFNameText.Tag = false;
            this.stockmanLName.Tag = false;
            this.producerAdressText.Tag = false;
            this.stockmanAdressText.Tag = false;
            this.productPriceText.Tag = false;
            this.productNumberText.Tag = false;
            this.productNumberText.Tag = false;
            #endregion
            #region ValidationEvents
            this.productNameText.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.producerOrganizationText.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.producerCountryText.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.stockmanFNameText.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.stockmanSName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.stockmanLName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidated);
            this.producerAdressText.Validating += new System.ComponentModel.CancelEventHandler(this.richBoxValidated);
            this.stockmanAdressText.Validating += new System.ComponentModel.CancelEventHandler(this.richBoxValidated);
            this.productPriceText.Validating += new System.ComponentModel.CancelEventHandler(this.maskedFieldValidated);
            this.productNumberText.Validating += new System.ComponentModel.CancelEventHandler(this.numberFieldValidated);
            this.producerTelephoneText.Validating += new System.ComponentModel.CancelEventHandler(this.telephoneFieldValidated);
            #endregion
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
                productTypeText.Text, Convert.ToDouble(productPriceText.Text), producer, stockman, dateCalender.SelectionStart);
            return product;
        }
        private void addProductButton_Click(object sender, EventArgs e)
        {
            Product product = CreateProduct();
            JsonSave.serializeProduct(product);
            this.Close();
        }
        #region Validation
        private void ValidateOk()
        {
            bool flag = (
                (bool)(this.producerAdressText.Tag) &&
                (bool)(this.producerCountryText.Tag) &&
                (bool)(this.productNameText.Tag) &&
                (bool)(this.stockmanLName.Tag) &&
                (bool)(this.stockmanSName.Tag) &&
                (bool)(this.stockmanLName.Tag) &&
                (bool)(this.producerAdressText.Tag) &&
                (bool)(this.stockmanAdressText.Tag) &&
                (bool)(this.productPriceText.Tag) &&
                (bool)(this.productNumberText.Tag) &&
                (bool)(this.producerTelephoneText.Tag)
                );
            this.addJSONButton.Enabled = flag;

        }
        private void CheckNumField(Regex regex, MaskedTextBox mtb)
        {
            if (!regex.IsMatch(mtb.Text))
            {
                mtb.BackColor = Color.Pink;
                mtb.Tag = false;
            }
            else
            {
                mtb.BackColor = Color.Aqua;
                mtb.Tag = true;
            }
        }
        private void numberFieldValidated(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaskedTextBox mtb = (MaskedTextBox)sender;
            Regex regex = new Regex(@"\d{3}-\d{3}-\d{3}");
            CheckNumField(regex, mtb);
        }
        private void telephoneFieldValidated(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaskedTextBox mtb = (MaskedTextBox)sender;
            Regex regex = new Regex(@"\(\d{3}\)\d{3}-\d{4}");
            CheckNumField(regex, mtb);
        }
        private void maskedFieldValidated(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaskedTextBox mtb = (MaskedTextBox)sender;
            Regex regex = new Regex(@"\d*.\d+");
            CheckNumField(regex, mtb);
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
        #endregion

        private void addXMLButton_Click(object sender, EventArgs e)
        {
            Product product = CreateProduct();
            List<Product> products = XmlSave.Deserialize<List<Product>>("exmpl.xml");
            products.Add(product);
            XmlSave.Serialize((List<Product>)products, "exmpl.xml");
            this.Close();
        }
    }
}