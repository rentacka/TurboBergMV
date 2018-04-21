
public class TouchEvent : UIEvent
{
    protected TouchEvent() : base()
    {

    }
    public bool altKey;
    public TouchList changedTouches;
    public bool ctrlKey;
    public bool metaKey;
    public bool shiftKey;
    public TouchList targetTouches;
    public TouchList touches;
}
