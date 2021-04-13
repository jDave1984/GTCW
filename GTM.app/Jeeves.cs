using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTM.app.Exceptions;

namespace GTM.app
{
    /// <summary>
    /// Jeeves - Jeeves does things that everyone needs. It's a cool class
    /// </summary>
    public static class Jeeves
    {
        /// <summary>
        /// Attempts to find the Grand Tactician Folder on the machine. Searches all directories with read access to find "Grand Tactician The Civil War (1861-1865)"
        /// </summary>
        /// <returns></returns>
        public static string GetGTFolder()
        {
            Debug.Print("Searching Machine for Grand Tactician Folder...");
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the Path to your Grand Tactician Folder";
                folderDialog.ShowNewFolderButton = false;
                folderDialog.ShowDialog();
                return folderDialog.SelectedPath;
            }
        }
    }
}
