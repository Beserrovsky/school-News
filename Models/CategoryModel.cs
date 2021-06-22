using System.ComponentModel.DataAnnotations;

namespace News.Models
{
	public class CategoryModel
	{
		public int Id { get; set; }

		[Display(Name = "Nome")]
		public string Name { get; set; }

		[Display(Name = "Descrição")]
		public string Description { get; set; }
		
	}
}