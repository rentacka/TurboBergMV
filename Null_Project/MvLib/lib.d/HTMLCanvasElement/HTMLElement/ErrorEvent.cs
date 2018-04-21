public class ErrorEvent : Event
{
    protected ErrorEvent() : base()
    {

    }
    public float colno;
    public object error;
    public string filename;
    public float lineno;
    public string message;
    public void initErrorEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string messageArg, string filenameArg, float linenoArg)
    {
        throw new System.NotImplementedException();
    }
}
