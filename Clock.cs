using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using System.Threading;
//using System.Windows.Forms;
//using Timer = System.Windows.Forms.Timer;

namespace ClockCheker
{

    internal class Clock
    {
        Timer timer = new Timer();

        public delegate void SecondTick();
        public event SecondTick TimeHendler;

        public TimeSpan timeNow  = DateTime.Now.TimeOfDay;

        public void Tick() => timeNow = DateTime.Now.TimeOfDay;

        public Dictionary<string, TimeSpan> Cities = new Dictionary<string, TimeSpan>{ 

           {"Москва",new TimeSpan(0,0,0)},
           {"Лондон",new TimeSpan(22,0,0)},
           {"Владивосток", new TimeSpan(7,0,0)} 
        };

        private void count()
        {
           
            timer.Start();
            if (timer.Interval == 1000)
            {
                TimeHendler += Tick;
            }
        }
        

        public Clock()
        {
            
            timer.Interval = 1000;
            count();


        }
      
    }

}
