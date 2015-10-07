using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace SidCatUI
{
    /// <summary>
    /// Copied from http://stackoverflow.com/questions/3041718/function-call-within-xaml-code
    /// In that example this class lives in a separate namespace 'Controls.Behaviours'
    /// </summary>
    public static class TextBoxBehaviour
    {
        public static bool GetSelectAll(TextBoxBase target)
        {
            return (bool)target.GetValue(SelectAllAttachedProperty);
        }

        public static void SetSelectAll(TextBoxBase target, bool value)
        {
            target.SetValue(SelectAllAttachedProperty, value);
        }

        public static readonly DependencyProperty SelectAllAttachedProperty = 
            DependencyProperty.RegisterAttached("SelectAll", typeof(bool), 
                typeof(TextBoxBehaviour), 
                new UIPropertyMetadata(false, OnSelectAllAttachedPropertyChanged));

        static void OnSelectAllAttachedPropertyChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ((TextBoxBase)o).SelectAll();
        }
    }
}
