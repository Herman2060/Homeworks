using System;
using TaskEvents;

namespace Delegates_Events
{
    public class Human : IMovable, IObserver
    {
        public void Move()
        {
            Console.WriteLine("Move");
        }

        public void Stay()
        {
            Console.WriteLine("Stay");
        }
        
        public void Update(IObservable subject)
        {
            if ((subject as TrafficLights).Current == TrafficLights.TrafficColors.Green)
            {
                Move();
            }
            else
            {
                Stay();
            }
        }
    }
}