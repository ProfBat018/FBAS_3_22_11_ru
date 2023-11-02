using BookCenter.Services.Classes;
using BookCenter.Services.Interfaces;
using BookCenter.ViewModels;
using BookCenter.Views;
using GalaSoft.MvvmLight.Messaging;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace BookCenter;

public partial class App : Application
{
    public static Container Container { get; set; }
    void Register()
    {
        Container = new();

        Container.RegisterSingleton<IDownloadService, DownloadService>();
        Container.RegisterSingleton<IJsonService, JsonService>();
        Container.RegisterSingleton<IBookManagerService, BookManagerService>();

        Container.RegisterSingleton<IMessenger, Messenger>();
        Container.RegisterSingleton<INavigationService, NavigationService>();
        Container.RegisterSingleton<IDataService, DataService>();

        Container.RegisterSingleton<MainViewModel>();
        Container.RegisterSingleton<SearchViewModel>();
        Container.RegisterSingleton<OrderViewModel>();
        Container.RegisterSingleton<InfoViewModel>();

        Container.Verify();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        Register();

        var window = new MainView();
        window.DataContext = Container.GetInstance<MainViewModel>();
        
        window.ShowDialog();
    }
}
