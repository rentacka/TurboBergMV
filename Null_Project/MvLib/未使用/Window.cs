using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvLib
{
    public class Window
    {
        public Window() : base()
        {

        }

        public bool active;
        public Bitmap windowskin;
        public Bitmap contents;
        public float width;
        public float height;
        public float padding;
        public float margin;
        public float opacity;
        public float backOpacity;
        public float contentsOpacity;
        public float openness;
        public Point origin;
        public bool downArrowVisible;
        public bool upArrowVisible;
        public bool pause;
        public void initialize()
        {
        }
        public void update()
        {
        }
        public void move(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
        {
        }
        public bool isOpen()
        {
            return false;
        }
        public bool isClosed()
        {
            return false;
        }
        public void setCursorRect(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
        {
        }
        public void setTone(float r, float g, float b)
        {
        }
    }
}
