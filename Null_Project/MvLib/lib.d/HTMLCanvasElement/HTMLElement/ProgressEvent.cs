public class ProgressEvent : Event
{
    protected ProgressEvent() : base()
    {

    }
    public bool lengthComputable;
    public float loaded;
    public float total;
    public void initProgressEvent(string typeArg, bool canBubbleArg, bool cancelableArg, bool lengthComputableArg, float loadedArg, float totalArg)
    {
        throw new System.NotImplementedException();
    }
}
