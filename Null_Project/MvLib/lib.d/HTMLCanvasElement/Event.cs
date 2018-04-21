using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Event
{
    protected Event()
    {

    }
    public readonly bool bubbles;
		public bool cancelBubble;
    public readonly bool cancelable;
		public readonly bool currentTarget;
		public readonly bool defaultPrevented;
		public readonly bool eventPhase;
		public readonly bool isTrusted;
		public bool returnValue;
    public readonly Element srcElement;
		public readonly EventTarget target;
		public readonly int timeStamp;
		public readonly string type;
		public readonly int AT_TARGET;
		public readonly int BUBBLING_PHASE;
		public readonly int CAPTURING_PHASE;
		public void initEvent(string eventTypeArg, bool canBubbleArg, bool cancelableArg)
    {
        throw new System.NotImplementedException();
    }
    public void preventDefault()
    {
        throw new System.NotImplementedException();
    }
    public void stopImmediatePropagation()
    {
        throw new System.NotImplementedException();
    }
    public void stopPropagation()
    {
        throw new System.NotImplementedException();
    }
}
