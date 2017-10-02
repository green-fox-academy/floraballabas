using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp
{
    class BlogPost
    {
        private string author;
        private string title;
        private string text;
        private string publicationDate;

        public BlogPost(string author="Tolkien", string title="The Lord of the Rings", 
            string text="Sauron's Eye sees all", string publicationDate="1950")
        {
            this.author = author;
            this.title = title;
            this.text = text;
            this.publicationDate = publicationDate;
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
        public string PublicationDate
        {
            get
            {
                return publicationDate;
            }
            set
            {
                publicationDate = value;
            }
        }
    }
}
