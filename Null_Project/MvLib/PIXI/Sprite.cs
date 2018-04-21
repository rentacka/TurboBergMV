namespace PIXI
{

    public class Sprite : Container
    {
        public Sprite(Texture texture = default(Texture)) : base()
        {

        }
        protected Sprite() : base()
        {

        }
        public ObservablePoint _anchor;
        public ObservablePoint anchor;
        public Texture _texture;
        public float _transformTrimmedID;
        public float _textureTrimmedID;
        public float _width;
        public float _height;
        public float tint;
        public float _tint;
        public float _tintRGB;
        public float blendMode;
        public string pluginName;
        public float cachedTint;
        public Texture texture;
        public bool textureDirty;
        public float _textureID;
        public float _transformID;
        public Float32Array vertexTrimmedData;
        public Float32Array vertexData;
        public float width;
        public float height;
        public void _onTextureUpdate()
        {
            throw new System.NotImplementedException();
        }
        public void calculateVertices()
        {
            throw new System.NotImplementedException();
        }
        public void _calculateBounds()
        {
            throw new System.NotImplementedException();
        }
        public void calculateTrimmedVertices()
        {
            throw new System.NotImplementedException();
        }
        public void onAnchorUpdate()
        {
            throw new System.NotImplementedException();
        }
        public void _renderWebGL(WebGLRenderer renderer)
        {
            throw new System.NotImplementedException();
        }
        public void _renderCanvas(CanvasRenderer renderer)
        {
            throw new System.NotImplementedException();
        }
        public Rectangle getLocalBounds()
        {
            throw new System.NotImplementedException();
        }
        public bool containsPoint(Point point)
        {
            throw new System.NotImplementedException();
        }
        public void destroy(object options = default(object))
        {
            throw new System.NotImplementedException();
        }
        public static Sprite from(object source)
        {
            throw new System.NotImplementedException();
        }
        public static Sprite fromFrame(string frameId)
        {
            throw new System.NotImplementedException();
        }
        public static Sprite fromImage(string imageId, bool crossorigin = default(bool), float scaleMode = default(float))
        {
            throw new System.NotImplementedException();
        }
    }

}