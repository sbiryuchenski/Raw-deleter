using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raw_deleter
{
    public partial class ListsForm : Form
    {
        Deleter deleter;
        public ListsForm(List<string> rawList, List<string> jpegList, List<string> deleteList, bool deleteImmediately = false)
        {
            InitializeComponent();
            rawListBox.Items.AddRange(rawList.ToArray());
            jpegListBox.Items.AddRange(jpegList.ToArray());
            DeleteListBox.Items.AddRange(deleteList.ToArray());
            deleter = new Deleter(FilePathContainer.ToDelete);
            this.Show();
            if (deleteImmediately) Delete();
        }

        private void Delete() // Deletes files
        {
            deleteButton.Enabled = false;
            deleteProgress.Maximum = deleter.filesCount;
            
            deleter.DeleteFielsAsync();
            while(deleter.deleteProgress < deleter.filesCount && deleter.deleteStopped)
            {
                deleteProgress.Value = deleter.deleteProgress;
            }
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

        /// <summary>
        /// Delete raws
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}