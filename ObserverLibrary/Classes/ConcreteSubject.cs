using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class ConcreteSubject : Subject
    {
        List<ConcreteObserver> observers = new List<ConcreteObserver> { };

        public void NotifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update();
            }
        }

        public void RegisterObserver(ConcreteObserver item)
        {
            observers.Add(item);
        }

        public void RemoveObserver(ConcreteObserver item)
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
