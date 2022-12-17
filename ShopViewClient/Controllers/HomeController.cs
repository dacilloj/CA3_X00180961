using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ShopViewClient.Controller
{
    public class HomeController : ControllerBase
    {
        string Baseurl = "http://192.168.95.1:5555/";
        public async Task<ActionResult> Index()
        {
            List<ItemModel> Items = new List<ItemModel>();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpResponseMessage Res = await client.GetAsync("api/ItemModels/GetItemModels");
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var ItemsResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list
                    Items = JsonConvert.DeserializeObject<List<ItemModel>>(ItemsResponse);
                }
                //returning the employee list to view
                return View(Items);
            }
        }
    }
}
