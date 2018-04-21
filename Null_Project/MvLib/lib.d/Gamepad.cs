using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Gamepad
{
    protected Gamepad()
    {

    }
    public float[] axes;
    public GamepadButton[] buttons;
    public bool connected;
    public string id;
    public float index;
    public string mapping;
    public float timestamp;
}
