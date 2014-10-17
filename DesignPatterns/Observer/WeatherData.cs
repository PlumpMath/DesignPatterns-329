using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DesignPatterns.Observer
{
    public class WeatherData : Subject
    {
        private List<Observer> Observers { get; set; }
        private float Temperature { get; set; }
        private float Pressure { get; set; }
        private float Humidity { get; set; }

        public WeatherData()
        {
            Observers = new List<Observer>();
        }

        public void RegisterObserver(Observer o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int indexOfObeserver = Observers.IndexOf(o);
            if (indexOfObeserver >= 0)
                Observers.RemoveAt(indexOfObeserver);
        }

        public void NotifyObservers()
        {
            foreach (Observer o in Observers)
                o.Update(Temperature,Humidity,Pressure);
        }

        public void MeasurementsUpdated()
        {
            NotifyObservers();
        }

        public void WeatherMeasurements(float Temp, float Press , float humid)
        {
            this.Temperature = Temp;
            this.Pressure = Press;
            this.Humidity = humid;
            MeasurementsUpdated();
        }
        public float GetCurrentTemperature()
        {
            return Temperature;
        }

        public float GetCurrentPressure()
        {
            return Pressure;
        }

        public float GetCurrentHumidity()
        {
            return Humidity;
        }
    }
}
