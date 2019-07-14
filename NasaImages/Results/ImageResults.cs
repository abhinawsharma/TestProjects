using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using NLog;

namespace NasaImages.Results
{
    public class ImageResults<T> : IHttpActionResult
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        T _obj;
        public ImageResults(T obj)
        {
            _obj = obj;
        }
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            try
            {
                HttpResponseMessage msg = new HttpResponseMessage
                {
                    Content = new ObjectContent<T>(_obj, new System.Net.Http.Formatting.JsonMediaTypeFormatter())
                };
                msg.EnsureSuccessStatusCode();
                return Task.FromResult(msg);
            }catch(Exception ex)
            {
                HttpResponseMessage msg = new HttpResponseMessage
                {
                    Content = new StringContent($"Error:{ex.Message}:{ex.InnerException?.Message}")
                };
                logger.Log(LogLevel.Error, $"Error:{ex.Message}:{ex.InnerException?.Message}");
                return Task.FromResult(msg);

            }
        }
    }
}