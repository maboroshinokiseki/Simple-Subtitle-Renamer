using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSubtitleRenamer
{
    internal class FileListItem : INotifyPropertyChanged
    {
        private string fullFilePath;

        public FileListItem(string path)
        {
            fullFilePath = path;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string FileName
        {
            get => Path.GetFileName(fullFilePath);
        }

        public string FullFilePath
        {
            get => this.fullFilePath;
            set
            {
                this.fullFilePath = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullFilePath)));
            }
        }

        public override string ToString()
        {
            return FileName;
        }
    }
}
