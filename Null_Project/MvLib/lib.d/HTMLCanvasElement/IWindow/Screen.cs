using System;

public class Screen : EventTarget
{
    protected Screen() : base()
    {

    }
    public float availHeight;
    public float availWidth;
    public float bufferDepth;
    public float colorDepth;
    public float deviceXDPI;
    public float deviceYDPI;
    public bool fontSmoothingEnabled;
    public float height;
    public float logicalXDPI;
    public float logicalYDPI;
    public string msOrientation;
    public Func<object, Event, object> onmsorientationchange;
    public float pixelDepth;
    public float systemXDPI;
    public float systemYDPI;
    public float width;
    public Func<object, Event, object> listener;
    public Event ev;
    public bool useCapture;
    public bool msLockOrientation(object orientations)
    {
        throw new System.NotImplementedException();
    }
    public void msUnlockOrientation()
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
