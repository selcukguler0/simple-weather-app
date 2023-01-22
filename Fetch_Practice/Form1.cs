using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fetch_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        private void getWeather_Click(object sender, EventArgs e)
        {
            var client = new RestClient($"https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city={cityName.Text}");
            var request = new RestRequest();
            request.AddHeader("authorization", "apikey 7yIjOG26DZ4tqQ8e4cD0on:5Rrcr4dolWYpjn9FL3NPHF");
            var response = client.Execute(request);
            dynamic json = JsonConvert.DeserializeObject(response.Content);

            if (json.success == false)
            {
                MessageBox.Show($"{cityName.Text} not Found!");
            }
            else
            {
                
                degree.Text = json.result[0].degree;
                minDeg.Text = json.result[0].min;
                maxDeg.Text = json.result[0].max;
            }
            
        }
    }
}
