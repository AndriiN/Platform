﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Platform;

namespace Platform
{
	public class QueryStringMiddleWare
	{
		private RequestDelegate next;
		public QueryStringMiddleWare()
		{
			// anithing do
		}
		public QueryStringMiddleWare(RequestDelegate nextDelegate)
		{
			next = nextDelegate;
		}

		public async Task Invoke(HttpContext context)
		{
			if (context.Request.Method == HttpMethods.Get)
			// && context.Request.Query["custom"] == "true")
			{
				await context.Response.WriteAsync("Class-based Middleware \n");
			}
			if (next != null)
			{
				await next(context);
			}
		}
	}
}


