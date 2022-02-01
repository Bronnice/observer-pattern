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
                observers[i].Update(data);
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

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        Data data = new Data();

        public double CurrentTemperature
        {
            get { return data.currentTemp; }
            set { data.currentTemp = value; data.StatisticTemp(data.currentTemp); MeasurementsChanged(); }
        }
        public double CurrentHumidity
        {
            get { return data.currentHumidity; }
            set { data.currentHumidity = value; data.StatisticHumidity(data.currentHumidity); MeasurementsChanged(); }
        }
        public double CurrentPressure
        {
            get { return data.currentPressure; }
            set { data.currentPressure = value; data.StatisticPressure(data.currentPressure); MeasurementsChanged(); }
        }


        readonly Random random = new Random();
        public double ForecastTemperature
        {
            get { return data.tempForecast; }
            set { data.tempForecast = random.Next(10, 25); MeasurementsChanged(); }
        }
        public double ForecastHumidity
        {
            get { return data.humidityForecast; }
            set { data.humidityForecast = random.Next(40, 60); MeasurementsChanged(); }
        }
        public double ForecastPressure
        {
            get { return data.pressureForecast; }
            set { data.pressureForecast = random.Next(740, 755); MeasurementsChanged(); }
        }
    }
}
