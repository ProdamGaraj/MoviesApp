using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MoviesApp.Midlewares
{
    public class ActorControllerLogger
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ActorControllerLogger> _logger;

        public ActorControllerLogger(RequestDelegate next, ILoggerFactory loggerFac)
        {
            _next = next;
            _logger = loggerFac.CreateLogger<ActorControllerLogger>();
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (httpContext.Request.Path.Value.ToLower().Contains("/actors"))
            {
                _logger.LogTrace($"Actor Request= {httpContext.Request.Path.Value}, Method={httpContext.Request.Method}");
                await _next(httpContext);
            }
            else
            {
                await _next(httpContext);
            }
        }

    }
}
