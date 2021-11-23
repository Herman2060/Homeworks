using System;
using Delegates_Events;

namespace TaskEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLights tr = new TrafficLights();
            Human human1 = new Human();
            
            tr.AddObserver(human1);
            tr.ChangeColor();
            tr.ChangeColor();
        }
    }
}