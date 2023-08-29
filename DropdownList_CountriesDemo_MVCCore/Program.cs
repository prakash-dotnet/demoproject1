using DropdownList_CountriesDemo_MVCCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DropdownList_CountriesDemo_MVCCore
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<CountryDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            // Add services to the container.
            builder.Services.AddControllersWithViews();

			var app = builder.Build();
		      //  services.AddDbContext<ApplicationUser>(options => options.UseSqlServer(Configuration.GetConnectionString("Myconnection")));  
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
			}
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}