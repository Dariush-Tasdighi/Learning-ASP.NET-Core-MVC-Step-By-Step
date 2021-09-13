using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

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
			// using Microsoft.Extensions.DependencyInjection;
			services.AddControllersWithViews();
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

			// UseHttpsRedirection -> using Microsoft.AspNetCore.Builder;
			app.UseHttpsRedirection();

			// UseStaticFiles -> using Microsoft.AspNetCore.Builder;
			app.UseStaticFiles();

			// UseRouting -> using Microsoft.AspNetCore.Builder;
			app.UseRouting();

			// UseRouting -> using Microsoft.AspNetCore.Builder;
			//app.UseCookiePolicy();
			// UseRouting -> using Microsoft.AspNetCore.Builder;
			//app.UseAuthentication();
			// UseRouting -> using Microsoft.AspNetCore.Builder;
			//app.UseAuthorization();

			// UseEndpoints -> using Microsoft.AspNetCore.Builder;
			app.UseEndpoints(endpoints =>
			{
				// MapControllerRoute -> using Microsoft.AspNetCore.Builder;
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
