using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LUISHack2016.Controllers
{
    public class ValuesController : ApiController
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
        public string Get(string destination, string origin)
        {
            // Looking up the NR Darwin information for location value.
            NationalRail.LDBServiceSoapClient nr = new LUISHack2016.NationalRail.LDBServiceSoapClient();
            NationalRail.AccessToken at = new NationalRail.AccessToken();
            at.TokenValue = "90538ddb-a178-43b6-b587-0a2f08962a85";

            // Resolve the Origin and Destinaton as CRS fields


            NationalRail.StationBoard sb = nr.GetDepartureBoard(at, 4, "DIS", "NRW", NationalRail.FilterType.to,0, 0);

            string response = "";

            if(sb.areServicesAvailable)
            {
                response = "Next train to " + destination + " is the " + sb.trainServices[0].std + " from " + sb.trainServices[0].origin[0].locationName + " to " + sb.trainServices[0].destination[0].locationName;
                if(sb.platformAvailable)
                {
                    response = response + " on platform " + sb.trainServices[0].platform + ". Is expected to arrive at " + sb.trainServices[0].std;
                }
                else
                {
                    response = response + " Is expected to arrive at " + sb.trainServices[0].std + " no platform stated.";
                }
            }
            else
            {
                response = "No train service found. Use Uber?";
            }

            return response;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
