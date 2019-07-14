using NasaImages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace NasaImages.DAL
{
    public interface IImageRepository
    {
        NasaPhotos GetImages(DateTime dt);
        string DownloadImage(string srcImage);
    }
    public class ImageRepository : IImageRepository
    {
        public NasaPhotos GetImages(DateTime dt)
        {
            using (HttpClient client = new HttpClient { BaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings["Mars_Photos_URL"]) })
            {
                var images = client.GetAsync($"?earth_date={dt.Year}-{dt.Month}-{dt.Day}&api_key=DEMO_KEY");
                var imageList = images.Result.Content.ReadAsAsync<NasaPhotos>();
                return imageList.Result;
            }
        }
        public string DownloadImage(string srcImage)
        {
            using (HttpClient client = new HttpClient())
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(srcImage, srcImage.Split('/').Last());
                return "Download:Success";
            }
        }
    }
}