using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WebGLContextAttributes
{
    protected WebGLContextAttributes()
    {

    }
    public bool failIfMajorPerformanceCaveat;
    public bool alpha;
    public bool depth;
    public bool stencil;
    public bool antialias;
    public bool premultipliedAlpha;
    public bool preserveDrawingBuffer;
}