using CommunityToolkit.Mvvm.ComponentModel;

namespace Session1;

public partial class MainWindowViewModel : ObservableObject
{
    public PersonViewModel Person { get; set; } = new();
    public PanelViewModel Panel { get; set; } = new();
}