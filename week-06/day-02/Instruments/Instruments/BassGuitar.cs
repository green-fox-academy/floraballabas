using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            this.name = "Bass Guitar";
            this.numberOfStrings = 4;
        }
        public BassGuitar(int numberOfStrings)
        {
            this.name = "Bass Guitar";
            this.numberOfStrings = numberOfStrings;
        }
        public override string Sound()
        {
            return "Duumm-duumm-duumm";
        }
    }
}
