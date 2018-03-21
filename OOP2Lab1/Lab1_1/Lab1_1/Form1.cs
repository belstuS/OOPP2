using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_1
{

    public partial class Form1 : Form
    {
        Calculator cal = new Calculator();
        public Form1()
        {
           InitializeComponent();
        }
        private void WarningInput()
        {
            warningText.Text = "Please enter data correctly";
        }
        private void unionButton_Click(object sender, EventArgs e)
        {
            cal.Initialize(inputString1.Text, inputString2.Text, inputString3.Text,
                inputString4.Text);
            resultString.Text = cal.Union();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            cal.Initialize(inputString1.Text, inputString2.Text, inputString3.Text,
                inputString4.Text);
            try
            {
                resultString.Text = cal.Delete();
            }
            catch (ArgumentException)
            {
                WarningInput();
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            cal.Initialize(inputString1.Text, inputString2.Text, inputString3.Text,
                inputString4.Text);
            try
            {
                resultString.Text = cal.Replace();
            }
            catch (ArgumentException)
            {
                WarningInput();
            }
        }

        private void indexButton_Click(object sender, EventArgs e)
        {
            cal.Initialize(inputString1.Text, inputString2.Text, inputString3.Text,
                inputString4.Text);
            try
            {
                resultString.Text = cal.IndexOfSymbol();
            }
            catch (FormatException)
            {
                WarningInput();
            }
            catch (IndexOutOfRangeException)
            {
                WarningInput();
            }
        }

        private void lengthButton_Click(object sender, EventArgs e)
        {
            cal.Initialize(inputString1.Text, inputString2.Text, inputString3.Text,
                inputString4.Text);
            resultString.Text = cal.LenghtOfString();
        }

        private void doubleButton_Click(object sender, EventArgs e)
        {
            cal.Initialize(inputString1.Text, inputString2.Text, inputString3.Text,
                inputString4.Text);
            resultString.Text = cal.DoubleVowel();
        }
    }
}
