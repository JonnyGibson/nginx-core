using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;

namespace Example.App
{
	public sealed class Startup
	{
		public void Configure(IApplicationBuilder app)
		{
			app.Run(async (context) =>
			{
				await context.Response.WriteAsync($"<h1>Reverse Proxy Test</h1>As far as i know the time is <strong>{DateTime.Now}</strong>");
			});
		}
	}
}
