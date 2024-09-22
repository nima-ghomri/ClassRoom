using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
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

        [ObservableProperty, NotifyCanExecuteChangedFor(nameof(RemovePersonCommand))]
        bool flag;

        public PanelViewModel()
        {

        }

        [RelayCommand]
        void ToggleFlag()
        {
            Flag = !Flag;
        }

        [RelayCommand(CanExecute = nameof(CanRemovePerson))]
        void RemovePerson(PersonViewModel person)
        {
            People.Remove(person);
        }

        bool CanRemovePerson(PersonViewModel person)
        {
            return person is PersonViewModel && flag;
        }
    }

    public class ConcatConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Join((parameter as string)??" ", values);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return value is string text ? text.Split((parameter as string) ?? " ").ToArray() : [];
        }
    }
    public class NullableToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is null ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
