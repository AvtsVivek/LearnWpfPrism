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

    //public class LoggingHandlerDecorator : IHandler
    //{
    //    private readonly IHandler _handler;
    //    public readonly ILogger Logger;

    //    public LoggingHandlerDecorator(IHandler handler, ILogger logger)
    //    {
    //        _handler = handler;
    //        Logger = logger;
    //    }

    //    public bool IsHandled => _handler.IsHandled;

    //    public void Handle()
    //    {
    //        Logger.Log("About to handle");
    //        _handler.Handle();
    //        Logger.Log("Successfully handled");
    //    }
    //}
}