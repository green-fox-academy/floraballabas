using System;
using System.Collections.Generic;
using System.Text;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            // Accidentally we added "2" and "false" to the list. 
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines

            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            for (int i = 0; i < list.Count; i++)
            {
                if (i == 1)
                {
                    list[i] = "Croissant";
                }
                if (i == 3)
                {
                    list[i] = "Ice Cream";
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}