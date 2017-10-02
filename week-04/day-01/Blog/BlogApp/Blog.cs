using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp
{
    class Blog
    {
        private List<BlogPost> blogList = new List<BlogPost>();

        public List<BlogPost> BlogList
        {
            get
            {
                return blogList;
            }
            set
            {
                blogList = value;
            }
        }
        public List<BlogPost> Delete(int indexToRemove)
        {
            blogList.RemoveAt(indexToRemove);
            return blogList;
        }
        public List<BlogPost> Update(int IndextoUpdate)
        {
            BlogPost newBlogPost = new BlogPost();
            blogList[IndextoUpdate] = newBlogPost;
            return blogList;
        }
        public void Print()
        {
            foreach (var blog in blogList)
            {
                Console.WriteLine("The author is: "+blog.Author+" the title: "+blog.Title+
                    " the text: "+blog.Text+" and the publication date is: "+blog.PublicationDate);
            }
        }
    }
}
