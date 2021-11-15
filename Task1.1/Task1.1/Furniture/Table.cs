using System;

namespace Task1._1.Furniture
{
    public class Table : Furniture, IMovable
    {
        public Table (string name) : base (name) { }
        
        public override void Move()
        {
            Console.WriteLine("Table moved");
        }
    }
}