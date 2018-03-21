using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{
    public partial class Form1 : Form
    {
        Collection collection = new Collection();

        public Form1()
        {
            InitializeComponent();
        }
        private void AddItem(Student student, ListView view)
        {
            ListViewItem it = new ListViewItem(new[] { student.name, Convert.ToString(student.age) });
            it.Tag = student;
            view.Items.Add(it);
        }
        private void PrintList(IEnumerable<Student> students, ListView view)
        {
            view.Items.Clear();
            if (students != null)
            {
                foreach (Student student in students)
                    AddItem(student, view);
            }
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            resultString.Text = collection.MinAge();
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            resultString.Text = collection.MaxAge();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            resultString.Text = collection.size.ToString();
        }

        private void createButton(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(sizeCollection.Text);
                collection = new Collection(size);
                PrintList(collection.students, studentsCollection);
            }
            catch (FormatException)
            {
                warningText.Text = "Please enter count of Students";
            }

        }

        private void AscButton(object sender, EventArgs e)
        {
            PrintList(collection.SequenceList(1), sortedCollection);
        }

        private void DescClick(object sender, EventArgs e)
        {
            PrintList(collection.SequenceList(-1), sortedCollection);
        }
    }
}
