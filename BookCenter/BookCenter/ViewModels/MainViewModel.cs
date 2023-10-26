using BookCenter.Services.Classes;
using BookCenter.Services.Interfaces;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCenter.ViewModels;
class MainViewModel : ViewModelBase
{
    public ViewModelBase CurrentView { get; set; }

    public MainViewModel()
    {
        CurrentView = App.Container.GetInstance<SearchViewModel>();
    }
}
