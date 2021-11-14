using System;
using System.Collections.Generic;

namespace Task1._1.Rooms
{
    public class Room : GeometryObject
    {
        private float square;
        private bool _enoughSpace;
        private List <Furniture.Furniture> furnitures;

        public Room()
        {
            square = 25;
            furnitures = new List<Furniture.Furniture>();
        }
        
        public bool isEnoughSpace()
        {
            if (furnitures.Count == 0)
            {
                return true;
            }
            float squareSum = 0;
            foreach (var furniture in furnitures)
            {
                squareSum += furniture.Square();
            }

            if (square > squareSum)
            {
                _enoughSpace = true;
            }
            else
            {
                _enoughSpace = false;
            }

            return _enoughSpace;
        }

        public void AddFurniture(Furniture.Furniture furniture)
        {
            if (isEnoughSpace())
            {
                furnitures.Add(furniture);
            }
            else
            {
                Console.WriteLine("Not enough place");
            }
        }

        public void FurnitureArrangement()
        {
            for (int i = 0; i < furnitures.Count; i++)
            {
                Console.WriteLine($"{i}. {furnitures[i]._name}");       
            }
        }
        
        
        
    }
}