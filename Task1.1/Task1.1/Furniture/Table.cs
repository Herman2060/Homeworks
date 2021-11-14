using System;

namespace Task1._1.Furniture
{
    public class Table : Furniture, IMovable
    {
        public Table (string name) : base (name)
        {
            _name = name;
        }
        
        public void Move()
        {
            Console.WriteLine("Table moved");
        }
    }
}