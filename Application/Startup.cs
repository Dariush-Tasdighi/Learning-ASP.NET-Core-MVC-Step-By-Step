using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace Application
{
	public class Startup : object
	{
		public Startup() : base()
		{
		}

		public void ConfigureServices
			(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
		{
		}

		public void Configure
			(Microsoft.AspNetCore.Builder.IApplicationBuilder app,
			Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
		{
			// IsDevelopment -> using Microsoft.Extensions.Hosting;
			if (env.IsDevelopment())
			{
				// UseDeveloperExceptionPage -> using Microsoft.AspNetCore.Builder;
				app.UseDeveloperExceptionPage();
			}

			// UseRouting -> using Microsoft.AspNetCore.Builder;
			app.UseRouting();

			// UseEndpoints -> using Microsoft.AspNetCore.Builder;
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGet("/", async context =>
				{
					// WriteAsync -> using Microsoft.AspNetCore.Http;
					await context.Response.WriteAsync("Hello World!");
				});
			});
		}
	}
}
