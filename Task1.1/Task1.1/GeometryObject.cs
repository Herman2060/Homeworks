namespace Task1._1
{
    public class GeometryObject
    {
        protected float _width;
        protected float _length;
        protected float _heigth;

        public float Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }
        
        public float Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
            }
        }
        
        public float Height
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _heigth = value;
                }
            }
        }
        
        public float Square()
        {
            return _width * _length;
        }

        public float Volume()
        {
            return _heigth * _length * _width;
        }
    }
}