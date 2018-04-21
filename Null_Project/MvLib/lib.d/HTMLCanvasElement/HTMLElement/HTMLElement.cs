using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HTMLElement : Element
{
    protected HTMLElement() : base()
    {

    }
    public string accessKey;
    public HTMLCollection children;
    public string contentEditable;
    public DOMStringMap dataset;
    public string dir;
    public bool draggable;
    public bool hidden;
    public bool hideFocus;
    public new string innerHTML;
    public string innerText;
    public bool isContentEditable;
    public string lang;
    public float offsetHeight;
    public float offsetLeft;
    public Element offsetParent;
    public float offsetTop;
    public float offsetWidth;
    public Func<object, UIEvent, object> onabort;
    public Func<object, UIEvent, object> onactivate;
    public Func<object, UIEvent, object> onbeforeactivate;
    public Func<object, ClipboardEvent, object> onbeforecopy;
    public Func<object, ClipboardEvent, object> onbeforecut;
    public Func<object, UIEvent, object> onbeforedeactivate;
    public Func<object, ClipboardEvent, object> onbeforepaste;
    public Func<object, FocusEvent, object> onblur;
    public Func<object, Event, object> oncanplay;
    public Func<object, Event, object> oncanplaythrough;
    public Func<object, Event, object> onchange;
    public Func<object, MouseEvent, object> onclick;
    public Func<object, PointerEvent, object> oncontextmenu;
    public Func<object, ClipboardEvent, object> oncopy;
    public Func<object, Event, object> oncuechange;
    public Func<object, ClipboardEvent, object> oncut;
    public Func<object, MouseEvent, object> ondblclick;
    public Func<object, UIEvent, object> ondeactivate;
    public Func<object, DragEvent, object> ondrag;
    public Func<object, DragEvent, object> ondragend;
    public Func<object, DragEvent, object> ondragenter;
    public Func<object, DragEvent, object> ondragleave;
    public Func<object, DragEvent, object> ondragover;
    public Func<object, DragEvent, object> ondragstart;
    public Func<object, DragEvent, object> ondrop;
    public Func<object, Event, object> ondurationchange;
    public Func<object, Event, object> onemptied;
    public Func<object, MediaStreamErrorEvent, object> onended;
    public Func<object, ErrorEvent, object> onerror;
    public Func<object, FocusEvent, object> onfocus;
    public Func<object, Event, object> oninput;
    public Func<object, Event, object> oninvalid;
    public Func<object, KeyboardEvent, object> onkeydown;
    public Func<object, KeyboardEvent, object> onkeypress;
    public Func<object, KeyboardEvent, object> onkeyup;
    public Func<object, Event, object> onload;
    public Func<object, Event, object> onloadeddata;
    public Func<object, Event, object> onloadedmetadata;
    public Func<object, Event, object> onloadstart;
    public Func<object, MouseEvent, object> onmousedown;
    public Func<object, MouseEvent, object> onmouseenter;
    public Func<object, MouseEvent, object> onmouseleave;
    public Func<object, MouseEvent, object> onmousemove;
    public Func<object, MouseEvent, object> onmouseout;
    public Func<object, MouseEvent, object> onmouseover;
    public Func<object, MouseEvent, object> onmouseup;
    public Func<object, WheelEvent, object> onmousewheel;
    public Func<object, UIEvent, object> onmscontentzoom;
    public Func<object, MSManipulationEvent, object> onmsmanipulationstatechanged;
    public Func<object, ClipboardEvent, object> onpaste;
    public Func<object, Event, object> onpause;
    public Func<object, Event, object> onplay;
    public Func<object, Event, object> onplaying;
    public Func<object, ProgressEvent, object> onprogress;
    public Func<object, Event, object> onratechange;
    public Func<object, Event, object> onreset;
    public Func<object, UIEvent, object> onscroll;
    public Func<object, Event, object> onseeked;
    public Func<object, Event, object> onseeking;
    public Func<object, UIEvent, object> onselect;
    public Func<object, Event, object> onselectstart;
    public Func<object, Event, object> onstalled;
    public Func<object, Event, object> onsubmit;
    public Func<object, Event, object> onsuspend;
    public Func<object, Event, object> ontimeupdate;
    public Func<object, Event, object> onvolumechange;
    public Func<object, Event, object> onwaiting;
    public string outerHTML;
    public string outerText;
    public bool spellcheck;
    public CSSStyleDeclaration style;
    public float tabIndex;
    public string title;
    public new Func<object, WheelEvent, object> listener;
    public new WheelEvent ev;
    public new bool useCapture;

    public void blur()
    {
        throw new System.NotImplementedException();
    }
    public void click()
    {
        throw new System.NotImplementedException();
    }
    public bool dragDrop()
    {
        throw new System.NotImplementedException();
    }
    public void focus()
    {
        throw new System.NotImplementedException();
    }
    public MSInputMethodContext msGetInputContext()
    {
        throw new System.NotImplementedException();
    }
    public void setActive()
    {
        throw new System.NotImplementedException();
    }
    public new object addEventListener(object type)
    {
        throw new System.NotImplementedException();
    }
    public new void addEventListener(string type, object listener, bool useCapture = default(bool))
    {
        throw new System.NotImplementedException();
    }
}

