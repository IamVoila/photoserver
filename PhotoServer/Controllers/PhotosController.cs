﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhotoServer.Controllers
{
    public class PhotosController : ApiController
    {
        // GET api/photos
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/photos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/photos
        public void Post([FromBody]string value)
        {
        }

        // PUT api/photos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/photos/5
        public void Delete(int id)
        {
        }
    }
}
