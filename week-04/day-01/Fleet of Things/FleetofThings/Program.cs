using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            Console.Write("1. ");
            fleet.Add(new Thing("Get milk"));
            Console.Write("2. ");
            fleet.Add(new Thing("Remove the obstacles"));
            Console.Write("3. ");
            fleet.Add(new Thing("Stand up"));
            Console.Write("4. ");
            fleet.Add(new Thing("Eat lunch"));
            Console.ReadLine();
        }
        public void Print(List<Thing> Things)
        {
            Console.WriteLine(Things);
        }
    }
}
