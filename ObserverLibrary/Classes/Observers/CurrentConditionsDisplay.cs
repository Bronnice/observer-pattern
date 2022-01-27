using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        float currenttemperature;
        int currenthumidity;
        int currentpressure;

        public string Display()
        {
            return "Температура: " + currenttemperature + "\nВлажность: " + currenthumidity + "\nДавление: " + currentpressure; ;
        }

        public void Update(float newtemperature, int newhumidity, int newpressure)
        {
            currenttemperature = newtemperature;
            currenthumidity = newhumidity;
            currentpressure = newpressure;
        }
    }
}
