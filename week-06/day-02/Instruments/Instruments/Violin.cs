using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            this.name = "Violin";
            this.numberOfStrings = 4;
        }
        public Violin(int numberOfStrings)
        {
            this.name = "Violin";
            this.numberOfStrings = 4;
        }
        public override string Sound()
        {
            return "Screeech";
        }
    }
}
