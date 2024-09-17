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

namespace Session1
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
            fullNameTextBlock.Text = $"{firstNameTextBox.Text} {lastNameTextBox.Text}";
            fullNameTextBlock.Background = Brushes.Red;
            this.Title = fullNameTextBlock.Text;
        }

        private void lastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            fullNameTextBlock.Text = $"{firstNameTextBox.Text} {lastNameTextBox.Text}";
            this.Title = fullNameTextBlock.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            firstNameTextBox.Text = "";
        }

        private void lastNameClear_Click(object sender, RoutedEventArgs e)
        {
            lastNameTextBox.Text = "";
        }

        private void clearAllButton_Click(object sender, RoutedEventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            fullNameTextBlock.Text = "";
        }
    }
}