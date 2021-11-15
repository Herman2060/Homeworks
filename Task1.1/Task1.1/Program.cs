using System;
using System.Collections.Generic;
using Task1._1.Furniture;
using Task1._1.Rooms;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table("table");
            Chair chair = new Chair("chair");
            Wardrobe wardrobe = new Wardrobe("Waardrobe");
            TV tv = new TV("TV");
            tv.IsWork = true;

            Bathroom bathroom = new Bathroom();

            bathroom.Name = "bathroom";

            LivingRoom livingRoom = new LivingRoom();

            livingRoom.Name = "Living Room";
            
            
        }
    }
}