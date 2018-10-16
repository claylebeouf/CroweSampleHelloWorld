using System.Web.Http;
using HelloWorldWithRest.Services;
using static HelloWorldWithRest.Models.HelloWorldViewModel.HelloWorldModel;
namespace HelloWorldWithRest.Controllers
{
    public class HelloWorldController : ApiController
    {
        public HelloWorldController()
        {
            ApiRepository = new ApiRepository();
        }

        public ApiRepository ApiRepository { get; set; }

        public Message Get()
        {
            return ApiRepository.Get();
        }
    }
}
