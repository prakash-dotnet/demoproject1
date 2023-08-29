using Microsoft.AspNetCore.Mvc;
using DropdownList_CountriesDemo_MVCCore.Models;


namespace DropdownList_CountriesDemo_MVCCore.Controllers
{
	public class CountryController : Controller
	{
		private readonly  CountryDbContext _auc;

		public CountryController(CountryDbContext auc)
		{
			_auc = auc;
		}
		public IActionResult Index()
		{
			List<Country> cl = new List<Country>();
			//cl = (from c in _auc.country select c).ToList();
			cl = _auc.country.ToList();
			cl.Insert(0, new Country { Cid = 0, Cname = "--Select Country Name--" });
			ViewBag.message = cl;
			return View();

	 
		}
	}
}
