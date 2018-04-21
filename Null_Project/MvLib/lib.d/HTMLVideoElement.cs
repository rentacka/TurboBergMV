using System;
public class HTMLVideoElement : HTMLMediaElement
{
    protected HTMLVideoElement() : base()
    {

    }
    public float height;
    public bool msHorizontalMirror;
    public bool msIsLayoutOptimalForPlayback;
    public bool msIsStereo3D;
    public string msStereo3DPackingMode;
    public string msStereo3DRenderMode;
    public bool msZoom;
    public Func<object, Event, object> onMSVideoFormatChanged;
    public Func<object, Event, object> onMSVideoFrameStepCompleted;
    public Func<object, Event, object> onMSVideoOptimalLayoutChanged;
    public string poster;
    public float videoHeight;
    public float videoWidth;
    public bool webkitDisplayingFullscreen;
    public bool webkitSupportsFullscreen;
    public float width;
    public Func<object, WheelEvent, object> listener;
    public WheelEvent ev;
    public bool useCapture;
    public VideoPlaybackQuality getVideoPlaybackQuality()
    {
        throw new System.NotImplementedException();
    }
    public void msFrameStep(bool forward)
    {
        throw new System.NotImplementedException();
    }
    public void msInsertVideoEffect(string activatableClassId, bool effectRequired, object config = default(object))
    {
        throw new System.NotImplementedException();
    }
    public void msSetVideoRectangle(float left, float top, float right, float bottom)
    {
        throw new System.NotImplementedException();
    }
    public void webkitEnterFullScreen()
    {
        throw new System.NotImplementedException();
    }
    public void webkitEnterFullscreen()
    {
        throw new System.NotImplementedException();
    }
    public void webkitExitFullScreen()
    {
        throw new System.NotImplementedException();
    }
    public void webkitExitFullscreen()
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
