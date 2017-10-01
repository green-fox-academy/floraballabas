using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Lada = new Car();
            Car Trabant = new Car();
            Car Polski = new Car();
            Station Mol = new Station();
            Mol.Refill(Lada);
            Mol.Refill(Trabant);
            Mol.Refill(Polski);
            Console.WriteLine("Gas amount of the station: " + Mol.GasAmount + "\nGas amount of the cars: " + "\nLada: " + Lada.GasAmount
                             + "\nTrabant: " + Trabant.GasAmount + "\nPolski: " + Polski.GasAmount);
            Console.ReadLine();
        }
    }
}
