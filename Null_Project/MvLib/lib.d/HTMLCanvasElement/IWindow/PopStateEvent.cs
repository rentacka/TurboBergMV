
public class PopStateEvent : Event
{
    protected PopStateEvent() : base()
    {

    }
    public object state;
    public void initPopStateEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object stateArg)
    {
        throw new System.NotImplementedException();
    }
}