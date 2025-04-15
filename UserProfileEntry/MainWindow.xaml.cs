using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace UserProfileEntry
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.Current.ServiceProvider.GetRequiredService<UserProfileViewModel>();
        }
    }
}
