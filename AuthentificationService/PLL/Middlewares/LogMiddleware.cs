namespace AuthentificationService.PLL.Middlewares
{
    public class LogMiddleware
    {
        private readonly PLL.Logging.ILogger _logger;
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next, PLL.Logging.ILogger logger)
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
