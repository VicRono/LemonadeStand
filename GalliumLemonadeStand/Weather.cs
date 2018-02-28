using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalliumLemonadeStand
{
    class Weather
    {
        private string actualWeather;
        private string actualTemp;
        private string getForecast;
        private List<string> weather;

        public Weather()
        {
            weather = new List<string>();
            weather.Add("Cloudy");
            weather.Add("Sunny");
            weather.Add("Rainy");
            weather.Add("HOT!");
            weather.Add("Cloudy and Rainy");
        }
        Random rnd = new Random
        private int generateRandomNumber()
        {
            return Random.Next(weather.Count);
        }

        public string SetActualWeather(int random)
        {                                   
            actualWeather = weather[random];
            Console.WriteLine(weather[random]);            
        }
        public string SetActualTemp()
        {
            List<int> Temp = new List<int>();
            {

            }
        }
       

       
        
            
            
        }

        public getForecast()
            //actualweather&actualtemp
    }
}
