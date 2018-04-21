using System;

namespace PIXI
{
    public class BaseTexture// : utils.EventEmitter
    {
        public BaseTexture(object source = default(object), float scaleMode = default(float), float resolution = default(float)) : base()
        {

        }
        protected BaseTexture() : base()
        {

        }
        public float uuid;
        public float touched;
        public float resolution;
        public float width;
        public float height;
        public float realWidth;
        public float realHeight;
        public float scaleMode;
        public bool hasLoaded;
        public bool isLoading;
        public float wrapMode;
        public object source;
        public HTMLImageElement origSource;
        public string imageType;
        public float sourceScale;
        public bool premultipliedAlpha;
        public string imageUrl;
        public bool isPowerOfTwo;
        public bool mipmap;
        public bool wrap;
        public object _glTextures;
        public float _enabled;
        public float _id;
        public Func<BaseTexture, object> fn;
        public object context;
        public static BaseTexture from(object source, float scaleMode = default(float), float sourceScale = default(float))
        {
            throw new System.NotImplementedException();
        }
        public void update()
        {
            throw new System.NotImplementedException();
        }
        public void _updateDimensions()
        {
            throw new System.NotImplementedException();
        }
        public void _updateImageType()
        {
            throw new System.NotImplementedException();
        }
        public void _loadSvgSource()
        {
            throw new System.NotImplementedException();
        }
        public void _loadSvgSourceUsingDataUri(string dataUri)
        {
            throw new System.NotImplementedException();
        }
        public void _loadSvgSourceUsingXhr()
        {
            throw new System.NotImplementedException();
        }
        public void _loadSvgSourceUsingString(string svgString)
        {
            throw new System.NotImplementedException();
        }
        public void loadSource(object source)
        {
            throw new System.NotImplementedException();
        }
        public void _sourceLoaded()
        {
            throw new System.NotImplementedException();
        }
        public void destroy()
        {
            throw new System.NotImplementedException();
        }
        public void dispose()
        {
            throw new System.NotImplementedException();
        }
        public void updateSourceImage(string newSrc)
        {
            throw new System.NotImplementedException();
        }
        public static BaseTexture fromImage(string imageUrl, bool crossorigin = default(bool), float scaleMode = default(float), float sourceScale = default(float))
        {
            throw new System.NotImplementedException();
        }
        public static BaseTexture fromCanvas(HTMLCanvasElement canvas, float scaleMode = default(float))
        {
            throw new System.NotImplementedException();
        }
        public object on(object @event)
        {
            throw new System.NotImplementedException();
        }
        public object On(string @event, Function fn, object context = default(object))
        {
            throw new System.NotImplementedException();
        }
        public object Once(object @event)
        {
            throw new System.NotImplementedException();
        }
        public object once(string @event, Function fn, object context = default(object))
        {
            throw new System.NotImplementedException();
        }
        public object off(string @event, Function fn, object context = default(object))
        {
            throw new System.NotImplementedException();
        }
    }

}