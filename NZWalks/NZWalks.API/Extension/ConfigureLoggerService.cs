using NZWalks.Logger;

namespace NZWalks.API.Extension
{
    public static class ServiceExtensions
    {
        public static void ConfigureLoggerService(this IServiceCollection service)
        {
            service.AddSingleton<ILoggerManager,LoggerManager>();
        }
    }
}
