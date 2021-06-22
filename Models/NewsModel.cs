using System;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
	public class NewsModel
	{
		public int Id { get; set; }

		[Display(Name="Nome")]
		public string Name { get; set; }

		[Display(Name = "Categoria")]
		public CategoryModel Category { get; set; }

		[Display(Name = "Data criada")]
		public DateTime DateCreated { get; set; }

		[Display(Name = "Artigo")]
		public string Article { get; set; }
	}
}