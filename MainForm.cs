using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace SimpleSubtitleRenamer
{
    public partial class MainForm : Form
    {
        private BindingList<FileListItem> videoFileList;
        private BindingList<FileListItem> subtitleFileList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            videoFileList = new BindingList<FileListItem>();
            listBox_Videos.DataSource = videoFileList;
            subtitleFileList = new BindingList<FileListItem>();
            listBox_Subtitles.DataSource = subtitleFileList;
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Button_Rename_Click(object sender, EventArgs e)
        {
            foreach (var item in subtitleFileList)
            {
                if (item.FileName != item.PreviewFileName)
                {
                    var newPath = Path.Combine(Path.GetDirectoryName(item.FullFilePath), item.PreviewFileName);
                    File.Move(item.FullFilePath, newPath);
                    item.FullFilePath = newPath;
                }
            }
        }

        private void ListBox_Subtitles_DragDrop(object sender, DragEventArgs e)
        {
            Utilities.AddPathsToList(e, subtitleFileList);
            RefreshPreview();
        }

        private void ListBox_Videos_DragDrop(object sender, DragEventArgs e)
        {
            Utilities.AddPathsToList(e, videoFileList);
            RefreshPreview();
        }

        private void Button_SubtitleMoveUp_Click(object sender, EventArgs e)
        {
            Utilities.ListItemsMoveUp(listBox_Subtitles, subtitleFileList);
            RefreshPreview();
        }

        private void Button_VideoMoveUp_Click(object sender, EventArgs e)
        {
            Utilities.ListItemsMoveUp(listBox_Videos, videoFileList);
            RefreshPreview();
        }

        private void Button_SubtitleMoveDown_Click(object sender, EventArgs e)
        {
            Utilities.ListItemsMoveDown(listBox_Subtitles, subtitleFileList);
            RefreshPreview();
        }

        private void Button_VideoMoveDown_Click(object sender, EventArgs e)
        {
            Utilities.ListItemsMoveDown(listBox_Videos, videoFileList);
            RefreshPreview();
        }

        private void Button_SubtitleDelete_Click(object sender, EventArgs e)
        {
            Utilities.ListItemsDeleteSelected(listBox_Subtitles, subtitleFileList);
            RefreshPreview();
        }

        private void Button_VideoDelete_Click(object sender, EventArgs e)
        {
            Utilities.ListItemsDeleteSelected(listBox_Videos, videoFileList);
            RefreshPreview();
        }

        private void Button_SubtitleClear_Click(object sender, EventArgs e)
        {
            subtitleFileList.Clear();
        }

        private void Button_VideoClear_Click(object sender, EventArgs e)
        {
            videoFileList.Clear();
        }

        private void CheckBox_Preview_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void TextBox_Prepend_TextChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void TextBox_Append_TextChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void RefreshPreview()
        {
            if (checkBox_Preview.Checked)
            {
                var minCount = subtitleFileList.Count < videoFileList.Count ? subtitleFileList.Count : videoFileList.Count;
                for (int i = 0; i < minCount; i++)
                {
                    var subPath = subtitleFileList[i].FullFilePath;
                    var videoPath = videoFileList[i].FullFilePath;
                    var subExt = Path.GetExtension(subPath);
                    var videoName = Path.GetFileNameWithoutExtension(videoPath);
                    var newSubName = textBox_Prepend.Text + videoName + textBox_Append.Text + subExt;
                    subtitleFileList[i].PreviewFileName = newSubName;
                }

                for (int i = minCount; i < subtitleFileList.Count; i++)
                {
                    subtitleFileList[i].PreviewFileName = subtitleFileList[i].FileName;
                }
            }

            if (subtitleFileList.Count > 1 && subtitleFileList[0].IsPreview != checkBox_Preview.Checked)
            {
                foreach (var item in subtitleFileList)
                {
                    item.IsPreview = checkBox_Preview.Checked;
                }
            }
        }
    }
}
