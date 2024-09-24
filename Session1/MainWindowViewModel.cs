using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace Session1;

public partial class MainWindowViewModel : ObservableObject
{
    public PersonViewModel Person { get; set; } = new();
    public PanelViewModel Panel { get; set; } = new();

    [RelayCommand]
    void OpenDial()
    {
        var window = new Window();
        window.Content = new DialsView() { };
        window.Show();
    }
}