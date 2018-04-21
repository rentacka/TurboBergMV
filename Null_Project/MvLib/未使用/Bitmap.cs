using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvLib
{
    public class Bitmap
    {
        public Bitmap(float width = default(float), float height = default(float))
        {

        }
        protected Bitmap()
        {

        }

        public string url;
        //public PIXI.BaseTexture baseTexture;
        //public HTMLCanvasElement canvas;
        //public CanvasRenderingContext2D context;
        public float width;
        public float height;
        public Rectangle rect;
        public bool smooth;
        public float paintOpacity;
        //public CacheEntry cacheEntry;
        public string fontFace;
        public float fontSize;
        public bool fontItalic;
        public string textColor;
        public string outlineColor;
        public float outlineWidth;

        public static Bitmap load(string url)
        {
            return null;
        }

        //public static Bitmap snap(Stage stage)
        //{
        //    return null;
        //}

        public static Bitmap request(string url)
        {
            return null;
        }
        public void initialize(float width = default(float), float height = default(float))
        {
        }
        public bool isReady()
        {
            return false;
        }
        public bool isError()
        {
            return false;
        }
        public void touch()
        {
        }
        public void resize(float width, float height)
        {
        }
        public void blt(Bitmap source, float sx, float sy, float sw, float sh, float dx, float dy, float dw = default(float), float dh = default(float))
        {
        }
        public void bltImage(Bitmap source, float sx, float sy, float sw, float sh, float dx, float dy, float dw = default(float), float dh = default(float))
        {
        }
        public string getPixel(float x, float y)
        {
            return null;
        }
        public string getAlphaPixel(float x, float y)
        {
            return null;
        }
        public void clearRect(float x, float y, float width, float height)
        {
        }
        public void clear()
        {
        }
        public void fillRect(float x, float y, float width, float height, String color)
        {
        }
        public void fillAll(string color)
        {
        }
        public void gradientFillRect(float x, float y, float width, float height, String color1, string color2, bool vertical)
        {
        }
        public void drawCircle(float x, float y, float radius, string color)
        {
        }
        public void drawText(string text, float x, float y, float maxWidth = default(float), float lineHeight = default(float), string align = default(string))
        {
        }
        public float measureTextWidth(string text)
        {
            return 0;
        }
        public void adjustTone(float r, float g, float b)
        {
        }
        public void rotateHue(float offset)
        {
        }
        public void blur()
        {
        }

        //public void addLoadListener(Function listener)
        //{
        //}

        public void checkDirty()
        {
        }
        public bool isRequestOnly()
        {
            return false;
        }
        public bool isRequestReady()
        {
            return false;
        }
        public void startRequest()
        {
        }
    }

}
