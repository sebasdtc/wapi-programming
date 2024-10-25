using DataWappi.Models;
using DataWappi.Presenters;
using DataWappi.Repositories;
using DataWappi.Views;
using Microsoft.Extensions.Configuration;

namespace DataWappi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IMainView mainView = new MainView();
            IDirectvCustomersRepository directvCustomersRepository = new DirectvCustomersRepository();
            // Create an instance of IConfiguration
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            _ = new MainPresenter(mainView, directvCustomersRepository, configuration);    
            Application.Run((Form)mainView);
        }
    }
}