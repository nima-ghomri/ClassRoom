using CommunityToolkit.Mvvm.ComponentModel;

namespace Session1;

public partial class PersonViewModel : ObservableObject
{
    [ObservableProperty, NotifyPropertyChangedFor(nameof(FullName))]
    string firstName;

    partial void OnFirstNameChanged(string? oldValue, string newValue)
    {

    }

    [ObservableProperty, NotifyPropertyChangedFor(nameof(FullName))]
    string lastName;

    public string FullName => $"{FirstName} {LastName}";

    [ObservableProperty]
    bool married;
}
