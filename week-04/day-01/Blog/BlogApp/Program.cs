using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogpost1 = new BlogPost("JK Rowling","Harry Potter", "Quidditch","2007");
            var blogpost2 = new BlogPost("GRRM", "AWOIAF", "For King Tommen", "2014");
            var blogpost3 = new BlogPost("Sapkowski", "Lady of the Lake", "Avalac'h looked at Geralt", "1999");
            var blogpost4 = new BlogPost("Sapkowski", "Midnight Tower", "Zirail look at me", "1998");

            Blog blog = new Blog();

            blog.Delete(0);
            blog.Update(1);
            blog.Print();
            Console.ReadLine();
        }
    }
}
