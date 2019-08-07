using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSubtitleRenamer
{
    class Utilities
    {
        public static void AddPathsToList(DragEventArgs e, BindingList<FileListItem> bindingList)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var path in paths)
            {
                bindingList.Add(new FileListItem(path));
            }
        }

        public static void ListItemsMoveUp(ListBox listBox, IBindingList bindingList)
        {
            int minimum = 0;
            var selectedIndices = new List<int>(listBox.SelectedIndices.Cast<int>());
            var newSelectedIndices = new List<int>();
            foreach (int index in selectedIndices)
            {
                var newIndex = index - 1;
                if (newIndex < minimum)
                {
                    newSelectedIndices.Add(index);
                    minimum = index + 1;
                    continue;
                }

                newSelectedIndices.Add(newIndex);
                var temp = bindingList[index];
                bindingList.RemoveAt(index);
                bindingList.Insert(newIndex, temp);
            }

            listBox.SelectedIndices.Clear();
            foreach (var index in newSelectedIndices)
            {
                listBox.SelectedIndices.Add(index);
            }
        }

        public static void ListItemsMoveDown(ListBox listBox, IBindingList bindingList)
        {
            int maximum = bindingList.Count - 1;
            var selectedIndices = new List<int>(listBox.SelectedIndices.Cast<int>());
            selectedIndices.Reverse();
            var newSelectedIndices = new List<int>();
            foreach (int index in selectedIndices)
            {
                var newIndex = index + 1;
                if (newIndex > maximum)
                {
                    newSelectedIndices.Add(index);
                    maximum = index - 1;
                    continue;
                }

                newSelectedIndices.Add(newIndex);
                var temp = bindingList[index];
                bindingList.RemoveAt(index);
                bindingList.Insert(newIndex, temp);
            }

            listBox.SelectedIndices.Clear();
            foreach (var index in newSelectedIndices)
            {
                listBox.SelectedIndices.Add(index);
            }
        }

        public static void ListItemsDeleteSelected(ListBox listBox, IBindingList bindingList)
        {
            var selectedIndices = new List<int>(listBox.SelectedIndices.Cast<int>());
            var count = 0;
            foreach (int index in selectedIndices)
            {
                bindingList.RemoveAt(index - count);
                count++;
            }
        }

        public static List<string> PreviewNewNames(BindingList<FileListItem> subtitles, BindingList<FileListItem> videos, string prepend, string append)
        {
            var newNames = new List<string>();
            var minCount = subtitles.Count < videos.Count ? subtitles.Count : videos.Count;
            for (int i = 0; i < minCount; i++)
            {
                var subPath = subtitles[i].FullFilePath;
                var videoPath = videos[i].FullFilePath;
                var subExt = Path.GetExtension(subPath);
                var videoName = Path.GetFileNameWithoutExtension(videoPath);
                videoName = prepend + videoName + append;
                newNames.Add(videoName + subExt);
            }

            for (int i = minCount; i < subtitles.Count; i++)
            {
                newNames.Add(subtitles[i].FileName);
            }

            return newNames;
        }
    }
}
