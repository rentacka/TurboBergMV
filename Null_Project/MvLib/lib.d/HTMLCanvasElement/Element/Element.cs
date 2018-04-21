using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Element : Node
{
    protected Element() : base()
    {

    }
    public readonly DOMTokenList classList;
		public string className;
    public readonly int clientHeight;
		public readonly int clientLeft;
		public readonly int clientTop;
		public readonly int clientWidth;
		public string id;
    public float msContentZoomFactor;
    public readonly string msRegionOverflow;
		public Func<object, object> onariarequest;
    public WheelEvent ev;
    public object any;
    public Func<object, object> oncommand;
    public Func<object, object> ongotpointercapture;
    public Func<object, object> onlostpointercapture;
    public Func<object, object> onmsgesturechange;
    public Func<object, object> onmsgesturedoubletap;
    public Func<object, object> onmsgestureend;
    public Func<object, object> onmsgesturehold;
    public Func<object, object> onmsgesturestart;
    public Func<object, object> onmsgesturetap;
    public Func<object, object> onmsgotpointercapture;
    public Func<object, object> onmsinertiastart;
    public Func<object, object> onmslostpointercapture;
    public Func<object, object> onmspointercancel;
    public Func<object, object> onmspointerdown;
    public Func<object, object> onmspointerenter;
    public Func<object, object> onmspointerleave;
    public Func<object, object> onmspointermove;
    public Func<object, object> onmspointerout;
    public Func<object, object> onmspointerover;
    public Func<object, object> onmspointerup;
    public Func<object, object> ontouchcancel;
    public Func<object, object> ontouchend;
    public Func<object, object> ontouchmove;
    public Func<object, object> ontouchstart;
    public Func<object, object> onwebkitfullscreenchange;
    public Func<object, object> onwebkitfullscreenerror;
    public string prefix;
		public float scrollHeight;
		public float scrollLeft;
    public float scrollTop;
    public float scrollWidth;
		public string tagName;
		public string innerHTML;
    public Func<object, object> listener;
    public bool useCapture;
    public string getAttribute(string name)
    {
        throw new System.NotImplementedException();
    }
    public string getAttributeNS(string namespaceURI, string localName)
    {
        throw new System.NotImplementedException();
    }
    public Attr getAttributeNode(string name)
    {
        throw new System.NotImplementedException();
    }
    public Attr getAttributeNodeNS(string namespaceURI, string localName)
    {
        throw new System.NotImplementedException();
    }
    public ClientRect getBoundingClientRect()
    {
        throw new System.NotImplementedException();
    }
    public ClientRectList getClientRects()
    {
        throw new System.NotImplementedException();
    }
    public object getElementsByTagName(object name)
    {
        throw new System.NotImplementedException();
    }
    public NodeListOf<Element> getElementsByTagName(string name)
    {
        throw new System.NotImplementedException();
    }
    public object getElementsByTagNameNS(object namespaceURI)
    {
        throw new System.NotImplementedException();
    }
    public HTMLCollectionOf<Element> getElementsByTagNameNS(string namespaceURI, string localName)
    {
        throw new System.NotImplementedException();
    }
    public bool hasAttribute(string name)
    {
        throw new System.NotImplementedException();
    }
    public bool hasAttributeNS(string namespaceURI, string localName)
    {
        throw new System.NotImplementedException();
    }
    public MSRangeCollection msGetRegionContent()
    {
        throw new System.NotImplementedException();
    }
    public ClientRect msGetUntransformedBounds()
    {
        throw new System.NotImplementedException();
    }
    public bool msMatchesSelector(string selectors)
    {
        throw new System.NotImplementedException();
    }
    public void msReleasePointerCapture(float pointerId)
    {
        throw new System.NotImplementedException();
    }
    public void msSetPointerCapture(float pointerId)
    {
        throw new System.NotImplementedException();
    }
    public void msZoomTo(MsZoomToOptions args)
    {
        throw new System.NotImplementedException();
    }
    public void releasePointerCapture(float pointerId)
    {
        throw new System.NotImplementedException();
    }
    public void removeAttribute(string name = default(string))
    {
        throw new System.NotImplementedException();
    }
    public void removeAttributeNS(string namespaceURI, string localName)
    {
        throw new System.NotImplementedException();
    }
    public Attr removeAttributeNode(Attr oldAttr)
    {
        throw new System.NotImplementedException();
    }
    public void requestFullscreen()
    {
        throw new System.NotImplementedException();
    }
    public void requestPointerLock()
    {
        throw new System.NotImplementedException();
    }
    public void setAttribute(string name, string value)
    {
        throw new System.NotImplementedException();
    }
    public void setAttributeNS(string namespaceURI, string qualifiedName, string value)
    {
        throw new System.NotImplementedException();
    }
    public Attr setAttributeNode(Attr newAttr)
    {
        throw new System.NotImplementedException();
    }
    public Attr setAttributeNodeNS(Attr newAttr)
    {
        throw new System.NotImplementedException();
    }
    public void setPointerCapture(float pointerId)
    {
        throw new System.NotImplementedException();
    }
    public bool webkitMatchesSelector(string selectors)
    {
        throw new System.NotImplementedException();
    }
    public void webkitRequestFullScreen()
    {
        throw new System.NotImplementedException();
    }
    public void webkitRequestFullscreen()
    {
        throw new System.NotImplementedException();
    }
    public NodeListOf<Element> getElementsByClassName(string classNames)
    {
        throw new System.NotImplementedException();
    }
    public bool matches(string selector)
    {
        throw new System.NotImplementedException();
    }
    public Element closest(string selector)
    {
        throw new System.NotImplementedException();
    }
    public void scrollIntoView(object arg = default(object))
    {
        throw new System.NotImplementedException();
    }
    public void scroll(ScrollToOptions options = default(ScrollToOptions))
    {
        throw new System.NotImplementedException();
    }
    public void scroll(float x, float y)
    {
        throw new System.NotImplementedException();
    }
    public void scrollTo(ScrollToOptions options = default(ScrollToOptions))
    {
        throw new System.NotImplementedException();
    }
    public void scrollTo(float x, float y)
    {
        throw new System.NotImplementedException();
    }
    public void scrollBy(ScrollToOptions options = default(ScrollToOptions))
    {
        throw new System.NotImplementedException();
    }
    public void scrollBy(float x, float y)
    {
        throw new System.NotImplementedException();
    }
    public Element insertAdjacentElement(string position, Element insertedElement)
    {
        throw new System.NotImplementedException();
    }
    public void insertAdjacentHTML(string where, string html)
    {
        throw new System.NotImplementedException();
    }
    public void insertAdjacentText(string where, string text)
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