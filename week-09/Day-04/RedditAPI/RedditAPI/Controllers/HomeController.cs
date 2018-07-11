using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditAPI.Models;
using RedditAPI.Services;

namespace RedditAPI.Controllers
{

    public class HomeController : Controller
    {
        private RedditHomeService service;

        public HomeController(RedditHomeService service)
        {
            this.service = service;
        }

        [HttpGet("/posts")]
        public IActionResult GetPosts()
        {
            return Json(new { posts = service.GetAllPostElements() });
        }

        [HttpPost("/posts")]
        public IActionResult CreatePost([FromBody] Post inputJson)
        {
            return Json(service.CreatePost(inputJson));
        }

        [HttpPut("/posts/{id}/upvote")]
        public IActionResult UpVote(int id)
        {
            return Json(service.ChangeScoreOfPost(id, 1));
        }

        [HttpPut("/posts/{id}/downvote")]
        public IActionResult DownVote(int id)
        {
            return Json(service.ChangeScoreOfPost(id, -1));
        }

        [HttpPut("/posts/{id}")]
        public IActionResult ChangePost(int id, [FromBody] Post inputPost)
        {
            return Json(service.ChangePost(id, inputPost));
        }

        [HttpDelete("/posts/{id}")]
        public IActionResult DeletePost(int id)
        {
            return Json(service.DeletePost(id));
        }
    }
}