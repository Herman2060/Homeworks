using System;

namespace Task1._1.Furniture
{
    public class Wardrobe : Furniture, IMovable
    {
        
        public Wardrobe (string name) : base (name)
        {
            _name = name;
        }
        
        public void Move()
        {
            Console.WriteLine("Wardrobe moved");
        }
    }
}