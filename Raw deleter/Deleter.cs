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
        Deleter(List<string> toDelete)
        {
            this.toDelete = new List<string>(toDelete);
        }

        /// <summary>
        /// Deletes files in list
        /// </summary>
        public void DeleteFiles()
        {
            foreach (var d in toDelete)
            {
                File.Delete(d);
            }
            MessageBox.Show("Files deleted!");
        }
    }
}
