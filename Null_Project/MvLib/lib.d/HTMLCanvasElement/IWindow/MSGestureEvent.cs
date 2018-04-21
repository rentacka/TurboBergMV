public class MSGestureEvent : UIEvent
{
    protected MSGestureEvent() : base()
    {

    }
    public float clientX;
    public float clientY;
    public float expansion;
    public object gestureObject;
    public float hwTimestamp;
    public float offsetX;
    public float offsetY;
    public float rotation;
    public float scale;
    public float screenX;
    public float screenY;
    public float translationX;
    public float translationY;
    public float velocityAngular;
    public float velocityExpansion;
    public float velocityX;
    public float velocityY;
    public float MSGESTURE_FLAG_BEGIN;
    public float MSGESTURE_FLAG_CANCEL;
    public float MSGESTURE_FLAG_END;
    public float MSGESTURE_FLAG_INERTIA;
    public float MSGESTURE_FLAG_NONE;
    public void initGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, float offsetXArg, float offsetYArg, float translationXArg, float translationYArg, float scaleArg, float expansionArg, float rotationArg, float velocityXArg, float velocityYArg, float velocityExpansionArg, float velocityAngularArg, float hwTimestampArg)
    {
        throw new System.NotImplementedException();
    }
}
