using System;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NasaImages.Controllers;

namespace NasaImages.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetImageInfoByDate_AllImagesOnThatDate()
        {
            DAL.IImageRepository rep = new DAL.ImageRepository();
            
            ImagesController controller = new ImagesController(rep);

            IHttpActionResult result = controller.GetImageInfoByDate(new DateTime(2017,02,27));

            var r = result.ExecuteAsync(System.Threading.CancellationToken.None).Result.Content.ReadAsStringAsync().Result;

           var photos =  Newtonsoft.Json.JsonConvert.DeserializeObject<Models.NasaPhotos>(r);
            Assert.AreEqual(photos.photos.Count, 36);
        }
    }
}
