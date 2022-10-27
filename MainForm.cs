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
        Clock clock = new Clock();
        List<string> CityNamesList ;
        private string CityName;
     
        public MainForm()
        {
            InitializeComponent();
            CityNamesList = clock.GetCityNamesList();   
            cb_CityList.DataSource = CityNamesList;
            clock.SeconTick += SetTimeTick;

        }
        private void SetTimeTick()
        {
          //  CityNamesList = clock.GetCityNamesList();
            TimeSpan time =clock.GetTimeCityNow(CityName);
            SetLableTime(time);
        }

        public void SetLableTime(TimeSpan time) {
            LargeTime.Text = time.Hours.ToString() + ":" + time.Minutes.ToString() + ":" + time.Seconds.ToString();
        }
 
        private void btnStopTimer_click(object sender, EventArgs e) => clock.StopTimer();

        private void btnStartTimer_Click(object sender, EventArgs e) => clock.StartTimer();

        private void cb_CityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityName = cb_CityList.SelectedItem.ToString();
        }

        private void btn_AddCity_Click(object sender, EventArgs e)
        {
            AddCityForm form = new AddCityForm();
            form.Show();
            this.Hide();
        }
    }
}
