using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Session1;

public class MainWindowViewModel : BaseViewModel
{
    private string firstName;
    private string lastName;

    public string FirstName
    {
        get => firstName; set
        {
            firstName = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(FullName));
        }
    }

    public string LastName
    {
        get => lastName; set
        {
            lastName = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(FullName));
        }
    }

    public string FullName => $"{FirstName} {LastName}";
}

public abstract class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}