using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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

        private async Task<string> StravaGet()
        {
            /*
            https://www.strava.com/oauth/authorize?
            client_id = 9
            & response_type = code
            & redirect_uri = http://testapp.com/token_exchange
            & scope = write
            & state = mystate
            & approval_prompt = force
              */

            Uri uri = new Uri("");

            var httpClient = new HttpClient();

            
            var response = await httpClient.GetAsync(uri);

            //will throw an exception if not successful
            //response.EnsureSuccessStatusCode();

            //string content = await response.Content.ReadAsStringAsync();
            //return await Task.Run(() = &gt; JsonObject.Parse(content));


            return "";
        }

    }
}
