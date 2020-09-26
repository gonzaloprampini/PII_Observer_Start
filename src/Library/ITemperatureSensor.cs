using System.Threading;
using System;
using System.Collections.Generic;

namespace Observer
{
    public interface ITemperatureSensor
    {      
        void Subscribe(IObserver observer);    
        void Unsubscribe(IObserver observer);          
        void GetTemperature();     
    } 
}


      