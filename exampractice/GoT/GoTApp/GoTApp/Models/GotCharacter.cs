using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoTApp.Models
{
    public class GoTCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsLikeable { get; set; } = false;
        public bool IsAlive { get; set; } = true;
    }
}
