using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Prepare1;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty, NotifyPropertyChangedFor(nameof(FullName))]
    string? firstName;

    [ObservableProperty, NotifyPropertyChangedFor(nameof(FullName))]
    string? lastName;

    public string FullName => $"{FirstName} {LastName}";

    public ObservableCollection<PersonViewModel> People { get; set; } = [];
    public MainWindowViewModel()
    {
        AddPersonCommand = new AddCommand(People);
    }

    [ObservableProperty]
    PersonViewModel? selectedPerson;

    [ObservableProperty, NotifyCanExecuteChangedFor(nameof(RemovePersonCommand))]
    bool flag;

    [RelayCommand]
    void Save()
    {

    }

    [RelayCommand]
    void ChangeFlag()
    {
        Flag ^= true;
    }

    [RelayCommand]
    void RemoveAll()
    {
        People.Clear();
    }

    [RelayCommand]
    void AddEmployee()
    {
        People.Add(new EmployeeViewModel { FirstName = "John", LastName = "Smith", Job = ".Net Developer" });
    }

    public ICommand AddPersonCommand { get; }

    //[RelayCommand]
    //void AddPerson()
    //{
    //    People.Add(new PersonViewModel { FirstName = "", LastName = "" });
    //}

    [RelayCommand(CanExecute = nameof(CanRemovePerson))]
    void RemovePerson(PersonViewModel person)
    {
        People.Remove(person);
    }

    bool CanRemovePerson()
    {
        return SelectedPerson is not null && People.Count > 1 && Flag;
    }
}

public class AddCommand(ObservableCollection<PersonViewModel> people) : ICommand
{
    private readonly ObservableCollection<PersonViewModel> people = people;

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        return people is not null;
    }

    public void Execute(object? parameter)
    {
        people.Add(new PersonViewModel { FirstName = "", LastName = "" });
    }
}

public partial class PersonViewModel : ObservableObject
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public partial class EmployeeViewModel : PersonViewModel
{
    public string Job { get; set; }
}

public partial class CustomerViewModel : PersonViewModel
{
    public long Balance { get; set; }
}