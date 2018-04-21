using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EventTarget
{
    protected EventTarget()
    {

    }
    public void addEventListener(string type, object listener, bool useCapture = default(bool))
    {
        throw new System.NotImplementedException();
    }
    public bool dispatchEvent(Event evt)
    {
        throw new System.NotImplementedException();
    }
    public void removeEventListener(string type, object listener, bool useCapture = default(bool))
    {
        throw new System.NotImplementedException();
    }
}