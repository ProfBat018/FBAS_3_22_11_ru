public class StateChangedEventArgs : EventArgs
{
    public string Message { get; }

    public StateChangedEventArgs(string message)
    {
        Message = message;
    }
}