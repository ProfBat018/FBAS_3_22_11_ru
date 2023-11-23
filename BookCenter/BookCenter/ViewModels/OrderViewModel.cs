

using BookCenter.Messages;
using BookCenter.Models;
using BookCenter.Services;
using BookCenter.Services.Classes;
using BookCenter.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.ComponentModel;
using System.Windows;

namespace BookCenter.ViewModels;

 class OrderViewModel : ViewModelBase
{
    private readonly INavigationService _navigationService;
    private readonly IMessenger _messenger;
    
    private string cardNum;
    public string CardNum 
    {
        get => cardNum; set
        {
            Set(ref cardNum, value);
        }
    }

    public string CVV { get; set; }
    public string Year { get; set; }


    public OrderViewModel(INavigationService navigationService, IMessenger messenger)
    {
        _navigationService = navigationService;
        _messenger = messenger;

        OrderCommand = new DelegateCommand(() =>
        {
            MessageBox.Show("Ordered");
        },
        () =>
        {
            if ((!String.IsNullOrWhiteSpace(CardNum)) && CardNum.Length > 3)
            {
                return true;
            }
            return false;
        });
    }

    public DelegateCommand OrderCommand
    {
        get;
        private set;
    }

    public RelayCommand GoBackCommand
    {
        get => new(
            () =>
            {
                _navigationService.NavigateTo<InfoViewModel>();
            }
        );
    }
}
