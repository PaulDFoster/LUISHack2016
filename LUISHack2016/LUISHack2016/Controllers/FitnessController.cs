using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LUISHack2016.Controllers
{
    public class FitnessController : ApiController
    {

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        public string GetStrava(string activity, string unit=null)
        {
            switch(activity)
            {
                case "cycle":
                    break;
                case "run":
                    break;
                default:
                    break;
            }

            return activity;
        }

    }
}
