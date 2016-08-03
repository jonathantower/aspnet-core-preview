using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Samples.Middleware
{
	public class RequestLoggerMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly ILogger _logger;

		public RequestLoggerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
		{
			_next = next;
			_logger = loggerFactory.CreateLogger<RequestLoggerMiddleware>();
		}

		public async Task Invoke(HttpContext context)
		{
			// process before passing along
			_logger.LogInformation("Handling request: " + context.Request.Path);

			// pass along
			await _next.Invoke(context);

			// after request has been passed
			_logger.LogInformation("Finished handling request.");
		}
	}
}
