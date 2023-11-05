using BookCenter.Messages;
using BookCenter.Models;
using BookCenter.Services.Classes;
using BookCenter.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace BookCenter.ViewModels
{
    class SearchViewModel : ViewModelBase
    {
        private readonly IBookManagerService _managerService;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;

        private ObservableCollection<Result> searchResults;
        
        public ObservableCollection<Result> SearchResults { get => searchResults; set => Set(ref searchResults, value); }

        public string SearchQuery { get; set; }

        public Result SelectedItem { get; set; }

        public SearchViewModel(IBookManagerService managerService, INavigationService navigationService, IDataService dataService)
        {
            _managerService = managerService;
            _navigationService = navigationService;
            _dataService = dataService;
        }

        public MyRelayCommand SearchCommand
        {
            get => new(
        () =>
        {
            try
            {
                BookModel downloadedData = _managerService.GetBooks(SearchQuery);

                SearchResults = new(downloadedData.Results);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        },
        () =>
        {
            return !String.IsNullOrEmpty(SearchQuery) && SearchQuery.Length >= 3;
        });
        }

        public RelayCommand MoreInfoCommand
        {
            get => new(
            () =>
            {
                _dataService.SendData(SelectedItem);
                _navigationService.NavigateTo<InfoViewModel>();
            });
        }
    }
}

