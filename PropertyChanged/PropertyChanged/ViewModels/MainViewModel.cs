/*

//using GalaSoft.MvvmLight;
//using GalaSoft.MvvmLight.Command;
//using Prism.Commands;
//using Prism.Mvvm;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;

//namespace PropertyChanged.ViewModels;
//class MainViewModel : BindableBase
//{
//    private string test;

//    public string Test
//    {
//        get => test; set
//        {
//            SetProperty(ref test, value);
//        }
//    }


//    public MainViewModel()
//    {
//        TestCommand = new DelegateCommand(
//            () =>
//            {
//                MessageBox.Show("This is test");
//            },
//            () =>
//            {
//                if (!String.IsNullOrEmpty(Test))
//                {
//                    if (Test.Length > 3)
//                    {
//                        return true;
//                    }
//                }
//                return false;
//            }).ObservesProperty(() => Test);    
//    }

//    public DelegateCommand TestCommand { get;  private set; }
//}

*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PropertyChanged.ViewModels;
class MainViewModel : ViewModelBase
{
    private string test;
    public string Test
    {
        get => test; set
        {
            Set(ref test, value);
        }
    }


    public MainViewModel()
    {
        TestCommand = new RelayCommand(
            () =>
            {
                MessageBox.Show("This is test");
            },
            () =>
            {
                if (!String.IsNullOrEmpty(Test))
                {
                    if (Test.Length > 3)
                    {
                        return true;
                    }
                }
                return false;
            });
    }

    public RelayCommand TestCommand { get; private set; }
}
