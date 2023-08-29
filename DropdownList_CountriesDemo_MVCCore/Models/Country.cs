using System.ComponentModel.DataAnnotations;

namespace DropdownList_CountriesDemo_MVCCore.Models
{
	public class Country
	{
		[Key]
		public int Cid { get; set; }

		public string Cname { get; set; }
	}
}
