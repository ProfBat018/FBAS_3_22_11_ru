public class ObserverWithEvent
{
    private string name;
    public string Name => name;

    public ObserverWithEvent(string name)
    {
        this.name = name;
    }

    public void HandleStateChanged(object sender, StateChangedEventArgs e)
    {
        Console.WriteLine($"{name} received message from {sender.GetType().Name} with message: {e.Message}");
    }

    public void Unsubscribe(SubjectWithEvent subject)
    {
        subject.RemoveObserver(this);
    }
}