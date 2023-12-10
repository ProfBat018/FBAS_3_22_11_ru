public class SubjectWithEvent // класс, который хранит состояние и оповещает наблюдателей
{
    public event EventHandler<StateChangedEventArgs>? StateChanged;

    public void DoSomethingImportant()
    {
        Console.WriteLine("Something important is happening.");
        OnStateChanged("State has been changed.");
    }

    protected virtual void OnStateChanged(string message)
    {
        StateChanged?.Invoke(this, new StateChangedEventArgs(message));
    }

    public void RemoveObserver(ObserverWithEvent observer)
    {
        StateChanged -= observer.HandleStateChanged;
        Console.WriteLine($"{observer.Name} has been unsubscribed.");
    }
}