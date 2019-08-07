using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var newFileNames = Utilities.PreviewNewNames(subtitleFileList, videoFileList, textBox_Prepend.Text, textBox_Append.Text);
            for (int i = 0; i < subtitleFileList.Count; i++)
            {
                if (newFileNames[i] != subtitleFileList[i].FileName)
                {
                    var newPath = Path.Combine(Path.GetDirectoryName(subtitleFileList[i].FullFilePath), newFileNames[i]);
                    File.Move(subtitleFileList[i].FullFilePath, newPath);
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
            RefreshPreview();
        }

        private void Button_VideoClear_Click(object sender, EventArgs e)
        {
            videoFileList.Clear();
            RefreshPreview();
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
                var selectedIndices = new List<int>(listBox_Subtitles.SelectedIndices.Cast<int>());
                listBox_Subtitles.DataSource = Utilities.PreviewNewNames(subtitleFileList, videoFileList, textBox_Prepend.Text, textBox_Append.Text);
                listBox_Subtitles.SelectedIndices.Clear();
                foreach (var index in selectedIndices)
                {
                    if (index < listBox_Subtitles.Items.Count)
                    {
                        listBox_Subtitles.SelectedIndices.Add(index);
                    }
                }
            }
            else
            {
                listBox_Subtitles.DataSource = subtitleFileList;
            }
        }
    }
}
