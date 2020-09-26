using System;

namespace Observer
{
    public class TemperatureReporter : IObserver
    //Observador
    {
        private bool first;
        private Temperature last;
        
        public void StartReporting()
        {          
            this.first = true;           
        }

        public void StopReporting()
        {
            
        }

        public void Update(ITemperatureSensor temperatureSensor)
        {
            Console.WriteLine($"The temperature is {(temperatureSensor as TemperatureSensor).Current.Degrees}°C at {(temperatureSensor as TemperatureSensor).Current.Date:g}");
            if (first)
            {
                last = (temperatureSensor as TemperatureSensor).Current;
                first = false;
            }
            else
            {
                Console.WriteLine($"   Change: {(temperatureSensor as TemperatureSensor).Current.Degrees - last.Degrees}° in " +
                    $"{(temperatureSensor as TemperatureSensor).Current.Date.ToUniversalTime() - last.Date.ToUniversalTime():g}");
            }
        }
    }
}