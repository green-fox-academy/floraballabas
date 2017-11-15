using RedditApi.Entities;
using RedditApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApi.Repositories
{
    public class PostRepository
    {
        PostContext PostContext;

        public PostRepository(PostContext postContext)
        {
            PostContext = postContext;
        }

        public List<Post> ListPosts()
        {
            return PostContext.Reddit.ToList();
        }

        public void AddNewPost(Post post)
        {
            PostContext.Reddit.Add(post);
            PostContext.SaveChanges();
        }

        public Post GetPostById(long id)
        {
            var selectedPost = PostContext.Reddit.FirstOrDefault(post => post.Id == id);
            return selectedPost;
        }

        public void UpVote(long id)
        {
            var post = GetPostById(id);

            post.Score++;

            PostContext.Reddit.Update(post);
            PostContext.SaveChanges();
        }

        public void DownVote(long id)
        {
            var post = GetPostById(id);

            post.Score--;

            PostContext.Reddit.Update(post);
            PostContext.SaveChanges();
        }

        public void Delete(long id)
        {
            var post = GetPostById(id);

            PostContext.Reddit.Remove(post);
            PostContext.SaveChanges();
        }

        public void UpdateTitle(long id, Post post)
        {
            var selectedPost = GetPostById(id);

            selectedPost.Title = post.Title;

            PostContext.Reddit.Update(selectedPost);
            PostContext.SaveChanges();
        }
    }
}
