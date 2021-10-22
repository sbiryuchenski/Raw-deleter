using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw_deleter
{
    /// <summary>
    /// Gets paths of files folders
    /// </summary>
    class PathSelecter
    {
        System.Windows.Forms.FolderBrowserDialog RawFolderChecker;
        System.Windows.Forms.FolderBrowserDialog JpegFolderChecker;
        public Path Path { get; set; }

        public PathSelecter()
        {
            RawFolderChecker = new System.Windows.Forms.FolderBrowserDialog();
            JpegFolderChecker = new System.Windows.Forms.FolderBrowserDialog();
            Path = new Path();
        }
        

        private string BaseTaker(System.Windows.Forms.FolderBrowserDialog taker)
        {
            taker.ShowDialog();
            return taker.SelectedPath;
        }

        /// <summary>
        /// Get Path of folder with raws
        /// </summary>
        /// <returns></returns>
        public string RawPathTaker()
        {
            Path.Raw = BaseTaker(RawFolderChecker);
            return Path.Raw;
        }

        /// <summary>
        /// Get Path of folder with jpegs
        /// </summary>
        /// <returns></returns>
        public string JpegPathTaker()
        {
            Path.JPEG = BaseTaker(JpegFolderChecker);
            return Path.JPEG;
        }
    }
}
