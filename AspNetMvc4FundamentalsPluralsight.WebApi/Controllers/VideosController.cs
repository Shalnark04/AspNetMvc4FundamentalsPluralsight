using AspNetMvc4FundamentalsPluralsight.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetMvc4FundamentalsPluralsight.WebApi.Controllers
{
    public class VideosController : ApiController
    {
        private VideoDb _db;

        public VideosController()
        {
            _db = new VideoDb();
            _db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Videos
        public IEnumerable<Video> Get()
        {
            return _db.Videos;
        }

        // GET: api/Videos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Videos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Videos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Videos/5
        public void Delete(int id)
        {
        }
    }
}
