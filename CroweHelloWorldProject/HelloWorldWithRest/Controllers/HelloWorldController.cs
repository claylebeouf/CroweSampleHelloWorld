using System.Web.Http;
using HelloWorldWithRest.Services;
using static HelloWorldWithRest.Models.HelloWorldViewModel.HelloWorldModel;
namespace HelloWorldWithRest.Controllers
{
    public class HelloWorldController : ApiController
    {
        public ApiRepository apiRepository;

        public HelloWorldController()
        {
            apiRepository = new ApiRepository();
        }

        public Message Get()
        {
            return ApiRepository.Get();
        }
    }
}
