using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Prepare1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void rect_MouseEvent(object sender, MouseEventArgs e)
    {
        if (rect.IsMouseOver)
        {
            VisualStateManager.GoToElementState(rect, "MouseEnter", true);
        }
        else
        {
            VisualStateManager.GoToElementState(rect, "MouseLeave", true);
        }
    }

    private void CommandBinding_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
    {

    }
}