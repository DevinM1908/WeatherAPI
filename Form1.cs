using Newtonsoft.Json;
using System.Net;
using System.Security.Cryptography.X509Certificates;


namespace WeatherAPP
{
    public partial class Form1 : Form
    {
        String APIKey = "4f8bcc7e5ebb6576d705f7035f8ba37e";


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetWeather();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        public void GetWeather()
        {
            using (WebClient webClient = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textBox1.Text, APIKey);
                var json = webClient.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                ConditionLabel.Text = Info.weather[0].main;
                label3.Text = Info.weather[0].description;
                LabelSunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                LabelSunset.Text = convertDateTime(Info.sys.sunset).ToString();
                label7.Text = Info.wind.speed.ToString() + " km/h";
                label6.Text = Info.main.pressure.ToString() + " hPa";
                
                double TempInCel = Info.main.temp - 273.15;

                TempLabel.Text= Math.Round(TempInCel).ToString() + " Degrees Celcius";

            }

        }

        public DateTime convertDateTime (long millisec)
        {

            return DateTime.UnixEpoch.AddSeconds(millisec).ToLocalTime();

        }


        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }


}
