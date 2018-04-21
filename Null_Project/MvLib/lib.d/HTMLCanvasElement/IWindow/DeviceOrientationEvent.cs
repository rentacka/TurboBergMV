public class DeviceOrientationEvent : Event
{
    protected DeviceOrientationEvent() : base()
    {

    }
    public bool absolute;
    public float alpha;
    public float beta;
    public float gamma;
    public void initDeviceOrientationEvent(string type, bool bubbles, bool cancelable, float alpha, float beta, float gamma, bool absolute)
    {
        throw new System.NotImplementedException();
    }
}
