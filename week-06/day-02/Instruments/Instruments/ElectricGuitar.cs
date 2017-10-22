using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            this.name = "Electric Guitar";
            this.numberOfStrings = 6;
        }
        public ElectricGuitar(int numberOfStrings)
        {
            this.name = "Electric Guitar";
            this.numberOfStrings = numberOfStrings;
        }
        public override string Sound()
        {
            return "Twang";
        }
    }
}
