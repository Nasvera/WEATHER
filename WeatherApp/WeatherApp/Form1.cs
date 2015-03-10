using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Web;
using System.speech.Recognition;
using System.speech.Synthesis;



namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        
        }

        private void getWeather()
        {
            string query = String.Format("http://api.openweathermap.org/data/2.5/weather?q=Accra,Ghana");
            XmlDocument wData = new XmlDocument();
            wData.Load(query);



            XmlNamespaceManager manager = new XmlNamespaceManager(wData.NameTable);
            manager.AddNamespace("yweather","http://xml.weather.yahoo.com/ns/css/1.0");
            XmlNode channel = wData.SelectSingleNode("rss").SelectSingleNode("Channel");
            XmlNodeList nodes = wData.SelectNodes("/rss/channel/items/yweather/");



        }

    }
}
