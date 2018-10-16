using static HelloWorldWithRest.Models.HelloWorldViewModel.HelloWorldModel;

namespace HelloWorldWithRest.Services
{
    public class ApiRepository
    {
        public static Message Get()
        {
            return new Message
            {
                Response = "Hello World"
            };
        }
    }
}