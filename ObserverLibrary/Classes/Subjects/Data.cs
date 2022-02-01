using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class Data
    {
        public double currentTemp;
        public double currentHumidity;
        public double currentPressure;

        public double tempForecast;
        public double humidityForecast;
        public double pressureForecast;

        public double minTemp;
        public double maxTemp;
        public double averageTemp;

        public double minHumidity;
        public double maxHumidity;
        public double averageHumidity;

        public double minPressure;
        public double maxPressure;
        public double averagePressure;


        readonly List<double> temperatures = new List<double> { };
        readonly List<double> humidities = new List<double> { };
        readonly List<double> pressures = new List<double> { };

        public void StatisticTemp(double currentTemp)
        {
            for (int i = 0; i < temperatures.Count; i++)
            {
                temperatures.Add(currentTemp);

                if (minTemp == double.NaN)
                {
                    minTemp = currentTemp;
                }

                else if (minTemp > currentTemp)
                {
                    minTemp = currentTemp;
                }

                if (maxTemp == double.NaN)
                {
                    maxTemp = currentTemp;
                }
                else if (maxTemp < currentTemp)
                {
                    maxTemp = currentTemp;
                }

                averageTemp = (minTemp + maxTemp) / 2;
            }
        }

        public void StatisticPressure(double currentPressure)
        {
            for (int i = 0; i < pressures.Count; i++)
            {
                pressures.Add(currentPressure);

                if (minPressure == double.NaN)
                {
                    minPressure = currentPressure;
                }

                else if (currentPressure < minPressure)
                {
                    minPressure = currentPressure;
                }

                if (maxPressure == double.NaN)
                {
                    maxPressure = currentPressure;
                }

                else if (currentPressure > maxPressure)
                {
                    maxPressure= currentPressure;
                }

                averagePressure = ((minPressure + maxPressure) / 2);

                
            }
        }

        public void StatisticHumidity(double currentHumidity)
        {
            for (int i = 0; i < humidities.Count; i++)
            {
                humidities.Add(currentHumidity);

                if (minHumidity == double.NaN)
                {
                    minHumidity = currentHumidity;
                }
                else if (currentHumidity < minHumidity)
                {
                    minHumidity = currentHumidity;
                }

                if (maxHumidity == double.NaN)
                {
                    maxHumidity = currentHumidity;
                }
                else if (currentHumidity > maxHumidity)
                {
                    maxHumidity = currentHumidity;
                }

                averageHumidity = (minHumidity + maxHumidity) / 2;
            }
        }
    }
}
