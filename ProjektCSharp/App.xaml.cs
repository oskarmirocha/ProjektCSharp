using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using ProjektCSharp.Data;

namespace ProjektCSharp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            IServiceCollection serviceCollection = services.AddDbContext<DbContext>(option =>
            {
                option.UseSqlite("Data Source = Film.db");
                option.UseSqlite("Data Source = Wypożyczenie.db");
                option.UseSqlite("Data Source = Klient.db");
                option.UseSqlite("Data Source = Reżyser.db");
            });

            services.AddSingleton<MainWindow>();
            serviceProvider = services.BuildServiceProvider();
        }
        private void OnStartup(object s, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

    }
}