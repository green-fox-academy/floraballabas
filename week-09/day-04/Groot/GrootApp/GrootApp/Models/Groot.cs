using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrootApp.Models
{
    public class Groot
    {
        public string Message { get; set; }

        public Groot(string message)
        {
            Message = message;
        }
    }
}
