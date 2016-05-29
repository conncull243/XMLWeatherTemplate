using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get information about current and forecast weather from the internet
            GetData();

            // take info from the current weather file and display it to the screen
            ExtractCurrent();

            // take info from the forecast weather file and display it to the screen
            ExtractForecast();
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            string currentFile = "http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            string forecastFile = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            client.DownloadFile(currentFile, "WeatherData.xml");
            client.DownloadFile(forecastFile, "WeatherData7Day.xml");
        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                // TODO if the "city" element is found display the value of it's "name" attribute
                if (child.Name == "city")
                {
                    cityOutput.Text = child.Attributes["name"].Value;
                }
                if (child.Name == "temperature")
                {
                    tempOutput.Text = child.Attributes["value"].Value;
                }
                if (child.Name == "wind")
                {
                    foreach (XmlNode grandchild in child.ChildNodes)
                    {
                        if (grandchild.Name == "speed")
                        {
                            windDescription.Text = grandchild.Attributes["name"].Value;
                        }
                    }
                }
            }
        }

        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            XmlNode parent;
            parent = doc.DocumentElement;
            int day = 1;

            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "forecast")
                {
                    foreach (XmlNode grandchild in child.ChildNodes)
                    {
                        foreach (XmlNode greatGrandchild in grandchild.ChildNodes)
                        {
                            if (greatGrandchild.Name == "symbol")
                            {
                                int number = Convert.ToInt32(greatGrandchild.Attributes["number"].Value);

                                if (number >= 500 && number < 800)
                                {
                                    pictureBox1.Image = Properties.Resources.Rain3;
                                }
                                if (number >= 800)
                                {
                                    pictureBox1.Image = Properties.Resources.cartoon_sun;
                                }
                                if (number < 500)
                                {
                                    pictureBox1.Image = Properties.Resources.cartoon_cloud;
                                }
                            }
                            if (greatGrandchild.Name == "temperature")
                            {
                                switch (day)
                                {
                                    case 1:
                                        maxOutput.Text = greatGrandchild.Attributes["max"].Value;
                                        minOutput.Text = greatGrandchild.Attributes["min"].Value;
                                        day++;
                                        break;
                                    case 2:
                                        max2Output.Text = greatGrandchild.Attributes["max"].Value;
                                        min2Output.Text = greatGrandchild.Attributes["min"].Value;
                                        day++;
                                        break;
                                    case 3:
                                        max3Output.Text = greatGrandchild.Attributes["max"].Value;
                                        min3Output.Text = greatGrandchild.Attributes["min"].Value;
                                        day++;
                                        break;
                                    case 4:
                                        max4Output.Text = greatGrandchild.Attributes["max"].Value;
                                        min4Output.Text = greatGrandchild.Attributes["min"].Value;
                                        day++;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            if (greatGrandchild.Name == "clouds")
                            {
                                switch (day)
                                {
                                    case 1:
                                        cloudOutput.Text = greatGrandchild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    case 2:
                                        clouds2Output.Text = greatGrandchild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    case 3:
                                        clouds3Output.Text = greatGrandchild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    case 4:
                                        clouds4Output.Text = greatGrandchild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void MakePictureParent()
        {


        }
    }
}

