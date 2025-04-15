using System.Windows;
using System.Windows.Input;
using Microsoft.Extensions.DependencyInjection;

namespace UserProfileEntry
{
    public class UserProfileViewModel : ViewModelBase
    {
        public ICommand CloseCommand { get; }

        public UserProfileViewModel()
        {
            CloseCommand = new RelayCommand(Close);
        }

        private void Close()
        {
            // Logic to close the form
            Application.Current.Shutdown();
        }
    }
}
