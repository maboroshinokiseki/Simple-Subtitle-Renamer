using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SimpleSubtitleRenamer
{
    static class BindingListExt
    {
        public static void BeginUpdate<T>(this BindingList<T> bindingList)
        {
            bindingList.RaiseListChangedEvents = false;
        }

        public static void EndUpdate<T>(this BindingList<T> bindingList)
        {
            bindingList.RaiseListChangedEvents = true;
            bindingList.ResetBindings();
        }
    }
}
