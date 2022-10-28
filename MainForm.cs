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
        List<string> CityesNamesList;
        TimeSpan SlectNewTime;
        private string CityName;
     
        public MainForm()
        {
            InitializeComponent();
            
            CityesNamesList = clock.GetCityNamesList();
            UpdateComboBoxItem();
            clock.SeconTick += SetTimeTick;

        }
        private void SetTimeTick()
        {
            CityesNamesList = clock.GetCityNamesList();
            if(cb_CityList.Items.Count != CityesNamesList.Count)
            {
                UpdateComboBoxItem();
            }
            TimeSpan time =clock.GetTimeCityNow(CityName);
            SetLableTime(time);
        }

        private void UpdateComboBoxItem()
        {
            cb_CityList.DataBindings.Clear();
            cb_CityList.DataSource = CityesNamesList;
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
            SetVisibleTrueFoNewElem();

        }

        private void cb_SetHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            SlectNewTime = new TimeSpan(Convert.ToInt32(cb_SetHours.SelectedItem), 0, 0);
        }

        private void btn_Complet_Click(object sender, EventArgs e)
        {
            if (tb_CityName.Text == "")
            {
                MessageBox.Show("Ведите город");

            }
            else
           if (SlectNewTime == null)
            {
                MessageBox.Show("Выберте час");

            }
            else
            {
                clock.AddCity(tb_CityName.Text, SlectNewTime);
                SetVisibleFalseFoNewElem();
            }
        }
        private void SetVisibleTrueFoNewElem()
        {
            tb_CityName.Visible = true;
            cb_SetHours.Visible = true;
            lab_enterCity.Visible = true;
            lab_enterTime.Visible = true;
            lab_Hours.Visible = true;
            btn_Complet.Visible = true;
            this.Height = 440;
        }
        private void SetVisibleFalseFoNewElem()
        {
            tb_CityName.Visible = false;
            cb_SetHours.Visible = false;
            lab_enterCity.Visible = false;
            lab_enterTime.Visible = false;
            lab_Hours.Visible = false;
            btn_Complet.Visible = false;
            this.Height = 290;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Height = 290;
        }
    }
}
