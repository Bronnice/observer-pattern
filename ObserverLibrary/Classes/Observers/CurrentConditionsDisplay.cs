using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        float temperature;
        int humidity;
        int pressure;

        public string Display()
        {
            return "Температура: " + temperature + "\nВлажность: " + humidity + "\nДавление: " + pressure; ;
        }

        public void Update(Data data)
        {
            temperature = data.currentTemp;
            humidity = data.currentHumidity;
            pressure = data.currentPressure;
        }
    }
}
