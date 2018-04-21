
public class MSManipulationEvent : UIEvent
{
    protected MSManipulationEvent() : base()
    {

    }
    public float currentState;
    public float inertiaDestinationX;
    public float inertiaDestinationY;
    public float lastState;
    public float MS_MANIPULATION_STATE_ACTIVE;
    public float MS_MANIPULATION_STATE_CANCELLED;
    public float MS_MANIPULATION_STATE_COMMITTED;
    public float MS_MANIPULATION_STATE_DRAGGING;
    public float MS_MANIPULATION_STATE_INERTIA;
    public float MS_MANIPULATION_STATE_PRESELECT;
    public float MS_MANIPULATION_STATE_SELECTING;
    public float MS_MANIPULATION_STATE_STOPPED;
    public void initMSManipulationEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float lastState, float currentState)
    {
        throw new System.NotImplementedException();
    }
}
