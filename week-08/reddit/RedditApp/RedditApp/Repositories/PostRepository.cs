using RedditApp.Entities;
using RedditApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Repositories
{
    public class PostRepository
    {
        ContentContext contentContext;

        public PostRepository(ContentContext contentContext)
        {
            this.contentContext = contentContext;
        }

        public List<Content> ListPost()
        {
            return contentContext.Contents.ToList();
        }

        public void AddNewPost(Content content)
        {
            contentContext.Contents.Add(content);
            contentContext.SaveChanges();
        }

        public Content GetPostById(int id)
        {
            var selectedPost = contentContext.Contents.FirstOrDefault(post => post.Id == id);
            return selectedPost;
        }

        public void UpVote(int id)
        {
            var post = GetPostById(id);

            post.Votes++;

            contentContext.Contents.Update(post);
            contentContext.SaveChanges();
        }

        public void DownVote(int id)
        {
            var post = GetPostById(id);

            post.Votes--;

            contentContext.Contents.Update(post);
            contentContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var post = GetPostById(id);

            contentContext.Contents.Remove(post);
            contentContext.SaveChanges();
        }

        public void UpdateTitle(int id, Content content)
        {
            var selectedPost = GetPostById(id);

            selectedPost.Post = content.Post;

            contentContext.Contents.Update(selectedPost);
            contentContext.SaveChanges();
        }
    }
}
