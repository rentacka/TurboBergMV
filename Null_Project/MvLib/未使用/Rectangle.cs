using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvLib
{
    public class Rectangle
    {
        public Rectangle(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
        {

        }
        protected Rectangle() : base()
        {

        }
        public static Rectangle emptyRectangle;

        public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
        {
        }
    }

}
