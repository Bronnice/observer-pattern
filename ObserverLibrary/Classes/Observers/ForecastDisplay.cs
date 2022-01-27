using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.Classes.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        public string Display()
        {
            throw new NotImplementedException();
        }

        public void Update(float temperature, int humidity, int pressure)
        {
            throw new NotImplementedException();
        }
    }
}
