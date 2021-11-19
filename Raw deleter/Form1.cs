﻿using System;
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
    public partial class Form1 : Form
    {
        PathSelecter pathSelecter;
        ListGetter listGetter;

        public Form1()
        {
            InitializeComponent();
            pathSelecter = new PathSelecter();
            listGetter = new ListGetter();
        }

        private void RawFolderPathBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)//raw
        {
            RawFolderPathBox.Text = pathSelecter.RawPathTaker();
        }

        private void FolderChecker_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//jpeg
        {
            JpegFolderPathBox.Text = pathSelecter.JpegPathTaker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                if (listGetter.GetLists(RawFolderPathBox.Text, JpegFolderPathBox.Text))
                {
                    new ListsForm(listGetter.rawList.Filenames(), listGetter.jpegList.Filenames(), listGetter.deleteList.Filenames()).Show();
                }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void JpegFolderPathBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
