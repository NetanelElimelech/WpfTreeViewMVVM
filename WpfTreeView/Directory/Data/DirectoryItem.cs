using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTreeView
{
    /// <summary>
    /// Information about a directory item such as a drive, a file or a folder
    /// </summary>
    public class DirectoryItem
    {
        /// <summary>
        /// The type of this item
        /// </summary>
         
        public DirectoryItemType Type { get; set; }

        /// <summary>
        /// The absolute path to this item
        /// </summary>

        public string FullPath { get; set; }

        /// <summary>
        /// The name of this directory
        /// </summary>

        public string Name { get { return this.Type == DirectoryItemType.Drive ? this.FullPath : DirectoryStructure.GetFileOrFolderNameFromPath(this.FullPath); } }

        public static implicit operator string(DirectoryItem v)
        {
            throw new NotImplementedException();
        }
    }
}
