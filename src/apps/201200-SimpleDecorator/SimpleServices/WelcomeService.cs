using SimpleContract;

namespace SimpleServices
{
    public class WelcomeService : IWelcomeService
    {
        public string GetWelcomeMessage(string name)
        {
            return $"Welcome {name}.";
        }
    }
}
