﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    public class Flower : Plant
    {
        public Flower(int color)
        {
            base.color = COLORS[color];
            waterAbsorb = 0.75;
        }
    }
}
