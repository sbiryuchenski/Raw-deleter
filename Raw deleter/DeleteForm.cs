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
    public partial class DeleteForm : Form
    {
        List<string> deleteFiles;
        public DeleteForm(List<string> deleteFiles)
        {
            this.deleteFiles = deleteFiles;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void cancelDeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
