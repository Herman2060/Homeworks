using System;
using System.Collections.Generic;
using TaskEvents;

namespace Delegates_Events
{
    public class TrafficLights : IObservable
        {
            public enum TrafficColors
            {
                Green,
                Red
            }

            private TrafficColors _currentColor = TrafficColors.Red;

            public TrafficColors Current
            {
                get => _currentColor;
            }

            private List<IObserver> _observers;
        
            public TrafficLights()
            {
                _observers = new List<IObserver>();
            }
            public void AddObserver(IObserver o)
            {
                _observers.Add(o);
            }
 
            public void RemoveObserver(IObserver o)
            {
                _observers.Remove(o);
            }
 
            public void NotifyObservers()
            {
                foreach (IObserver observer in _observers)
                    observer.Update(this);
            }

            public void ChangeColor()
            {
                if (_currentColor == TrafficColors.Red)
                {
                    _currentColor = TrafficColors.Green;
                }
                else
                {
                    _currentColor = TrafficColors.Red;
                }
                NotifyObservers();
            }
        }
}