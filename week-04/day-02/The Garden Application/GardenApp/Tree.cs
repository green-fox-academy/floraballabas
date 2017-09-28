using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    public class Tree : Plant
    {
        public Tree(int color)
        {
            base.color = COLORS[color];
            waterAbsorb = 0.75;
        }
    }
}