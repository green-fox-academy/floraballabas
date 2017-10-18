using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Fox
    {
        private string color;
        private string name;
        private string type;

        public Fox(string name, string color, string type)
        {
            this.name = name;
            this.color = color;
            this.type = type;
        }

        public string Color
        {
            get
            {
                return color;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
        }
    }
}
