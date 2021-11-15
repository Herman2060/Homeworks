using System;

namespace Task1._1.Furniture
{
    public abstract class Furniture : IGeometryObject
    {
        public string _name;
        private float _width;
        private float _length;

        public Furniture(string name)
        {
            _name = name;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        public float Width {
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
                else
                {
                    Console.WriteLine("Need natural number");
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
                else
                {
                    Console.WriteLine("Need natural number");
                }
            }
        }
        

        public float Square()
        {
            return _width * _length;
        }

        public abstract void Move();
    }
}