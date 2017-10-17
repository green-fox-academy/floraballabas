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

        public abstract void Sound();

        public override void Play()
        {
            Console.WriteLine("{0}, a {1}-stringed instrument that {2}s");
        }
    }
}
