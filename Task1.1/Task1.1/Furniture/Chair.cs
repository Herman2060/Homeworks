using System;

namespace Task1._1.Furniture
{
    public class Chair : Furniture, IMovable
    {
        public Chair (string name) : base (name)
        {
            _name = name;
        }
        
        public void Move()
        {
            Console.WriteLine("Chair moved");
        }
    }
}