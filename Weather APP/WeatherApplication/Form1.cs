using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;


namespace WeatherApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String APIKey = "47e59a0d56baadad6ce8d2a65da73c3d";



        private void search_Click(object sender, EventArgs e)
        {
            getweather();
            getforecast();
        }

        double lat;
        double lon;
        void getweather()
        {
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",TBCity.Text,APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                picIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";

                labCond.Text = Info.weather[0].main;
                labdescrip.Text=Info.weather[0].description;
                labSunrise.Text =convertDateTime(Info.sys.sunrise).ToShortTimeString();
                labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();

                labwindspeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();
                lat = Info.coord.lat;
                lon = Info.coord.lon;
               

            }
        }
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day=day.AddSeconds(sec).ToLocalTime();

            return day;
        }

        void getforecast()
        {
            using (WebClient web = new WebClient())
            {

                string url2 = string.Format("https://pro.openweathermap.org/data/2.5/forecast/daily?lat={0}&lon={1}&cnt=8&appid={2}",lat,lon,APIKey);
                var json = web.DownloadString(url2);
                WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);
                Forecastuc FUC;

                for(int i=0;i<8;i++)
                {
                    FUC = new Forecastuc();

                    FUC.picWeatherIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + ForecastInfo.list[i].weather[0].icon + ".png";
                    FUC.labWeatherCondition.Text = ForecastInfo.list[i].weather[0].main;
                    FUC.labelDescription.Text = ForecastInfo.list[i].weather[0].description;
                    FUC.labeldt.Text = convertDateTime(ForecastInfo.list[i].dt).DayOfWeek.ToString();

                    FLP.Controls.Add(FUC);


                
                }



            }
        }

    }
}
