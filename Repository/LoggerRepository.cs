using NLog;
using OurTestApi.Interface;

namespace OurTestApi.Repository
{
    public class LoggerRepository : INLogger
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggerRepository()
        {

        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }
    }
}