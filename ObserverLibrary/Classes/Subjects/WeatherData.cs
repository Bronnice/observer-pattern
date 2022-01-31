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

        void MeasurementsChanged()
        {
            NotifyObserver();
        }

        readonly Data data = new Data();

        public float CurrentTemperature
        {
            get { return data.currentTemp; }
            set { data.currentTemp = value; MeasurementsChanged(); data.StatisticTemp(value); }
        }
        public int CurrentHumidity
        {
            get { return data.currentHumidity; }
            set { data.currentHumidity = value; MeasurementsChanged(); data.StatisticHumidity(value); }
        }
        public int CurrentPressure
        {
            get { return data.currentPressure; }
            set { data.currentPressure = value; MeasurementsChanged(); data.StatisticPressure(value); }
        }


        readonly Random random = new Random();
        public float ForecastTemperature
        {
            get { return data.tempForecast; }
            set { data.tempForecast = random.Next(10, 25); MeasurementsChanged(); }
        }
        public int ForecastHumidity
        {
            get { return data.humidityForecast; }
            set { data.humidityForecast = random.Next(40, 60); MeasurementsChanged(); }
        }
        public int ForecastPressure
        {
            get { return data.pressureForecast; }
            set { data.pressureForecast = random.Next(740, 755); MeasurementsChanged(); }
        }
    }
}
