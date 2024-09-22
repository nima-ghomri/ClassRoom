using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Session1;

public partial class MainWindowViewModel : ObservableObject
{
    public PersonViewModel Person { get; set; } = new();
    public PanelViewModel Panel { get; set; } = new();
}