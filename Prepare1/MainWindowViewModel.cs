using CommunityToolkit.Mvvm.ComponentModel;

namespace Prepare1;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty, NotifyPropertyChangedFor(nameof(FullName))]
    string? firstName;
    
    [ObservableProperty, NotifyPropertyChangedFor(nameof(FullName))]
    string? lastName;

    public string FullName => $"{FirstName} {LastName}";
}