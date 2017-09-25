using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_It
{
    class Program
    {
        static void Main(string[] args)
        {
            PostStruct poststruct1;
            PostStruct poststruct2;
            PostStruct poststruct3;

            poststruct1.BackgroundColor = "orange";
            poststruct1.Text = "New idea";
            poststruct1.Textcolor = "black";

            poststruct2.BackgroundColor = "pink";
            poststruct2.Text = "Awesome";
            poststruct2.Textcolor = "blue";

            poststruct3.BackgroundColor = "yellow";
            poststruct3.Text = "Superb";
            poststruct3.Textcolor = "green";
        }
    }
}
