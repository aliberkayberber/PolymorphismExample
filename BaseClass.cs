namespace OOP
{
    public class BaseGeometrikSekil
    {
        private int _width;
        private int _height;

        public int Width
        {
            get{return _width;}
            set{_width = value;}
        }

        public int Height
        {
            get{return _height;}
            set{_height = value;}
        }
        public virtual int AlanHesaplama()
        {
            return Width * Height;
        }
    }
}