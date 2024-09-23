using System.Windows;
using System.Windows.Controls;

namespace Session1
{
    /// <summary>
    /// Interaction logic for PersonItemView.xaml
    /// </summary>
    public partial class PersonItemView : UserControl
    {
        public PersonItemView()
        {
            InitializeComponent();
        }




        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(int), typeof(PersonItemView));




        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        public static readonly DependencyProperty FirstNameProperty =
            DependencyProperty.Register(nameof(FirstName), typeof(string), typeof(PersonItemView));



        public string LastName
        {
            get { return (string)GetValue(LastNameProperty); }
            set { SetValue(LastNameProperty, value); }
        }

        public static readonly DependencyProperty LastNameProperty =
            DependencyProperty.Register("LastName", typeof(string), typeof(PersonItemView), new PropertyMetadata("***"));

    }
}
