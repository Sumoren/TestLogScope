
using NLog;

namespace TestLogScope
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LogManager.GetCurrentClassLogger();

            logger.Info("Log before scope");

            using (MappedDiagnosticsLogicalContext.SetScoped("ScopeKey", 52))
            {
                logger.Info("Log inside Mdlc scope {Param}", 79);
            }
        }
    }
}
