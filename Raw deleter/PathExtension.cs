using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw_deleter
{
    static class PathExtension
    {
        /// <summary>
        /// Get filenames with extension
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<string> Filenames(this List<string> path) => path.Select(_ => System.IO.Path.GetFileName(_)).ToList();

        /// <summary>
        /// returns list of names without extensions
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public static List<string> OnlyNames(this List<string> files) => files.Select(f => System.IO.Path.GetFileNameWithoutExtension(f)).ToList();

        /// <summary>
        /// returns file name without extension
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string OnlyName(this string file) => System.IO.Path.GetFileNameWithoutExtension(file);
    }
}
