using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Raw_deleter
{
    /// <summary>
    /// Gets lists of files
    /// </summary>
    class ListGetter
    {
        /// <summary>
        /// List with raw filenames
        /// </summary>
        public List<string> rawList { get; private set; }
        /// <summary>
        /// List with jpeg filenames
        /// </summary>
        public List<string> jpegList { get; private set; }
        /// <summary>
        /// List whith filenames to delete
        /// </summary>
        public List<string> deleteList { get; private set; }
        /// <summary>
        /// Is both lists not empty
        /// </summary>
        public bool isListNotEmpty { get; private set; }
        private void MessageBoxShow(string text)
        {
            MessageBox.Show(text);
        }

        /// <summary>
        /// Get lists of filenames in both folders
        /// </summary>
        /// <param name="rawPath"></param>
        /// <param name="jpegPath"></param>
        public bool GetLists(string rawPath, string jpegPath)
        {
            if (!Directory.Exists(rawPath))
            {
                MessageBoxShow($"The directory with path {rawPath} now found");
                return false;
            }
            if (!Directory.Exists(jpegPath))
            {
                MessageBoxShow($"The directory with path {jpegPath} now found");
                return false;
            }

            rawList = Directory.GetFiles(rawPath).ToList();
            FilePathContainer.Raw = rawList;
            jpegList = Directory.GetFiles(jpegPath).ToList();
            FilePathContainer.Jpeg = jpegList;
            deleteList = rawList.Where(r => !jpegList.OnlyNames().Contains(r.OnlyName())).Select(f => f).ToList();
            FilePathContainer.ToDelete = deleteList;
            return CheckListsNotEmpty();
        }

        private bool CheckListsNotEmpty()
        {
            isListNotEmpty = (rawList.Count > 0 && jpegList.Count > 0);
            return isListNotEmpty;
        }

        public void ClearLists()
        {
            rawList.Clear();
            isListNotEmpty = false;
        }
        public void ClearJpegList()
        {
            jpegList.Clear();
            isListNotEmpty = false;
        }
    }
}
