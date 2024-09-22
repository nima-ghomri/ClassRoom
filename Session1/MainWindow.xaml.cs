using System.Windows;

namespace Session1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var publisher = new Publisher();
        publisher.Run();
    }

    public class Publisher
    {
        public Subscriber Subscriber { get; set; }
        public void Run()
        {
            Subscriber.Action();
        }
    }

    public class Subscriber
    {
        public void Action()
        {

        }
    }
}
