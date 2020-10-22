using CountriesInfo.Models;
using Newtonsoft.Json;
using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string rawJsonAll;
            InitializeComponent();
            using (var webClient = new WebClient())
            {
                rawJsonAll = webClient.DownloadString("https://restcountries.eu/rest/v2/all");
            }
            fullList = JsonConvert.DeserializeObject<List<CountryModel>>(rawJsonAll);
            
            //add all countries to combobox.
            foreach(CountryModel c in fullList)
            {
                countriesCB.Items.Add(c.Name);
            }
        }

        List<CountryModel> fullList;
        int currCountry;

        private void button1_Click(object sender, EventArgs e)
        {
            //get current Country.
            foreach (CountryModel c in fullList)
            {
                if(countriesCB.Text == c.Name)
                {
                    currCountry = fullList.IndexOf(c);
                }
            }
            //set flag.
            flagPB.Image = LoadImage(fullList[currCountry].Flag);
            //set title.
            titleLbl.Text = fullList[currCountry].Name;
            //set capital
            listView.Items.Add(fullList[currCountry].Capital);
        }

        public Image LoadImage(string url)
        {
            string svgFileName = url;
            //download svg (stored in ram).
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(svgFileName, "hello.svg");
            }
            //read svg document from file system
            var svgDocument = SvgDocument.Open("hello.svg");
            var bitmap = svgDocument.Draw(flagPB.Width, flagPB.Height);
            return bitmap;
        }

    }
}
