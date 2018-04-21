public class MessageEvent : Event
{
    protected MessageEvent() : base()
    {

    }
    public object data;
    public string origin;
    public object ports;
    public IWindow source;
    public void initMessageEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object dataArg, string originArg, string lastEventIdArg, IWindow sourceArg)
    {
        throw new System.NotImplementedException();
    }
}
