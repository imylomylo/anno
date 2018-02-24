﻿using System.Net.Http;
using System.Web.Http;
using AnnoAPI.Core.Enum;
using AnnoAPI.Core;

namespace AnnoAPI.Controllers
{
    public class AppController : ApiController
    {
        [HttpGet]
        [Route("status")]
        public HttpResponseMessage GetStatus()
        {
            //Send response
            return Request.CreateResponse(new GenericResponse(null, ResponseCodes.Success, ResponseMessages.Success));
        }
    }
}
