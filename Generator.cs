using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD
{
    public class Generator
    {
        public static RestResponse CallOfDuty()
        {
            var client = new RestClient("https://call-of-duty-modern-warfare.p.rapidapi.com/warzone/Jedidiahs_Wisdom/psn");

            var request = new RestRequest(Method.Get.ToString());

            request.AddHeader("X-RapidAPI-Key", "291ec47ed7mshe44eb40bf495542p1d1e6ejsn40666d7b66c1");

            request.AddHeader("X-RapidAPI-Host", "call-of-duty-modern-warfare.p.rapidapi.com");

            RestResponse response = client.Execute(request);

            return response;
        }
    }
}
