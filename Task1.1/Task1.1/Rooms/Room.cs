using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1._1.Rooms
{
    public abstract class Room : IGeometryObject
    {
        private string _name;
        private float _square;
        private float _width;
        private float _length;
        static float _squareSum = 0;
        private bool _enoughSpace;
        private List <IGeometryObject> _furnitures;

        public Room(int square = 25)
        {
            _square = square;
            _furnitures = new List<IGeometryObject>();
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        public float Width 
        {
            get => _width;
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("Ты дурак, что ли?");
                }
            } 
        }

        public float Length
        {
            get => _length;
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    Console.WriteLine("Ты дурак, что ли?");
                }
            } 
        }

        private bool IsEnoughSpace()
        {
            return _enoughSpace = _square > _squareSum ? true : false;
        }

        public void OccupiedPlace()
        {
            _squareSum += _furnitures[_furnitures.Count-1].Square();

            Console.WriteLine($"Capacity: {_squareSum} of {_square}");
        }

        public void AddFurniture(IGeometryObject geometryObject)
        {
            if (IsEnoughSpace())
            {
                _furnitures.Add(geometryObject);
            }
            else
            {
                Console.WriteLine("Not enough place");
            }
        }

        public void FurnitureArrangement()
        {
            for (int i = 0; i < _furnitures.Count; i++)
            {
                Console.WriteLine($"{i}. {_furnitures[i].Name}");       
            }
        }

        public void MixFurniture()
        {
            Random r = new Random();
            _furnitures = _furnitures.OrderBy(x=>r.Next()).ToList();
        }

        public float Square()
        {
            return _length * _width;
        }
    }
}