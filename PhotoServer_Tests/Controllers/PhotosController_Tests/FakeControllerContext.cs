﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace PhotoServer_Tests.Controllers.PhotosController_Tests
{
    public class FakeControllerContext : HttpControllerContext
    {
	    public FakeControllerContext()
	    {
		    Configuration = new HttpConfiguration();
			
			
	    }

        
 
    }



}
