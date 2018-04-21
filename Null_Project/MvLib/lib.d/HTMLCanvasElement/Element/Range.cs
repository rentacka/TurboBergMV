using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Range
{
    protected Range()
    {

    }
    public bool collapsed;
    public Node commonAncestorContainer;
    public Node endContainer;
    public float endOffset;
    public Node startContainer;
    public float startOffset;
    public float END_TO_END;
    public float END_TO_START;
    public float START_TO_END;
    public float START_TO_START;
    public DocumentFragment cloneContents()
    {
        throw new System.NotImplementedException();
    }
    public Range cloneRange()
    {
        throw new System.NotImplementedException();
    }
    public void collapse(bool toStart)
    {
        throw new System.NotImplementedException();
    }
    public float compareBoundaryPoints(float how, Range sourceRange)
    {
        throw new System.NotImplementedException();
    }
    public DocumentFragment createContextualFragment(string fragment)
    {
        throw new System.NotImplementedException();
    }
    public void deleteContents()
    {
        throw new System.NotImplementedException();
    }
    public void detach()
    {
        throw new System.NotImplementedException();
    }
    public bool expand(string Unit)
    {
        throw new System.NotImplementedException();
    }
    public DocumentFragment extractContents()
    {
        throw new System.NotImplementedException();
    }
    public ClientRect getBoundingClientRect()
    {
        throw new System.NotImplementedException();
    }
    public ClientRectList getClientRects()
    {
        throw new System.NotImplementedException();
    }
    public void insertNode(Node newNode)
    {
        throw new System.NotImplementedException();
    }
    public void selectNode(Node @refNode)
    {
        throw new System.NotImplementedException();
    }
    public void selectNodeContents(Node @refNode)
    {
        throw new System.NotImplementedException();
    }
    public void setEnd(Node @refNode, float offset)
    {
        throw new System.NotImplementedException();
    }
    public void setEndAfter(Node @refNode)
    {
        throw new System.NotImplementedException();
    }
    public void setEndBefore(Node @refNode)
    {
        throw new System.NotImplementedException();
    }
    public void setStart(Node @refNode, float offset)
    {
        throw new System.NotImplementedException();
    }
    public void setStartAfter(Node @refNode)
    {
        throw new System.NotImplementedException();
    }
    public void setStartBefore(Node @refNode)
    {
        throw new System.NotImplementedException();
    }
    public void surroundContents(Node newParent)
    {
        throw new System.NotImplementedException();
    }
    public string toString()
    {
        throw new System.NotImplementedException();
    }
}

