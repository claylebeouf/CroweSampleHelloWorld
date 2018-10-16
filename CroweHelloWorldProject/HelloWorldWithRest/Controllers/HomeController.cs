using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using static HelloWorldWithRest.Models.HelloWorldViewModel.HelloWorldModel;

namespace HelloWorldWithRest.Controllers
{
    public class HomeController : Controller
    {
        //Make API Call
        string Baseurl = "http://localhost:39295/";

        public async Task<ActionResult> Index()
        {
            Message message = new Message();

            using (var client = new HttpClient())
            {
                try
                {
                    //Passing service base url  
                    client.BaseAddress = new Uri(Baseurl);

                    client.DefaultRequestHeaders.Clear();
                    //Define request data format  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    //Sending request to find web api REST service resource Message using HttpClient  
                    HttpResponseMessage Res = await client.GetAsync("api/HelloWorld");

                    //Checking the response is successful or not which is sent using HttpClient  
                    if (Res.IsSuccessStatusCode)
                    {
                        //Storing the response details received from web api   
                        var MsgResponse = Res.Content.ReadAsStringAsync().Result;

                        //Deserializing the response received from web api
                        message = JsonConvert.DeserializeObject<Message>(MsgResponse);

                    }
                }
                catch (Exception)
                {
                    message.Response = "Error Processing Request";
                }

                //returning the message to view  
                return View(message);
            }
        }
    }
}