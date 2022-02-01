using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        double temperature;
        double humidity;
        double pressure;

        public string Display()
        {
            return "Текущая погода:"+"\nТемпература: " + temperature + "\nВлажность: " + humidity + "\nДавление: " + pressure; ;
        }

        public void Update(Data data)
        {
            temperature = data.currentTemp;
            humidity = data.currentHumidity;
            pressure = data.currentPressure;
        }
    }
}
