using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Greeting
    {
        public long ID { get; set; }
        public string Content { get; set; }

        public Greeting(long id, string content)
        {
            ID = id;
            Content = content;
        }
    }
}
