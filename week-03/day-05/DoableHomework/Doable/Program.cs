using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doable
{
    class Program
    {
        static void Main(string[] args)
        {
            string tree1, tree2, tree3, tree4, tree5;
            tree1 = "beech,dark green,80,male";
            tree2 = "oak,light green,10,female";
            tree3 = "willow,yellow,62,male";
            tree4 = "walnut,dark green,70,female";
            tree5 = "chestnut,brown,130,male";

            var treeList = new List<string>() { tree1, tree2, tree3, tree4, tree5 };
        }
    }
}
