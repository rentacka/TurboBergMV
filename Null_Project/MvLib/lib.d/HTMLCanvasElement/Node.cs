using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Node : EventTarget
{
    protected Node() : base()
    {

    }
    public NamedNodeMap attributes;
    public string baseURI;
    public NodeList childNodes;
    public Node firstChild;
    public Node lastChild;
    public string localName;
    public string namespaceURI;
    public Node nextSibling;
    public string nodeName;
    public float nodeType;
    public string nodeValue;
    public Document ownerDocument;
    public HTMLElement parentElement;
    public Node parentNode;
    public Node previousSibling;
    public string textContent;
    public float ATTRIBUTE_NODE;
    public float CDATA_SECTION_NODE;
    public float COMMENT_NODE;
    public float DOCUMENT_FRAGMENT_NODE;
    public float DOCUMENT_NODE;
    public float DOCUMENT_POSITION_CONTAINED_BY;
    public float DOCUMENT_POSITION_CONTAINS;
    public float DOCUMENT_POSITION_DISCONNECTED;
    public float DOCUMENT_POSITION_FOLLOWING;
    public float DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC;
    public float DOCUMENT_POSITION_PRECEDING;
    public float DOCUMENT_TYPE_NODE;
    public float ELEMENT_NODE;
    public float ENTITY_NODE;
    public float ENTITY_REFERENCE_NODE;
    public float NOTATION_NODE;
    public float PROCESSING_INSTRUCTION_NODE;
    public float TEXT_NODE;
    public Node appendChild(Node newChild)
    {
        throw new System.NotImplementedException();
    }
    public Node cloneNode(bool deep = default(bool))
    {
        throw new System.NotImplementedException();
    }
    public float compareDocumentPosition(Node other)
    {
        throw new System.NotImplementedException();
    }
    public bool contains(Node child)
    {
        throw new System.NotImplementedException();
    }
    public bool hasAttributes()
    {
        throw new System.NotImplementedException();
    }
    public bool hasChildNodes()
    {
        throw new System.NotImplementedException();
    }
    public Node insertBefore(Node newChild, Node @refChild)
    {
        throw new System.NotImplementedException();
    }
    public bool isDefaultNamespace(string namespaceURI)
    {
        throw new System.NotImplementedException();
    }
    public bool isEqualNode(Node arg)
    {
        throw new System.NotImplementedException();
    }
    public bool isSameNode(Node other)
    {
        throw new System.NotImplementedException();
    }
    public string lookupNamespaceURI(string prefix)
    {
        throw new System.NotImplementedException();
    }
    public string lookupPrefix(string namespaceURI)
    {
        throw new System.NotImplementedException();
    }
    public void normalize()
    {
        throw new System.NotImplementedException();
    }
    public Node removeChild(Node oldChild)
    {
        throw new System.NotImplementedException();
    }
    public Node replaceChild(Node newChild, Node oldChild)
    {
        throw new System.NotImplementedException();
    }
}

