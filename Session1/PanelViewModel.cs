using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Session1
{
    public partial class PanelViewModel : ObservableObject
    {
        [ObservableProperty]
        bool isOpen = true;

        public ObservableCollection<PersonViewModel> People { get; set; } =
            [
                new() { FirstName = "Nima", LastName = "Ghomri" },
                new() { FirstName = "Vahid", LastName = "Borhani" },
            ];

        [ObservableProperty]
        PersonViewModel selectedPerson;

        public ICommand RemoveCommand { get; set; }
        public PanelViewModel()
        {
            RemoveCommand = new RemovePersonCommand(People);
        }

        [RelayCommand]
         void RemovePerson(PersonViewModel person)
        {
            People.Remove(person);
        }
    }





    internal class RemovePersonCommand : ICommand
    {
        private ObservableCollection<PersonViewModel> people;

        public RemovePersonCommand(ObservableCollection<PersonViewModel> people)
        {
            this.people = people;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return parameter is PersonViewModel && people.Count > 1;
        }

        public void Execute(object? parameter)
        {
            people.Remove((PersonViewModel)parameter!);
        }
    }
}
