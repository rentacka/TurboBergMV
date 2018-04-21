using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class XMLHttpRequest : EventTarget//, XMLHttpRequestEventTarget
{
    protected XMLHttpRequest() : base()
    {

    }
    public Func<object, ProgressEvent, object> onreadystatechange;
    public float readyState;
    public object response;
    public string responseText;
    public string responseType;
    public object responseXML;
    public float status;
    public string statusText;
    public float timeout;
    public XMLHttpRequestUpload upload;
    public bool withCredentials;
    public string msCaching;
    public float DONE;
    public float HEADERS_RECEIVED;
    public float LOADING;
    public float OPENED;
    public float UNSENT;
    public Func<object, ProgressEvent, object> listener;
    public ProgressEvent ev;
    public bool useCapture;
    public void abort()
    {
        throw new System.NotImplementedException();
    }
    public string getAllResponseHeaders()
    {
        throw new System.NotImplementedException();
    }
    public string getResponseHeader(string header)
    {
        throw new System.NotImplementedException();
    }
    public bool msCachingEnabled()
    {
        throw new System.NotImplementedException();
    }
    public void open(string method, string url, bool async = default(bool), string user = default(string), string password = default(string))
    {
        throw new System.NotImplementedException();
    }
    public void overrideMimeType(string mime)
    {
        throw new System.NotImplementedException();
    }
    public void send(Document data = default(Document))
    {
        throw new System.NotImplementedException();
    }
    public void send(string data = default(string))
    {
        throw new System.NotImplementedException();
    }
    public void send(object data = default(object))
    {
        throw new System.NotImplementedException();
    }
    public void setRequestHeader(string header, string value)
    {
        throw new System.NotImplementedException();
    }
    public object addEventListener(object type)
    {
        throw new System.NotImplementedException();
    }
    public void addEventListener(string type, object listener, bool useCapture = default(bool))
    {
        throw new System.NotImplementedException();
    }
}

