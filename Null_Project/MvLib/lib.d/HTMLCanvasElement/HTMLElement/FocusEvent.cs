using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FocusEvent : UIEvent
{
    protected FocusEvent() : base()
    {

    }
    public EventTarget relatedTarget;
    public void initFocusEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, EventTarget relatedTargetArg)
    {
        throw new System.NotImplementedException();
    }
}
