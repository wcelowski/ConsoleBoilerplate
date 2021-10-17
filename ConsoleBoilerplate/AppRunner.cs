using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleBoilerplate
{
    public class AppRunner : IAppRunner
    {
        private readonly ILogger<AppRunner> _log;
        private readonly IConfiguration _config;

        public AppRunner(ILogger<AppRunner> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
        
        public void Run()
        {
            var testMessage = _config.GetValue<string>("App:TestMessage");
            
            _log.LogInformation("Test message is: {TestMessage}" ,testMessage);
        }
    }
}