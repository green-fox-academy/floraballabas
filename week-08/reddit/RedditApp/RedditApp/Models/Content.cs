using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Post { get; set; }
        public int Votes { get; set; }
        public DateTime Date { get; set; }

        public Content()
        {
            Date = DateTime.Now;
        }
    }
}
