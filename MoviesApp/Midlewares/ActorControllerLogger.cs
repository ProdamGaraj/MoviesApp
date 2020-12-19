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
        private readonly RequestDelegate next;
        private readonly ILogger<ActorControllerLogger> logger;

        public ActorControllerLogger(RequestDelegate next, ILoggerFactory loggerFac)
        {
            this.next = next;
            this.logger = loggerFac.CreateLogger<ActorControllerLogger>();
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (httpContext.Request.Path.Value.ToLower().Contains("/actors"))
            {
                logger.LogDebug($"Actor Request: {httpContext.Request.Path.Value}, Method={httpContext.Request.Method}");
            }
            await this.next(httpContext);
        }

    }
}
