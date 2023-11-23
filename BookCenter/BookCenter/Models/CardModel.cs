using GalaSoft.MvvmLight;
using System.ComponentModel;

namespace BookCenter.ViewModels;

public class CardModel : INotifyPropertyChanged
{
    private string cardNum;
    private string cVV;
    private string year;

    public string CardNum { get => cardNum; set
        {
            RaisePropertyChanged("CardNum");
            cardNum = value;
        }
    }

    public string CVV { get => cVV; set
        {
            RaisePropertyChanged("CVV");
            cVV = value;
        }
    }

    public string Year { get => year; set
        {
            RaisePropertyChanged("Year");
            year = value;
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged(string name)
    {
        PropertyChanged(this, new PropertyChangedEventArgs(name));
    }

}