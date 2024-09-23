using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Session1
{
    static class LabelAttachedProperties
    {
        public static bool GetIsHighlighted(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsHighlightedProperty);
        }

        public static void SetIsHighlighted(DependencyObject obj, bool value)
        {
            obj.SetValue(IsHighlightedProperty, value);
        }

        public static readonly DependencyProperty IsHighlightedProperty =
            DependencyProperty.RegisterAttached("IsHighlighted", typeof(bool), typeof(Label));
    }
}
