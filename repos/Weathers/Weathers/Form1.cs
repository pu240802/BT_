using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weathers
{
    public partial class Form1 : Form
    {
        const string APPID = "4891e470eaa5afd76611f0751907ce93";
        string cityID = "1566083";
        public Form1()
        {
            InitializeComponent();
            getWeather("1566083");
            getorcast("1566083");
        }
        void getWeather(string city)
        {
            string url = "";
            using (WebClient web =  new WebClient())
            {
                

                var json = web.DownloadString(url);

                

                

            }
        }
        void getorcast(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}&units=metric&cnt=6", cityID, APPID);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherInfo.root outPut = result;
                lbl_textCity.Text = string.Format("{0}", outPut.name);
                lbl_Country.Text = string.Format("{0}", outPut.sys.country);
                lbl_Dece.Text = string.Format("{0} \u00B0" + "C", outPut.main.temp);



            }

        }

        private void lbl_textCity_Click(object sender, EventArgs e)
        {

        }
    }
}
