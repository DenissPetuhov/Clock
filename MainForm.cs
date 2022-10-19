using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockCheker
{
    public partial class MainForm : Form
    {
        public TimeSpan timenow = DateTime.Now.TimeOfDay;
    
       // Clock clock= new Clock();
        
        public MainForm()
        {

            InitializeComponent();
            mainTimer.Start();
          
        
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           // LargeTime.Text = clock.timeNow.ToString();
        }
        public void TimeCheked()
        {
            timenow = DateTime.Now.TimeOfDay;
        }




        Dictionary<string, TimeSpan> Cities = new Dictionary<string, TimeSpan>
        {
             {"Москва",new TimeSpan(0,0,0)},
             {"Лондон",new TimeSpan(22,0,0)},
             {"Владивосток", new TimeSpan(7,0,0)},
             {"Калининград", new TimeSpan(1,0,0) }
        };

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            TimeCheked();

            LargeTime.Text = Convert.ToString(timenow.Hours + ":" + timenow.Minutes + ":" + timenow.Seconds);

            TimeSpan vladivostoktime = timenow + Cities["Владивосток"];
            LableVladivostorTIme.Text = Convert.ToString(vladivostoktime.Hours + ":" + vladivostoktime.Minutes + ":" + vladivostoktime.Seconds);

            TimeSpan londonTime = timenow + Cities["Лондон"];
            lableLondonTime.Text = Convert.ToString((londonTime.Hours + ":" + londonTime.Minutes + ":" + londonTime.Seconds));

            TimeSpan Caliningrad  = timenow + Cities["Калининград"];
            CaliningradLable.Text = Convert.ToString((Caliningrad.Hours + ":" + Caliningrad.Minutes + ":" + Caliningrad.Seconds));


        }

        private void btnStopTImer_click(object sender, EventArgs e)
        {
            mainTimer.Stop();
        }

        private void btnStartTImer_Click(object sender, EventArgs e)
        {
            mainTimer.Start();
        }

     
    }
}
