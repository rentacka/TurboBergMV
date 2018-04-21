using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeListOf<TNode> : NodeList where TNode : Node
{
    protected NodeListOf() : base()
    {

    }
    public float length;
    public float index;
    public TNode item(float index)
    {
        throw new System.NotImplementedException();
    }
}

