using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxApp.Models;

namespace FoxApp.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int ClassId { get; set; }
    }
}
