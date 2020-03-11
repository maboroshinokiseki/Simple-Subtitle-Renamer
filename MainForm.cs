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
            ChangeLanguage(Properties.Settings.Default.Language);
            Size = Properties.Settings.Default.Size;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            videoFileList = new BindingList<FileListItem>();
            listBox_Videos.DataSource = videoFileList;
            subtitleFileList = new BindingList<FileListItem>();
            listBox_Subtitles.DataSource = subtitleFileList;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Size = Size;
            Properties.Settings.Default.Save();
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

        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            var listBox = (ListBox)sender;
            var source = (BindingList<FileListItem>)listBox.DataSource;
            if (listBox == listBox_Subtitles)
            {
                Utilities.AddPathsToList(e, source, "ass,ssa,srt,sub,vtt");
            }
            else
            {
                Utilities.AddPathsToList(e, source, "3gp,avi,mkv,mp4,flv");
            }
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
            RefreshPreview();
        }

        private void CheckBox_Preview_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPreview();

            subtitleFileList.BeginUpdate();

            foreach (var item in subtitleFileList)
            {
                item.IsPreview = checkBox_Preview.Checked;
            }

            subtitleFileList.EndUpdate();
        }

        private void TextBox_Prepend_TextChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void TextBox_Append_TextChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void Button_Rename_Click(object sender, EventArgs e)
        {
            foreach (var item in subtitleFileList)
            {
                if (item.FileName != item.PreviewFileName)
                {
                    var newPath = Path.Combine(Path.GetDirectoryName(item.FullFilePath), item.PreviewFileName);
                    try
                    {
                        File.Move(item.FullFilePath, newPath);
                        item.FullFilePath = newPath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error".Localize(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RefreshPreview()
        {
            subtitleFileList.BeginUpdate();

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

            subtitleFileList.EndUpdate();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }

        private void simplifiedChineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("chs");
        }

        private void traditionalChineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("cht");
        }

        private void ChangeLanguage(string lang)
        {
            Properties.Settings.Default.Language = lang;
            Properties.Settings.Default.Save();

            Localizer.InitLocalizedResource(lang);
            languageToolStripMenuItem.Text = "Language".Localize();
            label_Prepend.Text = "Prepend:".Localize();
            label_Append.Text = "Append:".Localize();
            button_SubtitleDelete.Text = "Delete".Localize();
            button_VideoDelete.Text = "Delete".Localize();
            button_SubtitleClear.Text = "Clear".Localize();
            button_VideoClear.Text = "Clear".Localize();
            button_Rename.Text = "Rename".Localize();
            checkBox_Preview.Text = "Preview".Localize();

            tableLayoutPanel_Prepend.ColumnStyles[0].SizeType = SizeType.AutoSize;
            tableLayoutPanel_Append.ColumnStyles[0].SizeType = SizeType.AutoSize;
            var max = Math.Max(label_Prepend.Width, label_Append.Width);
            tableLayoutPanel_Prepend.ColumnStyles[0].SizeType = SizeType.Absolute;
            tableLayoutPanel_Prepend.ColumnStyles[0].Width = max + 8;
            tableLayoutPanel_Append.ColumnStyles[0].SizeType = SizeType.Absolute;
            tableLayoutPanel_Append.ColumnStyles[0].Width = max + 8;
        }
    }
}
