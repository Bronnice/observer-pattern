using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverLibrary;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();
            
            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay();
            ForecastDisplay fd = new ForecastDisplay();
            StatisticsDisplay sd = new StatisticsDisplay();

            ///Регистрация наблюдателей
            wd.RegisterObserver(ccd);
            wd.RegisterObserver(fd);
            wd.RegisterObserver(sd);

            ///Случайное заполнение текущих температуры, давления, влажности
            Random rnd = new Random();
            for (int i = 0; i < 24; i++)
            {
                wd.CurrentHumidity = rnd.Next(40, 60);
                wd.CurrentPressure = rnd.Next(740, 755);
                wd.CurrentTemperature = rnd.Next(100, 250) / 10.0;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ccd.Display());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(fd.Display());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(sd.Display());

            wd.RemoveObserver(fd);

            Console.ReadKey();
        }
    }
}
