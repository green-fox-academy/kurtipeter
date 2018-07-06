using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditApp.Services;

namespace RedditApp.Controllers
{
    public class RedditController : Controller
    {
        RedditService service;

        public RedditController(RedditService service)
        {
            this.service = service;
        }

        [HttpGet("/")]
        public IActionResult Reddit()
        {
            return View(service.GetAllElement());
        }

        [HttpGet("/AddPost")]
        public IActionResult AddPost()
        {
            return View();
        }

        [HttpPost("/AddPost")]
        public IActionResult AddPostToDB(string title, string url)
        {
            service.Create(url, title);
            return View("AddPost");
        }

        [HttpGet("like/{Id}")]
        public IActionResult LikePost(int Id)
        {
            service.Like(Id);
            return Redirect("/");
        }

        [HttpGet("dislike/{Id}")]
        public IActionResult DislikePost(int Id)
        {
            service.Dislike(Id);
            return Redirect("/");
        }

        [HttpPost("/delete")]
        public IActionResult Delete(string deleteThis)
        {
            service.Delete(Int32.Parse(deleteThis));
            return Redirect("/");
        }

        [HttpPost("/edit")]
        public IActionResult EditPost(string editThis)
        {
            service.SetPostToEdit(Int32.Parse(editThis));
            return View();
        }

        [HttpPost("/editThisPost")]
        public IActionResult Edit(string title, string url)
        {
            service.Edit(title, url);
            return Redirect("/");
        }
    }
}