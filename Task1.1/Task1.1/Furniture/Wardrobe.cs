using System;

namespace Task1._1.Furniture
{
    public class Wardrobe : Furniture, IMovable
    {
        
        public Wardrobe (string name) : base (name){ }
        
        public override void Move()
        {
            Console.WriteLine("Wardrobe moved");
        }
    }
}