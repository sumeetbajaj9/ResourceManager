using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ResourceManagerEngine.Models;
using ResourceManagerEngine.Providers;

namespace ResourceManager.Controllers
{
    [RoutePrefix("api/resource")]
    public class ResourceManagerController : ApiController
    {
        IResourceManagerProvider provider = null;
        public ResourceManagerController() {
            provider = new ResourceManagerProvider();
        }


        //Method for getting the data
        [Route("getdata")]
        [HttpGet]
        public IHttpActionResult GetData() {
            var result1 = false;
            var result = new ResourceManagerResponseModel.ResourceDetails();
            using (var session = WebApiConfig.Neo4jDriver.Session()) {
                result = provider.GetDemo(session);
                
            }    
            return Ok(result);
        }
        //fetch the data on basis of dates
        [Route("fetchdata")]
        [HttpGet]
        public IHttpActionResult GetFetchedData() {
            var result = new ResourceManagerResponseModel.ResourceDetails();
            using (var session = WebApiConfig.Neo4jDriver.Session()) {
                result = provider.GetFetchedDetails(session);
            }
                return Ok(result);
        }

        



    }
}
