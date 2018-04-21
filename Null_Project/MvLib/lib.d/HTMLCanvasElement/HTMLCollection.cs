using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HTMLCollection
{
    protected HTMLCollection()
    {

    }
    public readonly int length;
		public float index;
    public Element item(float index)
    {
        throw new System.NotImplementedException();
    }
    public Element namedItem(string name)
    {
        throw new System.NotImplementedException();
    }
}
