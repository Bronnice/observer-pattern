using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class ConcreteSubject : Subject
    {
        List<Observer> observers = new List<Observer> { };

        public void NotifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update();
            }
        }

        public void RegisterObserver(Observer item)
        {
            observers.Add(item);
        }

        public void RemoveObserver(Observer item)
        {
            observers.Remove(item);
        }

        int state;
        public int State
        {
            get { return state; }
            set { state = value; this.NotifyObserver(); }
        }
    }
}
