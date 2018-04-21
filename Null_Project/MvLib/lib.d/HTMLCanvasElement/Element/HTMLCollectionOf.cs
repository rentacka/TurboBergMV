using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HTMLCollectionOf<T> : HTMLCollection where T : Element
{
    protected HTMLCollectionOf() : base()
    {

    }
    public new float index;
    public new T item(float index)
    {
        throw new System.NotImplementedException();
    }
    public new T namedItem(string name)
    {
        throw new System.NotImplementedException();
    }
}

