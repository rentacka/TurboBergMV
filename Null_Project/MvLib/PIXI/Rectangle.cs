namespace PIXI
{
    public class Rectangle
    {
        public Rectangle(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
        {

        }
        protected Rectangle()
        {

        }
        public float x;
        public float y;
        public float width;
        public float height;
        public float type;
        public float left;
        public float right;
        public float top;
        public float bottom;
        public static Rectangle EMPTY;
        public Rectangle clone()
        {
            throw new System.NotImplementedException();
        }
        public Rectangle copy(Rectangle rectangle)
        {
            throw new System.NotImplementedException();
        }
        public bool contains(float x, float y)
        {
            throw new System.NotImplementedException();
        }
        public void pad(float paddingX, float paddingY)
        {
            throw new System.NotImplementedException();
        }
        public void fit(Rectangle rectangle)
        {
            throw new System.NotImplementedException();
        }
        public void enlarge(Rectangle rectangle)
        {
            throw new System.NotImplementedException();
        }
    }

}