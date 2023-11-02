using BookCenter.Messages;
using BookCenter.Services.Classes;
using BookCenter.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCenter.ViewModels;
class MainViewModel : ViewModelBase
{
    private readonly INavigationService _navigationService;
    private readonly IMessenger _messenger;
    private ViewModelBase currentView;

    public ViewModelBase CurrentView
    {
        get => currentView;
        set => Set(ref currentView, value);
    }

    public MainViewModel(INavigationService navigationService, IMessenger messenger)
    {
        CurrentView = App.Container.GetInstance<SearchViewModel>();

        _navigationService = navigationService;
        _messenger = messenger;

        _messenger.Register<NavigationMessage>(this, message =>
        {
            CurrentView = message.ViewModelType;
        });
    }
}
