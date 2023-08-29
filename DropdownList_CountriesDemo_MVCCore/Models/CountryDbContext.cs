using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace DropdownList_CountriesDemo_MVCCore.Models
{
	public class CountryDbContext : DbContext
	{
		public CountryDbContext(DbContextOptions<CountryDbContext> options ):base(options)
		{ 
		
		}
		 
		
		public DbSet<Country> country { get; set; }
	}
}
