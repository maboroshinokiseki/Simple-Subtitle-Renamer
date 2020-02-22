using System.ComponentModel;
using System.IO;

namespace SimpleSubtitleRenamer
{
    internal class FileListItem : INotifyPropertyChanged
    {
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

        public bool IsPreview
        {
            get => isPreview;
            set
            {
                isPreview = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsPreview)));
            }
        }

        public string PreviewFileName
        {
            get => previewFileName;
            set
            {
                previewFileName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PreviewFileName)));
            }
        }


        public override string ToString()
        {
            return IsPreview ? PreviewFileName : FileName;
        }

        private string fullFilePath;
        private bool isPreview;
        private string previewFileName;
    }
}
