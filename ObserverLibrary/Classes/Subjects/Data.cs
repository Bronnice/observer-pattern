using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class Data
    {
        public float currentTemp;
        public int currentHumidity;
        public int currentPressure;

        public float tempForecast;
        public int humidityForecast;
        public int pressureForecast;

        public float minTemp;
        public float maxTemp;
        public float averageTemp;

        public int minHumidity;
        public int maxHumidity;
        public int averageHumidity;

        public int minPressure;
        public int maxPressure;
        public int averagePressure;


        readonly List<float> temperatures = new List<float> { };
        readonly List<int> humidities = new List<int> { };
        readonly List<int> pressures = new List<int> { };

        public void StatisticTemp(float currentTemp)
        {
            for (int i = 0; i < temperatures.Count; i++)
            {
                temperatures.Add(currentTemp);
            }
        }

        public void StatisticPressure(int currentPressure)
        {
            for (int i = 0; i < pressures.Count; i++)
            {
                pressures.Add(currentPressure);
            }
        }

        public void StatisticHumidity(int currentHumidity)
        {
            for (int i = 0; i < humidities.Count; i++)
            {
                humidities.Add(currentHumidity);
            }
        }
    }
}
