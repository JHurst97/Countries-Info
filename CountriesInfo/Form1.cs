using CountriesInfo.Models;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
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

            //set up gmap.
            GMapControl gmap = new GMapControl();

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
                    listView1.Items.Clear();
                    AttachInfo(listView1);
                }
            }
        }

        void AttachInfo(ListView listView)
        {
            //set GMap.
            GMapConfig();
            gMap.Position = new PointLatLng(fullList[currCountry].Latlng[0], fullList[currCountry].Latlng[1]);
            //set flag.
            flagPB.Image = LoadImage(fullList[currCountry].Flag);
            //set title.
            titleLbl.Text = fullList[currCountry].Name;
            //set capital
            ListViewItem capital = new ListViewItem();
            capital.SubItems.Add("Capital:");
            capital.SubItems.Add(fullList[currCountry].Capital);
            listView.Items.Add(capital);
            //set ISO-3166.
            ListViewItem alpha3Code = new ListViewItem();
            alpha3Code.SubItems.Add("ISO-3166 code:");
            alpha3Code.SubItems.Add(fullList[currCountry].Alpha3Code);
            listView.Items.Add(alpha3Code);
            //set region.
            ListViewItem region = new ListViewItem();
            region.SubItems.Add("Region:");
            region.SubItems.Add(fullList[currCountry].Region);
            listView.Items.Add(region);
            //set sub-region.
            ListViewItem subRegion = new ListViewItem();
            subRegion.SubItems.Add("Subregion:");
            subRegion.SubItems.Add(fullList[currCountry].Subregion);
            listView.Items.Add(subRegion);
            //set population.
            ListViewItem pop = new ListViewItem();
            pop.SubItems.Add("Population");
            pop.SubItems.Add(fullList[currCountry].Population.ToString());
            listView.Items.Add(pop);
            //add Lat/Lon.
            ListViewItem latLng = new ListViewItem();
            latLng.SubItems.Add("Coordinates:");
            latLng.SubItems.Add("Lat: " + fullList[currCountry].Latlng[0].ToString() + " / Lon: " + fullList[currCountry].Latlng[1].ToString());
            listView.Items.Add(latLng);
            //add denonym.
            ListViewItem denonym = new ListViewItem();
            denonym.SubItems.Add("Denonym:");
            denonym.SubItems.Add(fullList[currCountry].Demonym);
            listView.Items.Add(denonym);
            //add area.
            ListViewItem area = new ListViewItem();
            area.SubItems.Add("Area:");
            area.SubItems.Add(fullList[currCountry].Area + "KMsq");
            listView.Items.Add(area);
            //add borders.
            ListViewItem borders = new ListViewItem();
            borders.SubItems.Add("Borders:");
            StringBuilder sb = new StringBuilder();
            String SEPARATOR = "";
            for (int i1 = 0; i1 < fullList[currCountry].Borders.Count; i1++)
            {
                sb.Append(SEPARATOR);
                sb.Append(fullList[currCountry].Borders[i1]);
                SEPARATOR = ", ";
            }
            borders.SubItems.Add(sb.ToString());
            listView.Items.Add(borders);
        }

        void GMapConfig()
        {
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.DragButton = MouseButtons.Left;
            gMap.ShowCenter = false;
            gMap.MinZoom = 1;
            gMap.MaxZoom = 100;
            gMap.Zoom = 3;
        }

        /*
            ListViewItem = new ListViewItem();
            .SubItems.Add("");
            .SubItems.Add(fullList[currCountry].);
            listView.Items.Add();
        */

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

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            listView1.Columns[1].Width = splitContainer1.Panel1.Width / 2;
            listView1.Columns[2].Width = splitContainer1.Panel1.Width / 2;
        }
    }
}
