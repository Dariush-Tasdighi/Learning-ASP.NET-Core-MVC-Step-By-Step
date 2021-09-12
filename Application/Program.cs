using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Application
{
	public class Program : object
	{
		public Program() : base()
		{
		}

		public static void Main(string[] args)
		{
			// Run -> using Microsoft.Extensions.Hosting;
			CreateHostBuilder(args).Build().Run();
		}

		public static Microsoft.Extensions.Hosting.IHostBuilder CreateHostBuilder(string[] args)
		{
			var hostBuilder =
				Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
					.ConfigureWebHostDefaults(webBuilder =>
					{
						// UseStartup -> using Microsoft.AspNetCore.Hosting;
						webBuilder.UseStartup<Startup>();
					});

			return hostBuilder;
		}
	}
}
