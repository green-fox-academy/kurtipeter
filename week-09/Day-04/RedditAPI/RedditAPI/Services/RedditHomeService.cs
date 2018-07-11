using Newtonsoft.Json;
using RedditAPI.Models;
using RedditAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Services
{
    public class RedditHomeService
    {
        private UserRepository userRepo;
        private PostRepository postRepo;

        public RedditHomeService(UserRepository userRepo, PostRepository postRepo)
        {
            this.userRepo = userRepo;
            this.postRepo = postRepo;
        }

        public List<Post> GetAllPostElements()
        {
            return postRepo.GetAllElementsFromDb();
        }

        public Post GetOnePostElement(int id)
        {
            return GetAllPostElements().Where(p => p.PostId == id).FirstOrDefault();
        }

        public Post CreatePost(Post post)
        {
            postRepo.CreateOneElementInDb(post);
            return post;
        }

        public Post DeletePost(int id)
        {
            Post postToDelete = GetOnePostElement(id);
            postRepo.DeleteOneElementInDb(postToDelete);
            return postToDelete;
        }

        public Post ChangeScoreOfPost(int id, int number)
        {
            Post postToChange = GetOnePostElement(id);
            postToChange.Score += number;
            postRepo.UpdateOneElementInDb(postToChange);
            return postToChange;
        }

        public Post ChangePost(int id, Post inputPost)
        {
            Post postToChange = GetOnePostElement(id);
            if (inputPost.Title != null)
            {
                postToChange.Title = inputPost.Title;
            }
            if (inputPost.Url != null)
            {
                postToChange.Url = inputPost.Url;
            }
            postRepo.UpdateOneElementInDb(postToChange);
            return postToChange;
        }
    }
}
