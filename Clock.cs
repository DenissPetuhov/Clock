using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ClockCheker
{

    internal class Clock
    {
        Timer timer = new Timer()
        {
            Interval = 1000,
            Enabled = true
        };
        private TimeSpan timeNow = DateTime.Now.TimeOfDay;
        public delegate void TimeHAndler();
        public event TimeHAndler SeconTick;
        public Dictionary<string, TimeSpan> Cities = new Dictionary<string, TimeSpan>
        {
             {"Москва",new TimeSpan(0,0,0)},
             {"Лондон",new TimeSpan(22,0,0)},
             {"Владивосток", new TimeSpan(7,0,0)},
             {"Калининград", new TimeSpan(1,0,0)}
        };

        public Clock()
        {
            timer.Tick += Tick;
        }

        private void Tick(object sender, EventArgs e)
        {
            timeNow = DateTime.Now.TimeOfDay;
            SeconTick();
        }

        public TimeSpan GetTimeCityNow(string NameCity)
        {
            TimeSpan CityTime = timeNow + Cities[NameCity];
            return CityTime;

        }
        public void AddCity(String NameSity, TimeSpan offsetTime)
        {
            Cities.Add(NameSity, offsetTime);

        }
        public void StopTimer() => timer.Stop();

        public void StartTimer() => timer.Start();

        public List<string> GetCityNamesList()
        {
            List<string> CityNames = Cities.Keys.ToList();
            return CityNames;
        }


    }

}
