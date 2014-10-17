using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
   public class ForecastDisplay : Observer , DisplayElements
    {
        private float Temperature { get; set; }
        private float Pressure { get; set; }
        private float Humidity { get; set; }

        private WeatherData WeatherData { get; set; }

        public ForecastDisplay(WeatherData wd)
        {
            this.WeatherData = wd;
            WeatherData.RegisterObserver(this);
        }

        public void Update(float Temperature, float Humidity, float Pressure)
        {
            this.Temperature = Temperature;
            this.Humidity = Humidity;
            this.Pressure = Pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("This information is from the Forecaset Display :  \n Tempreature is :" + Temperature
                + "\n Pressure is  " + Pressure
                + "\n Humidity is " + Humidity);
        }
    }
}
