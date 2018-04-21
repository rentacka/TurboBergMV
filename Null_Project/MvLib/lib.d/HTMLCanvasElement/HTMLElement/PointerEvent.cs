public class PointerEvent : MouseEvent
{
    protected PointerEvent() : base()
    {

    }
    public object currentPoint;
    public float height;
    public float hwTimestamp;
    public object intermediatePoints;
    public bool isPrimary;
    public float pointerId;
    public object pointerType;
    public float pressure;
    public float rotation;
    public float tiltX;
    public float tiltY;
    public float width;
    public void getCurrentPoint(Element element)
    {
        throw new System.NotImplementedException();
    }
    public void getIntermediatePoints(Element element)
    {
        throw new System.NotImplementedException();
    }
    public void initPointerEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, float buttonArg, EventTarget relatedTargetArg, float offsetXArg, float offsetYArg, float widthArg, float heightArg, float pressure, float rotation, float tiltX, float tiltY, float pointerIdArg, object pointerType, float hwTimestampArg, bool isPrimary)
    {
        throw new System.NotImplementedException();
    }
}
