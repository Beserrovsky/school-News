using News.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.Controllers
{
	public static class Global
	{
		public static List<CategoryModel> Categories = new List<CategoryModel>();
        public static List<NewsModel> News = new List<NewsModel>();

        public static void Init()
        {
            Categories.Add(new CategoryModel() { Id = Categories.Count, Name = "Escola", Description = "'Blog' da escola" });             // 0
            Categories.Add(new CategoryModel() { Id = Categories.Count, Name = "Lorem", Description = "Categoria de teste, Lorem" });     // 1
            Categories.Add(new CategoryModel() { Id = Categories.Count, Name = "Celebridades", Description = "Os maiores babados!!!" });  // 2 

            // Escola
            News.Add(new NewsModel() { Id = News.Count, Category = Categories.ElementAt(0), Name = "Jornal da escola está bombando!", DateCreated = DateTime.Now, Article = "5 dias atras criamos nosso post, e hoje já estamos recebendo diversas mensagens entusiasmadas esperando nossas histórias, fique ligado que logo logo haverá mais de nosso jornalzinho!" });
            News.Add(new NewsModel() { Id = News.Count, Category = Categories.ElementAt(0), Name = "Jornal da escola aberto!", DateCreated = DateTime.Now.AddDays(-5), Article = "Estaremos utilizando esta plataforma para manter o jornal da escola!\nSiga ligado na nossa história :)" });

            // Celebridades
            News.Add(new NewsModel() { Id = News.Count, Category = Categories.ElementAt(2), Name = "Fautão se aposenta!", DateCreated = DateTime.Now.AddDays(-31), Article = "OLOCO BIXOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO" });

            // Lorem
            News.Add(new NewsModel() { Id = News.Count, Category = Categories.ElementAt(1), Name = "Lorem Ipsum", DateCreated = DateTime.Now.AddDays(new Random().NextDouble() * -100), Article = LOREM });
            News.Add(new NewsModel() { Id = News.Count, Category = Categories.ElementAt(1), Name = "Lorem Ipsum", DateCreated = DateTime.Now.AddDays(new Random().NextDouble() * -100), Article = LOREM });
            News.Add(new NewsModel() { Id = News.Count, Category = Categories.ElementAt(1), Name = "Lorem Ipsum", DateCreated = DateTime.Now.AddDays(new Random().NextDouble() * -100), Article = LOREM });
            News.Add(new NewsModel() { Id = News.Count, Category = Categories.ElementAt(1), Name = "Lorem Ipsum", DateCreated = DateTime.Now.AddDays(new Random().NextDouble() * -100), Article = LOREM });
            News.Add(new NewsModel() { Id = News.Count, Category = Categories.ElementAt(1), Name = "Lorem Ipsum", DateCreated = DateTime.Now.AddDays(new Random().NextDouble() * -100), Article = LOREM });
            News.Add(new NewsModel() { Id = News.Count, Category = Categories.ElementAt(1), Name = "Lorem Ipsum", DateCreated = DateTime.Now.AddDays(new Random().NextDouble() * -100), Article = LOREM });
            News.Add(new NewsModel() { Id = News.Count, Category = Categories.ElementAt(1), Name = "Lorem Ipsum", DateCreated = DateTime.Now.AddDays(new Random().NextDouble() * -100), Article = LOREM });
        }

        const string LOREM = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum ut velit tellus. Aenean pretium dolor ex. In at neque vestibulum, imperdiet libero sit amet, tincidunt ligula. Donec volutpat felis ultrices, placerat sapien in, faucibus nunc. Pellentesque sagittis dolor id venenatis finibus. Aenean eget ante arcu. Nullam tortor sem, sollicitudin ac finibus eget, elementum id justo. Phasellus in nulla ac risus dictum maximus. Aliquam erat volutpat. Curabitur lobortis nisi ac feugiat rutrum. Morbi in hendrerit nisi, vel porta ipsum.\nCurabitur at lorem nec nisl cursus fermentum. Ut porta, enim sed facilisis mattis, ligula nisl tincidunt mauris, non accumsan ligula mauris eu est. Praesent tellus turpis, vehicula ut augue et, convallis blandit tellus. Maecenas eget sagittis metus. Maecenas ornare ex nec neque feugiat, quis semper enim rutrum. Aliquam ac semper nisl. Praesent pellentesque cursus ante, ut dictum neque hendrerit non. Donec neque tortor, molestie quis ullamcorper eu, ultrices convallis ex. Duis ullamcorper lacus sit amet ultricies fringilla. Praesent id odio fringilla, euismod odio eget, lobortis ligula. Cras tincidunt sem vel velit hendrerit, vel consequat enim malesuada. Nunc elementum id quam nec tempus. Donec turpis ipsum, eleifend auctor iaculis quis, luctus sed velit. Sed rhoncus a ligula ut cursus.\nCurabitur vitae elit sodales, sagittis augue vel, hendrerit nunc. Vestibulum ut malesuada massa, vel pharetra augue. Etiam vitae maximus magna. Quisque sollicitudin dictum metus. Nulla euismod neque vitae aliquet interdum. Donec ullamcorper erat quis metus efficitur posuere. Integer tincidunt interdum ligula sed rhoncus. Cras magna turpis, posuere a mi et, placerat laoreet nunc. Fusce id sem orci.\nAliquam mattis elementum molestie. Morbi sapien augue, finibus ut scelerisque nec, ornare vel dui. Aenean non nulla mauris. Donec eget ultricies tortor. Donec porta justo turpis, id dignissim libero tristique non. Ut fermentum mauris turpis. Sed porttitor risus non aliquam lobortis. Morbi id magna elit. Maecenas a dolor id tellus malesuada venenatis. Vestibulum eu ante enim. In eu lacus in dolor suscipit dictum a et diam. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\nIn vitae lectus luctus, sagittis lectus nec, aliquet ex. Nullam eget sagittis justo, eget consectetur tortor. Nulla sit amet orci hendrerit, aliquam erat sed, sollicitudin ex. Etiam commodo diam sit amet odio condimentum sagittis. Nam sapien eros, ultricies nec augue ac, gravida tincidunt sem. Maecenas vitae cursus nisi. In lacus purus, rutrum id malesuada at, gravida porttitor turpis. Nam eget enim at nisi suscipit egestas eget in metus. Sed dapibus sit amet risus vitae tempor. Donec tortor libero, ullamcorper in volutpat id, dictum sed mi. Suspendisse potenti. Quisque eget dignissim ante. Curabitur dictum nulla sed risus vulputate, a placerat nisi porta. Donec ac dolor orci. ";
    }
}