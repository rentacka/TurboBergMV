using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CanvasRenderingContext2D
{
    protected CanvasRenderingContext2D() : base()
    {

    }
    public HTMLCanvasElement canvas;
    public object fillStyle;
    public string font;
    public float globalAlpha;
    public string globalCompositeOperation;
    public string lineCap;
    public float lineDashOffset;
    public string lineJoin;
    public float lineWidth;
    public float miterLimit;
    public string msFillRule;
    public bool msImageSmoothingEnabled;
    public float shadowBlur;
    public string shadowColor;
    public float shadowOffsetX;
    public float shadowOffsetY;
    public object strokeStyle;
    public string textAlign;
    public string textBaseline;
    public bool mozImageSmoothingEnabled;
    public bool webkitImageSmoothingEnabled;
    public bool oImageSmoothingEnabled;
    public void beginPath()
    {
        throw new System.NotImplementedException();
    }
    public void clearRect(float x, float y, float w, float h)
    {
        throw new System.NotImplementedException();
    }
    public void clip(string fillRule = default(string))
    {
        throw new System.NotImplementedException();
    }
    public ImageData createImageData(object imageDataOrSw, float sh = default(float))
    {
        throw new System.NotImplementedException();
    }
    public CanvasGradient createLinearGradient(float x0, float y0, float x1, float y1)
    {
        throw new System.NotImplementedException();
    }
    public CanvasPattern createPattern(object image, string repetition)
    {
        throw new System.NotImplementedException();
    }
    public CanvasGradient createRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1)
    {
        throw new System.NotImplementedException();
    }
    public void drawImage(object image, float offsetX, float offsetY, float width = default(float), float height = default(float), float canvasOffsetX = default(float), float canvasOffsetY = default(float), float canvasImageWidth = default(float), float canvasImageHeight = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void fill(string fillRule = default(string))
    {
        throw new System.NotImplementedException();
    }
    public void fillRect(float x, float y, float w, float h)
    {
        throw new System.NotImplementedException();
    }
    public void fillText(string text, float x, float y, float maxWidth = default(float))
    {
        throw new System.NotImplementedException();
    }
    public ImageData getImageData(float sx, float sy, float sw, float sh)
    {
        throw new System.NotImplementedException();
    }
    public float[] getLineDash()
    {
        throw new System.NotImplementedException();
    }
    public bool isPointInPath(float x, float y, string fillRule = default(string))
    {
        throw new System.NotImplementedException();
    }
    public TextMetrics measureText(string text)
    {
        throw new System.NotImplementedException();
    }
    public void putImageData(ImageData imagedata, float dx, float dy, float dirtyX = default(float), float dirtyY = default(float), float dirtyWidth = default(float), float dirtyHeight = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void restore()
    {
        throw new System.NotImplementedException();
    }
    public void rotate(float angle)
    {
        throw new System.NotImplementedException();
    }
    public void save()
    {
        throw new System.NotImplementedException();
    }
    public void scale(float x, float y)
    {
        throw new System.NotImplementedException();
    }
    public void setLineDash(float[] segments)
    {
        throw new System.NotImplementedException();
    }
    public void setTransform(float m11, float m12, float m21, float m22, float dx, float dy)
    {
        throw new System.NotImplementedException();
    }
    public void stroke()
    {
        throw new System.NotImplementedException();
    }
    public void strokeRect(float x, float y, float w, float h)
    {
        throw new System.NotImplementedException();
    }
    public void strokeText(string text, float x, float y, float maxWidth = default(float))
    {
        throw new System.NotImplementedException();
    }
    public void transform(float m11, float m12, float m21, float m22, float dx, float dy)
    {
        throw new System.NotImplementedException();
    }
    public void translate(float x, float y)
    {
        throw new System.NotImplementedException();
    }
}

