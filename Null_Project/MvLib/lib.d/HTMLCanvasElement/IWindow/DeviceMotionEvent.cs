public class DeviceMotionEvent : Event
{
    protected DeviceMotionEvent() : base()
    {

    }
    public DeviceAcceleration acceleration;
    public DeviceAcceleration accelerationIncludingGravity;
    public float interval;
    public DeviceRotationRate rotationRate;
    public void initDeviceMotionEvent(string type, bool bubbles, bool cancelable, DeviceAccelerationDict acceleration, DeviceAccelerationDict accelerationIncludingGravity, DeviceRotationRateDict rotationRate, float interval)
    {
        throw new System.NotImplementedException();
    }
}
