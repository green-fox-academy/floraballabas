using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieApp
{
    class Sharpie
    {
        private string name;
        private string color;
        private float width;
        private float inkAmount = 100;
        private bool usable;

        public Sharpie(string color, float width, string name)
        {
            this.name = name;
            this.color = color;
            this.width = width;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public bool Usable
        {
            get
            {
                return this.usable;
            }
            set
            {
                usable = value;
            }
        }
        public float InkAmount
        {
            get
            {
                return this.inkAmount;
            }
        }
        public void Use()
        {
            inkAmount -= 100;
        }
    }
}
