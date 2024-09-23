using System.Windows;
using System.Windows.Controls;

namespace Prepare1
{
    static class ButtonAttachedProperties
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
            DependencyProperty.RegisterAttached("IsHighlighted", typeof(bool), typeof(Button));



        public static string GetIcon(DependencyObject obj)
        {
            return (string)obj.GetValue(IconProperty);
        }

        public static void SetIcon(DependencyObject obj, string value)
        {
            obj.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(string), typeof(Button));
    }
}
