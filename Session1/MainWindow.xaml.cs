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
        var subscriber = new Subscriber();
        publisher.OnRun += subscriber.Action;
        publisher.Run();
    }

    public class Publisher
    {
        public event Action OnRun;
        public void Run()
        {
            OnRun?.Invoke();
        }
    }

    public class Subscriber
    {
        public void Action()
        {

        }
    }
}
