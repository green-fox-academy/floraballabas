using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Fox class with 3 properties(name, type, color) Fill a list with at least 5 foxes, 
            //it's up to you how you name/create them! Write a LINQ Expression to find the foxes with green color! 
            //Write a LINQ Expression to find the foxes with green color and pallida type!
            var listOfFoxes = new List<Fox>();
            var fox1 = new Fox("Alpaga", "green", "pallida");
            var fox2 = new Fox("Oracle", "green", "pallida");
            var fox3 = new Fox("Rabbit", "green", "pallida");
            var fox4 = new Fox("Totoro", "green", "static");
            var fox5 = new Fox("FutureFox", "yellow", "FutureType");
            listOfFoxes.Add(fox1);
            listOfFoxes.Add(fox2);
            listOfFoxes.Add(fox3);
            listOfFoxes.Add(fox4);
            listOfFoxes.Add(fox5);

            QuerySyntaxForGreenFoxes(listOfFoxes);
            QuerySyntaxForGreenFoxesAndPallida(listOfFoxes);
            MethodSyntaxForGreenFoxes(listOfFoxes);
            MethodSyntaxForGreenFoxesAndPallida(listOfFoxes);
            Console.ReadLine();
        }

        public static void QuerySyntaxForGreenFoxes(List<Fox>listOfFoxes)
        {
            var listOfFoxesQuery = from fox in listOfFoxes
                                   where fox.Color == "green"
                                   select fox;
            foreach (var fox in listOfFoxesQuery)
            {
                Console.WriteLine("The green foxes are called: {0}", fox.Name);
            }
        }

        public static void QuerySyntaxForGreenFoxesAndPallida(List<Fox> listOfFoxes)
        {
            var listOfFoxesQuery2 = from fox in listOfFoxes
                                    where fox.Color == "green" && fox.Type == "pallida"
                                    select fox;

            foreach (var fox in listOfFoxesQuery2)
            {
                Console.WriteLine("The green foxes that have pallida type are called: {0}", fox.Name);
            }
        }

        public static void MethodSyntaxForGreenFoxes(List<Fox> listOfFoxes)
        {
            var listOfFoxesQueryWithLambda = listOfFoxes.Where(fox => fox.Color == "green").Select(fox => fox);

            foreach (var fox in listOfFoxesQueryWithLambda)
            {
                Console.WriteLine("The green foxes are called: {0}", fox.Name);
            }
        }

        public static void MethodSyntaxForGreenFoxesAndPallida(List<Fox> listOfFoxes)
        {
            var listOfFoxesQueryWithLambda2 = listOfFoxes.Where(fox => fox.Color == "green" && fox.Type == "pallida").Select(fox => fox);

            foreach (var fox in listOfFoxesQueryWithLambda2)
            {
                Console.WriteLine("The green foxes that have pallida type are called: {0}", fox.Name);
            }
        }
    }
}
