using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class WeatherData : ISubject
    {
        readonly List<IObserver> observers = new List<IObserver> { };

        public void NotifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update(temperature, humidity, pressure);
            }
        }
        public void RegisterObserver(IObserver item)
        {
            observers.Add(item);
        }
        public void RemoveObserver(IObserver item)
        {
            observers.Remove(item);
        }

        void MeasurementsChanged()
        {
            NotifyObserver();
        }


        float temperature;
        int humidity;
        int pressure;

        public float Temperature
        {
            get { return temperature; }
            set { temperature = value; MeasurementsChanged(); }
        }
        public int Humidity
        {
            get { return humidity; }
            set { humidity = value; MeasurementsChanged(); }
        }
        public int Pressure
        {
            get { return pressure; }
            set { pressure = value; MeasurementsChanged(); }
        }
    }
}
