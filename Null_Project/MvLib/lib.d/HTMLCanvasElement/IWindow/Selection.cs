public class Selection
{
    protected Selection()
    {

    }
    public Node anchorNode;
    public float anchorOffset;
    public Node focusNode;
    public float focusOffset;
    public bool isCollapsed;
    public float rangeCount;
    public string type;
    public void addRange(Range range)
    {
        throw new System.NotImplementedException();
    }
    public void collapse(Node parentNode, float offset)
    {
        throw new System.NotImplementedException();
    }
    public void collapseToEnd()
    {
        throw new System.NotImplementedException();
    }
    public void collapseToStart()
    {
        throw new System.NotImplementedException();
    }
    public bool containsNode(Node node, bool partlyContained)
    {
        throw new System.NotImplementedException();
    }
    public void deleteFromDocument()
    {
        throw new System.NotImplementedException();
    }
    public void empty()
    {
        throw new System.NotImplementedException();
    }
    public void extend(Node newNode, float offset)
    {
        throw new System.NotImplementedException();
    }
    public Range getRangeAt(float index)
    {
        throw new System.NotImplementedException();
    }
    public void removeAllRanges()
    {
        throw new System.NotImplementedException();
    }
    public void removeRange(Range range)
    {
        throw new System.NotImplementedException();
    }
    public void selectAllChildren(Node parentNode)
    {
        throw new System.NotImplementedException();
    }
    public void setBaseAndExtent(Node baseNode, float baseOffset, Node extentNode, float extentOffset)
    {
        throw new System.NotImplementedException();
    }
    public string toString()
    {
        throw new System.NotImplementedException();
    }
}
