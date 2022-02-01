﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        double temperature;
        double humidity;
        double pressure;
        public string Display()
        {
            return "Прогноз погоды:\n" + "Температура: " + temperature + "\nВлажность: " + humidity + "\nДавление: " + pressure;
        }

        public void Update(Data data)
        {
            temperature = data.tempForecast;
            humidity = data.humidityForecast;
            pressure = data.pressureForecast;
        }
    }
}
