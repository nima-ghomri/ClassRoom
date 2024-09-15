using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prepare1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void firstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var fullname = $"{firstNameTextBox.Text} {lastNameTextBox.Text}";
            fullNameTextBlock.Text = fullname;
            this.Title = fullname;
        }

        private void lastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var fullname = $"{firstNameTextBox.Text} {lastNameTextBox.Text}";
            fullNameTextBlock.Text = fullname;
            this.Title = fullname;
        }

        private void clearFirstNameButton_Click(object sender, RoutedEventArgs e)
        {
            firstNameTextBox.Text = "";
        }

        private void clearLastNameButton_Click(object sender, RoutedEventArgs e)
        {
            lastNameTextBox.Text = "";
        }

        private void clearAllNameButton_Click(object sender, RoutedEventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
        }
    }
}