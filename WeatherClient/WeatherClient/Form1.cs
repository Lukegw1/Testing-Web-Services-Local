using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeatherService.WeatherSvcClient weatherServiceClient = new WeatherService.WeatherSvcClient();
            //var temp = weatherServiceClient.GetCurrentTemp();
            var windSpeed = weatherServiceClient.GetWindSpeed();
            MessageBox.Show(windSpeed.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WeatherService.WeatherSvcClient weatherServiceClient = new WeatherService.WeatherSvcClient();
            weatherServiceClient.SendWindSpeed(34.2F);
        }

        private void btnArtistNumbers_Click(object sender, EventArgs e)
        {
            WeatherService.WeatherSvcClient weatherServiceClient = new WeatherService.WeatherSvcClient();
            int numberOfArtists = weatherServiceClient.GetNumberOfArtists();
            MessageBox.Show(numberOfArtists.ToString());
        }
    }
}
