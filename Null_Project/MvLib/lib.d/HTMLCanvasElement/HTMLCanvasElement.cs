using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class HTMLCanvasElement : HTMLElement
{
    protected HTMLCanvasElement()// : base()
    {

    }
    public float height;
    public float width;
    public WebGLContextAttributes contextAttributes;
    public CanvasRenderingContext2D getContext(string contextId = "2d", Canvas2DContextAttributes contextAttributes = default(Canvas2DContextAttributes))
    {
        throw new System.NotImplementedException();
    }

    public IWebGLRenderingContext getContext(string contextId = "webgl | experimental-webgl", WebGLContextAttributes contextAttributes = default(WebGLContextAttributes))
    {
        throw new System.NotImplementedException();
    }

    public Blob msToBlob()
    {
        throw new System.NotImplementedException();
    }
    public string toDataURL(string type = default(string), params object[][] args)
    {
        throw new System.NotImplementedException();
    }

    public void toBlob(Action<Blob> callback, string type = default(string), params object[][] arguments)
    {
        throw new System.NotImplementedException();
    }
}

