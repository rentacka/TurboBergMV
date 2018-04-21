using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MSInputMethodContext : EventTarget
{
    protected MSInputMethodContext() : base()
    {

    }
    public float compositionEndOffset;
    public float compositionStartOffset;
    public Func<object, Event, object> oncandidatewindowhide;
    public Func<object, Event, object> oncandidatewindowshow;
    public Func<object, Event, object> oncandidatewindowupdate;
    public HTMLElement target;
    public Func<object, Event, object> listener;
    public Event ev;
    public bool useCapture;
    public ClientRect getCandidateWindowClientRect()
    {
        throw new System.NotImplementedException();
    }
    public string[] getCompositionAlternatives()
    {
        throw new System.NotImplementedException();
    }
    public bool hasComposition()
    {
        throw new System.NotImplementedException();
    }
    public bool isCandidateWindowVisible()
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
