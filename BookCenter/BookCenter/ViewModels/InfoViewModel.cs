using BookCenter.Messages;
using BookCenter.Models;
using BookCenter.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BookCenter.ViewModels;
class InfoViewModel : ViewModelBase
{
    private readonly INavigationService _navigationService;
    private readonly IMessenger _messenger;


    public Result SelectedBook { get; set; }
    public InfoViewModel(INavigationService navigationService, IMessenger messenger)
    {
        _navigationService = navigationService;
        _messenger = messenger;

        _messenger.Register<DataMessage>(this, message =>
        {
            if (message.Data != null)
            {
                SelectedBook = message.Data as Result;
            }
        });
    }
        public RelayCommand GoBackCommand{ get => new(
            () =>
            {
                _navigationService.NavigateTo<SearchViewModel>();
            }
        ); }
}


