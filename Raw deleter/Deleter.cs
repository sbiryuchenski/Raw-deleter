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
    /// Selects what to delete and deletes it
    /// </summary>
    class Deleter
    {
        List<string> toDelete;
        public int deleteProgress { get; private set; } = 0;
        public int filesCount { get; private set; }
        public bool deleteStopped { get; private set; } = true;

        public Deleter(List<string> toDelete)
        {
            this.toDelete = new List<string>(toDelete);
            filesCount = toDelete.Count;
        }

        private void DeleteFiles() // Deletes files in list
        {
            foreach (var d in toDelete)
            {
                File.Delete(d);
                deleteProgress++;
            }
            MessageBox.Show("Files deleted!");
        }

        /// <summary>
        /// Acync method that deletes files in list
        /// </summary>
        public async void DeleteFielsAsync()
        {
            await Task.Run(() => DeleteFiles());
        }
    }
}