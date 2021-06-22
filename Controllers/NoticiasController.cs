using News.Models;
using News.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace News.Controllers
{
    public class NoticiasController : Controller
    {
        // Data stored at Global.cs

        const int LATEST_SIZE = 5;

        public ActionResult Index(string id = "todas")
        {
            ViewBag.Mode = id.ToLower() != "todas" ? (id.Length>1? char.ToUpper(id[0]) + id.Substring(1) : id.ToUpper()) : null;
            ViewBag.Categories = Global.Categories;
            switch (id.ToLower()) 
            {
                case "últimas":
                    int articles = Global.News.Count >= LATEST_SIZE ? LATEST_SIZE : Global.News.Count;
                    ViewBag.News = Global.News.OrderByDescending(news => news.DateCreated.Date).Take(articles).ToList();
                    return View();
                case "todas":
                    ViewBag.News = Global.News;
                    return View();
            }

            ViewBag.Category = Global.Categories.Find(cat => cat.Name.ToLower().Equals(id.ToLower()));
            ViewBag.News = Global.News.FindAll(news => news.Category.Name.ToLower().Equals(id.ToLower()));
            if(ViewBag.News != null) return View();

            ViewBag.Error = "Não foi encontrada nenhuma configuração de feed com este id!";
            return View("Error");
        }

        public ActionResult Noticia(int id = -1) 
        {
            if (id != -1) 
            {
                NewsModel n = Global.News.FirstOrDefault(news => news.Id.Equals(id));

                if (n!=null) return View(n);

                ViewBag.Error = "Não há uma notícia com este id!";
                return View("Error");
            }
            ViewBag.Error = "Não foi provido um id para a busca por notícia!";
            return View("Error");
        }
    }
}