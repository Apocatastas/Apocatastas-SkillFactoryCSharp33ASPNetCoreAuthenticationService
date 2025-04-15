using AuthentificationService.AuthentificationService.Models;

namespace AuthentificationService
{
    public class LogMiddleware
    {
        private readonly Models.ILogger _logger;
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next, Models.ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var ipAddress = httpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            _logger.WriteEvent("Я твой Middleware, а твой IP-шник " + ipAddress);
            await _next(httpContext);
        }
    }
}
