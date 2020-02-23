using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            var selectedIndices = new List<int>(listBox.SelectedIndices.Cast<int>().Reverse());
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
    }
}
