using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace NasaImagesWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.Photos pDefault = new Models.Photos { photos = new List<Models.photos> { new Models.photos { id = 1, img_src = "" } } };
            return View("MarsRoverImages", pDefault);
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Watch Guard Video";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult MarsRoverImages(string dt)
        {
            DateTime.TryParse(dt,out DateTime dtt);
            Models.Photos pDefault = new Models.Photos {photos= new List<Models.photos> { new Models.photos { id=1,img_src=""} } };
            if (dtt == System.DateTime.MinValue) return View(pDefault);
            using (HttpClient client = new HttpClient { BaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings["API_BaseURL"])})
            {
                var dataPhotos = client.GetAsync($"Nasa/MarsPhotos/Date/{dtt.Year}-{dtt.Month}-{dtt.Day}").Result.Content.ReadAsStringAsync().Result;
                var d =   Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Photos>(dataPhotos);
                //TempData["NewPhotos"] = d;
                //RedirectToAction("ShowUpdatedListBox", d);
                //return View(d);
                //return View(d);
                return Json(d);
                //return new JsonResult() { Data = d};
            }
        }
        [HttpGet]
        public ActionResult ShowUpdatedListBox()
        {
            if(TempData["NewPhotos"] == null)
            {
                Models.Photos pDefault = new Models.Photos { photos = new List<Models.photos> { new Models.photos { id = 1, img_src = "" } } };
                return View("MarsRoverImages",pDefault);
            }
            return View("MarsRoverImages",TempData["NewPhotos"]);
        }
    }
}