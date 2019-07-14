using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

namespace TestClient
{
    public partial class ImageViewer : Form
    {
        private string selImgSrc = "";
        public ImageViewer()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                foreach (DataGridViewRow row in dtgImages.Rows)
                {
                    string imgSrc = row.Cells["img_src"].Value.ToString();
                    wc.DownloadFile(imgSrc, imgSrc.Split('/').Last());
                }
            }
        }

        private void lnkImagesByDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtErrors.Text = "";
            string date = cmbDates.Text;
            DateTime.TryParse(date, out DateTime dt);
            if (dt == DateTime.MinValue)
            {
                txtErrors.Text = $"Please enter a valid date. {date} is not valid";
                return;
            }
            CallWebAPI($"Nasa/MarsPhotos/Date/{dt.Year}-{dt.Month}-{dt.Day}");
        }

        private void lnkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //HttpClient client = null;
            //client = new HttpClient(new HttpClientHandler { UseDefaultCredentials = true })
            //{
            //    BaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings["API_BaseURL"]),
            //};
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage res = client.GetAsync($"Nasa/MarsPhotos/Download/{selImgSrc.Replace("/","---").Replace("http//:","")}").Result;
            //if (res.IsSuccessStatusCode)
            //{
            //    var result = res.Content.ReadAsStringAsync().Result;
            //}
            
            WebClient wc = new WebClient();
            wc.DownloadFile(selImgSrc, selImgSrc.Split('/').Last());
        }
        private void CallWebAPI(string url)
        {
            txtErrors.Text = "";
            HttpClient client = null;
            client = new HttpClient(new HttpClientHandler { UseDefaultCredentials = true })
            {
                BaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings["API_BaseURL"]),
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage res = client.GetAsync(url).Result;

            if (res.IsSuccessStatusCode)
            {
                dtgImages.DataSource = null;
                // List<GridModel> lstModels = new List<GridModel>();
                var result = res.Content.ReadAsStringAsync().Result;
                var photos = Newtonsoft.Json.JsonConvert.DeserializeObject<NasaPhotos>(result);
                //foreach(var p in photos.photos)
                //{
                //    lstModels.Add(new GridModel { id = p.id, img_src=p.img_src});
                //}
                dtgImages.DataSource = photos.photos;
                dtgImages.Show();
            }
        }

        private void dtgImages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var s = sender as DataGridView;
            var img = s["img_src", e.RowIndex].Value.ToString();
            selImgSrc = img;
            webBrowser1.DocumentText = $"<html><body><img src = '{img}'></body></html>";
            webBrowser1.Show();
        }

        private void linkBrowser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(selImgSrc);
        }
    }
}
