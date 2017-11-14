using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxApp.Models;

namespace FoxApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeamId{ get; set; }
        public int ClassId { get; set; }
    }
}
