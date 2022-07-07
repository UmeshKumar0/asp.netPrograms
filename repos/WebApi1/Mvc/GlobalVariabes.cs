using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Mvc
{
    public static class GlobalVariabes
    {
        public static HttpClient WebApiClient = new HttpClient();

       static GlobalVariabes()
        {
            WebApiClient.BaseAddress = new Uri("https://localhost:44349/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }    
           
        
    }
}