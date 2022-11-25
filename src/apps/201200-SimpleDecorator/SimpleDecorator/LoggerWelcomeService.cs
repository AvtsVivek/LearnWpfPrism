using SimpleContract;
using System.Diagnostics;

namespace SimpleDecorator
{
    public class LoggerWelcomeService : IWelcomeService 
    {
        private readonly IWelcomeService _welcomService;
        private readonly ILogger _logger;
        public LoggerWelcomeService(IWelcomeService welcomService, ILogger logger)
        {
            _welcomService = welcomService;
            _logger = logger;
        }

        public string GetWelcomeMessage(string name)
        {
            Debugger.Break();
            _logger.Log("Before Get Welcome Message method calling");
            var welcomMessage = _welcomService.GetWelcomeMessage(name);
            _logger.Log("After Get Welcome Message method called");
            return welcomMessage;
        }
    }

}