using RedditApp.Models;
using RedditApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Services
{
    public class RedditService
    {
        RedditRepository repo;
        private List<Post> postsToShow = new List<Post>();
        private static int currentPostToEdit;

        public RedditService(RedditRepository repo)
        {
            this.repo = repo;
        }

        public void Create(string url, string title)
        {
            Post post = new Post()
            {
                URL = url,
                Title = title,
                Rating = 0
            };
            repo.Create(post);
        }

        public List<Post> GetAllElement()
        {
            postsToShow = repo.GetAllElement().ToList();
            return postsToShow;
        }

        public void Like(int key)
        {
            Post updateThisPost = repo.GetT(key);
            updateThisPost.Rating++;
            repo.Update(updateThisPost);
        }

        public void Dislike(int key)
        {
            Post updateThisPost = repo.GetT(key);
            updateThisPost.Rating--;
            repo.Update(updateThisPost);
        }

        public void Edit(string title, string url)
        {
            Post editThisPost = repo.GetT(currentPostToEdit);
            if (title != null)
            {
                editThisPost.Title = title;
            }
            if (url != null)
            {
                editThisPost.URL = url;
            }
            repo.Update(editThisPost);
        }

        public void SetPostToEdit(int key)
        {
            currentPostToEdit = key;
        }

        public void Delete(int key)
        {
            Post deleteThisPost = repo.GetT(key);
            repo.Delete(deleteThisPost);
        }
    }
}
