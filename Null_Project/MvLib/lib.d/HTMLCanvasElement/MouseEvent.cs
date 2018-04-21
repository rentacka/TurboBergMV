using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MouseEvent : UIEvent
{
    protected MouseEvent() : base()
    {

    }
    public readonly bool altKey;
		public readonly int button;
		public readonly int buttons;
		public readonly int clientX;
		public readonly int clientY;
		public readonly bool ctrlKey;
		public readonly Element fromElement;
		public readonly int layerX;
		public readonly int layerY;
		public readonly int metaKey;
		public readonly int movementX;
		public readonly int movementY;
		public readonly int offsetX;
		public readonly int offsetY;
		public readonly int pageX;
		public readonly int pageY;
		public readonly EventTarget relatedTarget;
		public readonly int tscreenX;
		public readonly int screenY;
		public readonly bool shiftKey;
		public readonly Element toElement;
		public readonly int which;
		public readonly int x;
		public readonly int y;
		public bool getModifierState(string keyArg)
    {
        throw new System.NotImplementedException();
    }
    public void initMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, float buttonArg, EventTarget relatedTargetArg)
    {
        throw new System.NotImplementedException();
    }
}