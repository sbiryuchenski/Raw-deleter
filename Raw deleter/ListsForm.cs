using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raw_deleter
{
    public partial class ListsForm : Form
    {
        public ListsForm(List<string> rawList, List<string> jpegList, List<string> deleteList)
        {
            InitializeComponent();
            rawListBox.Items.AddRange(rawList.ToArray());
            jpegListBox.Items.AddRange(jpegList.ToArray());
            DeleteListBox.Items.AddRange(deleteList.ToArray());
        }

        private void rawListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jpegListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ListsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
