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
    public partial class AddCityForm : Form
    {
        private TimeSpan time;
        Clock clock = new Clock();
        MainForm mainForm = new MainForm();
        public AddCityForm()
        {
            InitializeComponent();
        }



        private void btn_Complet_Click(object sender, EventArgs e)
        {
            if(tb_CityName.Text == "")
            {
                MessageBox.Show("Ведите город");
            }else
            if(time == null)
            {
                MessageBox.Show("Выберте час");
            }
            else
            {
                MessageBox.Show("Город добалвен");
                clock.AddCity(tb_CityName.Text, time);
                mainForm.Show();
                this.Close();
            }
          

        }

        private void cb_SetHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            time = new TimeSpan(Convert.ToInt32(cb_SetHours.SelectedValue), 0,0) ;
        }

      
    }
}
