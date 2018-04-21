
public class DragEvent : MouseEvent
{
    protected DragEvent() : base()
    {

    }
    public DataTransfer dataTransfer;
    public void initDragEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, float buttonArg, EventTarget relatedTargetArg, DataTransfer dataTransferArg)
    {
        throw new System.NotImplementedException();
    }
    public void msConvertURL(File file, string targetType, string targetURL = default(string))
    {
        throw new System.NotImplementedException();
    }
}
