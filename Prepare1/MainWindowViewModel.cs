using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Prepare1;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty, NotifyPropertyChangedFor(nameof(FullName))]
    string? firstName;

    [ObservableProperty, NotifyPropertyChangedFor(nameof(FullName))]
    string? lastName;

    public string FullName => $"{FirstName} {LastName}";

    public ObservableCollection<PersonViewModel> People { get; set; }
}

public partial class PersonViewModel : ObservableObject
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}