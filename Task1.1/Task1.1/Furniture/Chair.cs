using System;

namespace Task1._1.Furniture
{
    public class Chair : Furniture, IMovable
    {
        public Chair (string name) : base (name) { }
        
        public override void Move()
        {
            Console.WriteLine("Chair moved");
        }
    }
}