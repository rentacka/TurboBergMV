using System;

public class ApplicationCache : EventTarget
{
    protected ApplicationCache() : base()
    {

    }
    public Func<object, Event, object> oncached;
    public Func<object, Event, object> onchecking;
    public Func<object, Event, object> ondownloading;
    public Func<object, ErrorEvent, object> onerror;
    public Func<object, Event, object> onnoupdate;
    public Func<object, Event, object> onobsolete;
    public Func<object, ProgressEvent, object> onprogress;
    public Func<object, Event, object> onupdateready;
    public float status;
    public float CHECKING;
    public float DOWNLOADING;
    public float IDLE;
    public float OBSOLETE;
    public float UNCACHED;
    public float UPDATEREADY;
    public Func<object, Event, object> listener;
    public Event ev;
    public bool useCapture;
    public void abort()
    {
        throw new System.NotImplementedException();
    }
    public void swapCache()
    {
        throw new System.NotImplementedException();
    }
    public void update()
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
