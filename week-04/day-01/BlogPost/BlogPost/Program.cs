using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
                //Create a few blog post objects:
                //"Lorem Ipsum" titled by John Doe posted at "2000.05.04."
                //Lorem ipsum dolor sit amet.
                //"Wait but why" titled by Tim Urban posted at "2010.10.10."
                //A popular long-form, stick - figure - illustrated blog about almost everything.
                //"One Engineer Is Trying to Get IBM to Reckon With Trump" titled by William Turton at "2017.03.28."
                //Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked 
                //to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t 
                //really into the whole organizer profile thing.
            var blogpost1 = new Blog_Post();
            var blogpost2 = new Blog_Post();
            var blogpost3 = new Blog_Post();

            blogpost1.Author = "Tim Urban";
            blogpost1.Title = "Wait but why";
            blogpost1.Text = "A popular long-form, stick - figure - illustrated blog about almost everything.";
            blogpost1.PublicationDate = "2010.10.10.";

            blogpost2.Author = "John Doe";
            blogpost2.Title = "Lorem Ipsum";
            blogpost2.Text = "Lorem ipsum dolor sit amet.";
            blogpost2.PublicationDate = "2000.05.04";

            blogpost3.Author = "William Turton";
            blogpost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blogpost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. " +
                "When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t " +
                "really into the whole organizer profile thing.";
            blogpost3.PublicationDate = "2017.03.28.";
        }
    }
}
