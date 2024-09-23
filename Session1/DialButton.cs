using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Session1
{
    public class DialButton : Button
    {
        static DialButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DialButton), new FrameworkPropertyMetadata(typeof(DialButton)));
        }


        public string Letters
        {
            get { return (string)GetValue(LettersProperty); }
            set { SetValue(LettersProperty, value); }
        }

        public static readonly DependencyProperty LettersProperty =
            DependencyProperty.Register("Letters", typeof(string), typeof(DialButton));
    }
}
