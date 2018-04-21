using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UIEvent : Event
{
    protected UIEvent() : base()
    {

    }
    public readonly int detail;
		public readonly IWindow view;
		public void initUIEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg)
    {
        throw new System.NotImplementedException();
    }
}
