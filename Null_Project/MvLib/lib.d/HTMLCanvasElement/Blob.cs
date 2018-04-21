using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Blob
{
    protected Blob()
    {

    }
    public float size;
    public string type;
    public void msClose()
    {
        throw new System.NotImplementedException();
    }
    public object msDetachStream()
    {
        throw new System.NotImplementedException();
    }
    public Blob slice(float start = default(float), float end = default(float), string contentType = default(string))
    {
        throw new System.NotImplementedException();
    }
}

