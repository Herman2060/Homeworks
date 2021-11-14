using System;

namespace Task1._1.Furniture
{
    public class Furniture : GeometryObject
    {
        public string _name;
        protected string _material;

        public Furniture(string name)
        {
            _name = name;
        }
        
        public string Material
        {
            get
            {
                return _material;
            }
            set
            {
                _material = value;
            }
        }
        
    }
}