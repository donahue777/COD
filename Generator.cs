using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD
{
    public class Generator
    {
        public static IRestResponse CallOfDuty()
        {
            var client = new RestSharp.RestClient("");
            var request = new RestRequest(Method.GET);
            request.AddHeader("");
            request.AddHeader("");
            IRestResponse response = client.Execute(request);
        }
    }
}
