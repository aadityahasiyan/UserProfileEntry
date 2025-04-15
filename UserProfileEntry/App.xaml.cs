using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace UserProfileEntry
{
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        public IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<UserProfileViewModel>();
        }
    }
}
