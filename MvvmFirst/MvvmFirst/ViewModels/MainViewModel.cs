using MvvmFirst.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MvvmFirst.ViewModels;

public class ButtonCommand : ICommand
{
    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    private Action _action;
    private Func<bool> _canExecute;

    public ButtonCommand(Action action, Func<bool> canExecute)
    {
        _action = action;
        _canExecute = canExecute;
    }

    public bool CanExecute(object? parameter)
    {
        return _canExecute();
    }
    public void Execute(object? parameter)
    {
        _action();
    }
}


public class MainViewModel
{
    public PersonModel PersonToAdd { get; set; } = new();
    public ObservableCollection<PersonModel> People { get; set; } = new()
    {
        new()
        {
            Name = "Patrick",
            Surname = "Star",
            Age = 36
        },
        new()
        {
            Name = "Lighting",
            Surname = "McQueen",
            Age = 17
        }
    };


    public ButtonCommand AddCommand
    {
        get => new(
        () =>
        {
            People.Add(PersonToAdd);
        },
        () =>
        {
            if (string.IsNullOrEmpty(PersonToAdd.Name) || string.IsNullOrEmpty(PersonToAdd.Surname) || PersonToAdd.Age < 18)
            {
                return false;
            }
            return true;
        });
    }

}
