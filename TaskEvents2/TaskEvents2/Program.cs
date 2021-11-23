using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TaskEvents2
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalHuman human1 = new NormalHuman();
            NormalHuman human2 = new NormalHuman();
            NormalHuman human3 = new NormalHuman();
            NormalHuman human4 = new NormalHuman();
            IdiotHuman human5 = new IdiotHuman();

            Lights lights = new Lights();

            lights.AddHuman(human1);
            lights.AddHuman(human2);
            lights.AddHuman(human3);
            lights.AddHuman(human4);
            lights.AddHuman(human5);

            lights.NotifyHumans += human1.Check;
            lights.NotifyHumans += human2.Check;
            lights.NotifyHumans += human3.Check;
            lights.NotifyHumans += human4.Check;
            lights.NotifyHumans += human5.Check;

            lights.ChangeColors();
            lights.ChangeColors();
        }
    }

    public enum LightColors
    {
        Green,
        Red
    }
    
    class Human
    {
        
    }
    
    class NormalHuman : Human
    {
        public void Move()
        {
            Console.WriteLine("Move");
        }

        public void Wait()
        {
            Console.WriteLine("Wait");
        }

        public void Check(object lights, LightsEventArgs eventArgs)
        {
            if (eventArgs.Color == LightColors.Green)
            {
                Move();
            }
            else
            {
                Wait();
            }
        }
    }

    class IdiotHuman : Human
    {
        public void Move()
        {
            Console.WriteLine("Move");
        }
        
        public void Check(object lights, LightsEventArgs eventArgs)
        {
            Move();
        }
    }
    
    class Lights
    {
        LightColors _currentColor = LightColors.Red;

        // public LightColors TrafficColor
        // {
        //     get => _currentColor;
        // }
        
        public delegate void LigthsHandler(object sender, LightsEventArgs eventArgs);

        public event LigthsHandler NotifyHumans;
        
        private List<Human> _observers = new List<Human>();

        public void AddHuman(Human normalHuman)
        {
            if (normalHuman != null)
            {
                Console.WriteLine("Add new Human");
                _observers.Add(normalHuman);
            }
        }

        public void RemoveHuman(Human normalHuman)
        {
            if (normalHuman != null)
            {
                Console.WriteLine("Remove human");
                _observers.Remove(normalHuman);
            }
        }

        public void ChangeColors()
        {
            if (_currentColor == LightColors.Red)
            {
                _currentColor = LightColors.Green;
            }
            else
            {
                _currentColor = LightColors.Red;
            }
            NotifyHumans?.Invoke(this, new LightsEventArgs ("Colors changed", _currentColor));
        }

    }
    
    class LightsEventArgs
    {
        // Сообщение
        public string Message{get;}
        public LightColors Color {get;}
 
        public LightsEventArgs(string mes, LightColors color)
        {
            Message = mes; 
            Color = color;
        }
    }
    
}