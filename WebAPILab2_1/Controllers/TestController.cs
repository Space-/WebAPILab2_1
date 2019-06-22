using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPILab2_1.Controllers
{
    [EnableCors(origins: "http://localhost:52394", headers: "*", methods: "*")]
    public class TestController : ApiController
    {
        // http://localhost:52344/redirect and then will redirect to https://www.google.com.tw/
        [HttpGet]
        [Route("redirect")]
        public HttpResponseMessage RedirectToGoogle()
        {
            var response = Request.CreateResponse(HttpStatusCode.Redirect);
            response.Headers.Add("Location", "https://www.google.com.tw/");
            return response;
        }

        // http://localhost:52394/api/test
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("Get from test.")
            };
        }

        public HttpResponseMessage Post()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("Post from test.")
            };
        }

        public HttpResponseMessage Put()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("Put from test.")
            };
        }

        public HttpResponseMessage Delete()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("Delete from test.")
            };
        }
    }
}