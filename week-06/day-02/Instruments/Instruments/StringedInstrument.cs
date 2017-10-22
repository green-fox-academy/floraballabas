using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        abstract public string Sound();

        public override void Play()
        {
            Console.WriteLine("{0}, a {1}-stringed instrument that {2}s", name, numberOfStrings, Sound());
        }
    }
}
