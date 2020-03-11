using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SimpleSubtitleRenamer
{
    class Utilities
    {
        public static void AddPathsToList(DragEventArgs e, BindingList<FileListItem> bindingList, string formatsString)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            bindingList.BeginUpdate();
            var formats = formatsString.Split(',');
            foreach (var path in paths)
            {
                if ((File.GetAttributes(path) & FileAttributes.Directory) != 0)
                {
                    var files = Directory.EnumerateFiles(path)
                        .Where(f => formats.Any(format => f.ToLower().EndsWith(format)))
                        .ToList();

                    foreach (var file in files)
                    {
                        bindingList.Add(new FileListItem(file));
                    }
                }
                else
                {
                    bindingList.Add(new FileListItem(path));
                }
            }
            bindingList.EndUpdate();
        }

        public static void ListItemsMoveUp(ListBox listBox, BindingList<FileListItem> bindingList)
        {
            int minimum = 0;
            var selectedIndices = new List<int>(listBox.SelectedIndices.Cast<int>());
            var newSelectedIndices = new List<int>();
            bindingList.BeginUpdate();
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
            bindingList.EndUpdate();

            listBox.SelectedIndices.Clear();
            foreach (var index in newSelectedIndices)
            {
                listBox.SelectedIndices.Add(index);
            }
        }

        public static void ListItemsMoveDown(ListBox listBox, BindingList<FileListItem> bindingList)
        {
            int maximum = bindingList.Count - 1;
            var selectedIndices = new List<int>(listBox.SelectedIndices.Cast<int>().Reverse());
            var newSelectedIndices = new List<int>();
            bindingList.BeginUpdate();
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
            bindingList.EndUpdate();

            listBox.SelectedIndices.Clear();
            foreach (var index in newSelectedIndices)
            {
                listBox.SelectedIndices.Add(index);
            }
        }

        public static void ListItemsDeleteSelected(ListBox listBox, BindingList<FileListItem> bindingList)
        {
            var selectedIndices = new List<int>(listBox.SelectedIndices.Cast<int>());
            var count = 0;
            bindingList.BeginUpdate();
            foreach (int index in selectedIndices)
            {
                bindingList.RemoveAt(index - count);
                count++;
            }
            bindingList.EndUpdate();
        }
    }
}
