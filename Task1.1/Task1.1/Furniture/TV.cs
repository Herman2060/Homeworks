using System;

namespace Task1._1.Furniture
{
    public class TV : Furniture, IMovable
    {
        private bool _iswork;

        public TV (string name) : base (name)
        {
            _iswork = false;
        }



        public bool IsWork
        {
            get
            {
                return _iswork;
            }
            set
            {
                if (value && _iswork)
                {
                    Console.WriteLine("TV is already ON");
                }
                else if (!_iswork && !value)
                {
                    Console.WriteLine("TV is already OFF");
                }
                else
                {
                    _iswork = value;
                    Console.WriteLine("TV is {0}", value ? "ON" : "OFF");
                }
            }
        }

        public override void Move()
        {
            if (_iswork)
            {
                Console.WriteLine("Turn off TV before move");
            }
            else
            {
                Console.WriteLine("TV moved");
            }
        }
    }
}