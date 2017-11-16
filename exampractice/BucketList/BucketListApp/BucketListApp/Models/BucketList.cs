using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BucketListApp.Models
{
    public class BucketList
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        public bool IsPlanned { get; set; } = false;
        public bool IsAchieved { get; set; } = false;
    }
}
