using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpieSetClass sharpiset = new SharpieSetClass();
            Sharpie sharpi1 = new Sharpie("blue", 30, "sharpi1");
            Sharpie sharpi2 = new Sharpie("green", 50, "sharpi2");
            Sharpie sharpi3 = new Sharpie("grey", 18, "sharpi3");
            Sharpie sharpi4 = new Sharpie("white", 48, "sharpi4");
            sharpiset.SharpieList.Add(sharpi1);
            sharpiset.SharpieList.Add(sharpi2);
            sharpiset.SharpieList.Add(sharpi3);
            sharpiset.SharpieList.Add(sharpi4);

            sharpi1.Use();
            sharpi3.Use();
            sharpiset.CountUsable(sharpiset.SharpieList);
            sharpiset.RemoveTrash(sharpiset.SharpieList);
            sharpiset.PrintOutSharpieList(sharpiset.SharpieList);
            Console.ReadLine();


        }
    }
}
