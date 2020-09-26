using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor monitor = new TemperatureSensor();
            TemperatureReporter reporter = new TemperatureReporter();
            monitor.Subscribe(reporter); 
            reporter.StartReporting();
            monitor.GetTemperature();
        }
    }
}