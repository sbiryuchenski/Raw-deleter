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
        public ListsForm(List<string> rawList, List<string> jpegList)
        {
            InitializeComponent();
            rawListBox.Items.AddRange(rawList.ToArray());
            jpegListBox.Items.AddRange(rawList.ToArray());
        }

        private void rawListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
