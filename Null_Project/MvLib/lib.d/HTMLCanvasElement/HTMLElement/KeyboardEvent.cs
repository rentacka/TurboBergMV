public class KeyboardEvent : UIEvent
{
    protected KeyboardEvent() : base()
    {

    }
    public bool altKey;
    public string @char;
    public float charCode;
    public bool ctrlKey;
    public string key;
    public float keyCode;
    public string locale;
    public float location;
    public bool metaKey;
    public bool repeat;
    public bool shiftKey;
    public float which;
    public string code;
    public float DOM_KEY_LOCATION_JOYSTICK;
    public float DOM_KEY_LOCATION_LEFT;
    public float DOM_KEY_LOCATION_MOBILE;
    public float DOM_KEY_LOCATION_NUMPAD;
    public float DOM_KEY_LOCATION_RIGHT;
    public float DOM_KEY_LOCATION_STANDARD;
    public bool getModifierState(string keyArg)
    {
        throw new System.NotImplementedException();
    }
    public void initKeyboardEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, string keyArg, float locationArg, string modifiersListArg, bool repeat, string locale)
    {
        throw new System.NotImplementedException();
    }
}
