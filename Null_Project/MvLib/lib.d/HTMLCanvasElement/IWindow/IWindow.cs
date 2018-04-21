using System;

public class IWindow : EventTarget
{
    protected IWindow() : base()
    {

    }
    public ApplicationCache applicationCache;
    public Navigator clientInformation;
    public bool closed;
    public Crypto crypto;
    public string defaultStatus;
    public float devicePixelRatio;
    public string doNotTrack;
    public Document document;
    public Event @event;
    public External external;
    public Element frameElement;
    public IWindow frames;
    public History history;
    public float innerHeight;
    public float innerWidth;
    public float length;
    public Location location;
    public BarProp locationbar;
    public BarProp menubar;
    public MSCredentials msCredentials;
    public string name;
    public Navigator navigator;
    public object offscreenBuffering;
    public Func<object, UIEvent, object> onabort;
    public Func<object, Event, object> onafterprint;
    public Func<object, Event, object> onbeforeprint;
    public Func<object, BeforeUnloadEvent, object> onbeforeunload;
    public Func<object, FocusEvent, object> onblur;
    public Func<object, Event, object> oncanplay;
    public Func<object, Event, object> oncanplaythrough;
    public Func<object, Event, object> onchange;
    public Func<object, MouseEvent, object> onclick;
    public Func<object, Event, object> oncompassneedscalibration;
    public Func<object, PointerEvent, object> oncontextmenu;
    public Func<object, MouseEvent, object> ondblclick;
    public Func<object, DeviceLightEvent, object> ondevicelight;
    public Func<object, DeviceMotionEvent, object> ondevicemotion;
    public Func<object, DeviceOrientationEvent, object> ondeviceorientation;
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
    public ErrorEventHandler onerror;
    public Func<object, FocusEvent, object> onfocus;
    public Func<object, HashChangeEvent, object> onhashchange;
    public Func<object, Event, object> oninput;
    public Func<object, Event, object> oninvalid;
    public Func<object, KeyboardEvent, object> onkeydown;
    public Func<object, KeyboardEvent, object> onkeypress;
    public Func<object, KeyboardEvent, object> onkeyup;
    public Func<object, Event, object> onload;
    public Func<object, Event, object> onloadeddata;
    public Func<object, Event, object> onloadedmetadata;
    public Func<object, Event, object> onloadstart;
    public Func<object, MessageEvent, object> onmessage;
    public Func<object, MouseEvent, object> onmousedown;
    public Func<object, MouseEvent, object> onmouseenter;
    public Func<object, MouseEvent, object> onmouseleave;
    public Func<object, MouseEvent, object> onmousemove;
    public Func<object, MouseEvent, object> onmouseout;
    public Func<object, MouseEvent, object> onmouseover;
    public Func<object, MouseEvent, object> onmouseup;
    public Func<object, WheelEvent, object> onmousewheel;
    public Func<object, MSGestureEvent, object> onmsgesturechange;
    public Func<object, MSGestureEvent, object> onmsgesturedoubletap;
    public Func<object, MSGestureEvent, object> onmsgestureend;
    public Func<object, MSGestureEvent, object> onmsgesturehold;
    public Func<object, MSGestureEvent, object> onmsgesturestart;
    public Func<object, MSGestureEvent, object> onmsgesturetap;
    public Func<object, MSGestureEvent, object> onmsinertiastart;
    public Func<object, MSPointerEvent, object> onmspointercancel;
    public Func<object, MSPointerEvent, object> onmspointerdown;
    public Func<object, MSPointerEvent, object> onmspointerenter;
    public Func<object, MSPointerEvent, object> onmspointerleave;
    public Func<object, MSPointerEvent, object> onmspointermove;
    public Func<object, MSPointerEvent, object> onmspointerout;
    public Func<object, MSPointerEvent, object> onmspointerover;
    public Func<object, MSPointerEvent, object> onmspointerup;
    public Func<object, Event, object> onoffline;
    public Func<object, Event, object> ononline;
    public Func<object, Event, object> onorientationchange;
    public Func<object, PageTransitionEvent, object> onpagehide;
    public Func<object, PageTransitionEvent, object> onpageshow;
    public Func<object, Event, object> onpause;
    public Func<object, Event, object> onplay;
    public Func<object, Event, object> onplaying;
    public Func<object, PopStateEvent, object> onpopstate;
    public Func<object, ProgressEvent, object> onprogress;
    public Func<object, Event, object> onratechange;
    public Func<object, ProgressEvent, object> onreadystatechange;
    public Func<object, Event, object> onreset;
    public Func<object, UIEvent, object> onresize;
    public Func<object, UIEvent, object> onscroll;
    public Func<object, Event, object> onseeked;
    public Func<object, Event, object> onseeking;
    public Func<object, UIEvent, object> onselect;
    public Func<object, Event, object> onstalled;
    public Func<object, StorageEvent, object> onstorage;
    public Func<object, Event, object> onsubmit;
    public Func<object, Event, object> onsuspend;
    public Func<object, Event, object> ontimeupdate;
    public Func<TouchEvent, object> ontouchcancel;
    public Func<TouchEvent, object> ontouchend;
    public Func<TouchEvent, object> ontouchmove;
    public Func<TouchEvent, object> ontouchstart;
    public Func<object, Event, object> onunload;
    public Func<object, Event, object> onvolumechange;
    public Func<object, Event, object> onwaiting;
    public object opener;
    public object orientation;
    public float outerHeight;
    public float outerWidth;
    public float pageXOffset;
    public float pageYOffset;
    public IWindow parent;
    public Performance performance;
    public BarProp personalbar;
    public Screen screen;
    public float screenLeft;
    public float screenTop;
    public float screenX;
    public float screenY;
    public float scrollX;
    public float scrollY;
    public BarProp scrollbars;
    public IWindow self;
    public string status;
    public BarProp statusbar;
    public StyleMedia styleMedia;
    public BarProp toolbar;
    public IWindow top;
    public IWindow window;
    public object URL;
    public object Blob;
    public Func<object, WheelEvent, object> listener;
    public WheelEvent ev;
    public bool useCapture;
    public float index;
    public void alert(object message = default(object))
    {
        throw new System.NotImplementedException();
    }
    public void blur()
    {
        throw new System.NotImplementedException();
    }
    public void cancelAnimationFrame(float handle)
    {
        throw new System.NotImplementedException();
    }
    public void captureEvents()
    {
        throw new System.NotImplementedException();
    }
    public void close()
    {
        throw new System.NotImplementedException();
    }
    public bool confirm(string message = default(string))
    {
        throw new System.NotImplementedException();
    }
    public void focus()
    {
        throw new System.NotImplementedException();
    }
    public CSSStyleDeclaration getComputedStyle(Element elt, string pseudoElt = default(string))
    {
        throw new System.NotImplementedException();
    }
    public CSSRuleList getMatchedCSSRules(Element elt, string pseudoElt = default(string))
    {
        throw new System.NotImplementedException();
    }
    public Selection getSelection()
    {
        throw new System.NotImplementedException();
    }
    public MediaQueryList matchMedia(string mediaQuery)
    {
        throw new System.NotImplementedException();
    }
    public void moveBy(float x = default(float), float y = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void moveTo(float x = default(float), float y = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void msWriteProfilerMark(string profilerMarkName)
    {
        throw new System.NotImplementedException();
    }
    public IWindow open(string url = default(string), string target = default(string), string features = default(string), bool replace = default(bool))
    {
        throw new System.NotImplementedException();
    }
    public void postMessage(object message, string targetOrigin, object[] transfer = default(object[]))
    {
        throw new System.NotImplementedException();
    }
    public void print()
    {
        throw new System.NotImplementedException();
    }
    public string prompt(string message = default(string), string _default = default(string))
    {
        throw new System.NotImplementedException();
    }
    public void releaseEvents()
    {
        throw new System.NotImplementedException();
    }
    public float requestAnimationFrame(FrameRequestCallback callback)
    {
        throw new System.NotImplementedException();
    }
    public void resizeBy(float x = default(float), float y = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void resizeTo(float x = default(float), float y = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void scroll(float x = default(float), float y = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void scroll(ScrollToOptions options = default(ScrollToOptions))
    {
        throw new System.NotImplementedException();
    }
    public void scrollBy(float x = default(float), float y = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void scrollBy(ScrollToOptions options = default(ScrollToOptions))
    {
        throw new System.NotImplementedException();
    }
    public void scrollTo(float x = default(float), float y = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void scrollTo(ScrollToOptions options = default(ScrollToOptions))
    {
        throw new System.NotImplementedException();
    }
    public void webkitCancelAnimationFrame(float handle)
    {
        throw new System.NotImplementedException();
    }
    public WebKitPoint webkitConvertPointFromNodeToPage(Node node, WebKitPoint pt)
    {
        throw new System.NotImplementedException();
    }
    public WebKitPoint webkitConvertPointFromPageToNode(Node node, WebKitPoint pt)
    {
        throw new System.NotImplementedException();
    }
    public float webkitRequestAnimationFrame(FrameRequestCallback callback)
    {
        throw new System.NotImplementedException();
    }
    public object addEventListener(object type)
    {
        throw new System.NotImplementedException();
    }
    public void addEventListener(string type, object listener, bool useCapture = default(bool))
    {
        throw new System.NotImplementedException();
    }
}

