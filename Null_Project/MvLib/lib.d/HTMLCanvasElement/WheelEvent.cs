using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WheelEvent : MouseEvent
{
    protected WheelEvent() : base()
    {

    }
    public readonly int deltaMode;
		public readonly int deltaX;
		public readonly int deltaY;
		public readonly int deltaZ;
		public readonly int wheelDelta;
		public readonly int wheelDeltaX;
		public readonly int wheelDeltaY;
		public readonly int DOM_DELTA_LINE;
		public readonly int DOM_DELTA_PAGE;
		public readonly int DOM_DELTA_PIXEL;
		public void getCurrentPoint(Element element)
    {
        throw new System.NotImplementedException();
    }
    public void initWheelEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, float buttonArg, EventTarget relatedTargetArg, string modifiersListArg, float deltaXArg, float deltaYArg, float deltaZArg, float deltaMode)
    {
        throw new System.NotImplementedException();
    }
}
