using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditApp.Entities;
using RedditApp.Models;

namespace RedditApp.Repositories
{
    public class ContentRepository
    {
        ContentContext contentContext;
        public ContentRepository(ContentContext contentContext)
        {
            this.contentContext = contentContext;
        }

        public List<Content> GetList()
        {
            return contentContext.Contents.OrderByDescending(x => x.Votes).ToList();
        }

        public void AddPost(string post)
        {
            var content = new Content()
            {
                Post = post
            };
            contentContext.Contents.Add(content);
            contentContext.SaveChanges();
        }

        public Content GetId(int id)
        {
            return contentContext.Contents.FirstOrDefault(x => x.Id == id);
        }

        public void DeletePost(int id)
        {
            contentContext.Contents.Remove(GetId(id));
            contentContext.SaveChanges();
        }

        public void UpdatePost(Content content)
        {
            contentContext.Contents.Update(content);
            contentContext.SaveChanges();
        }

        internal void Vote(string direction, int id)
        {
            var post = contentContext.Contents.Where(r => r.Id == id).FirstOrDefault();
            if (direction.Equals("up"))
            {
                post.Votes++;
            }
            else if (direction.Equals("down"))
            {
                post.Votes--;
            }

            contentContext.Contents.Update(post);
            contentContext.SaveChanges();
        }
    }
}
