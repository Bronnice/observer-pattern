using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public interface Subject
    {
        void RegisterObserver(ConcreteObserver item);
        void RemoveObserver(ConcreteObserver item);
        void NotifyObserver();


    }
}
