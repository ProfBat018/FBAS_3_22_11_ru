using BookCenter.Models;
using BookCenter.Services.Classes;
using BookCenter.Services.Interfaces;
using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace BookCenter.ViewModels
{
    class SearchViewModel : ViewModelBase
    {
        public ObservableCollection<Result> SearchResults { get => searchResults; set => Set(ref searchResults, value); }
        private ObservableCollection<Result> searchResults;

        public string SearchQuery { get; set; }

        private readonly IBookManagerService _managerService;

        public SearchViewModel(IBookManagerService managerService)
        {
            _managerService = managerService;
        }

        public MyRelayCommand SearchCommand
        {
            get => new(
        () =>
        {
            try
            {
                BookModel downloadedData = _managerService.GetBooks("Harry Potter");

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
    }
}

