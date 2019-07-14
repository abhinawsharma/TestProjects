using NasaImages.DAL;
using NasaImages.Models;
using NasaImages.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NasaImages.Controllers
{
    public class ImagesController : ApiController
    {
        IImageRepository _rep;

        public ImagesController(IImageRepository rep)
        {
            _rep = rep;
        }
        [HttpGet]
        [Route("Nasa/MarsPhotos/Date/{dt}")]
        public IHttpActionResult GetImageInfoByDate(DateTime dt)
        {
            var images = _rep.GetImages(dt);
            return new ImageResults<NasaPhotos>(images);
        }

        [HttpGet]
        [Route("Nasa/MarsPhotos/Download/{imgSrc}")]
        public IHttpActionResult DownloadImage(string imgSrc)
        {
            var result = _rep.DownloadImage(imgSrc);
            return Ok(result);
        }

    }
}
