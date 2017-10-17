using System;
using System.Collections.Generic;

namespace Comparable
{
    public class Dominoes
    {
        static void Main(string[] args)
        {

            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));

            dominoes.Sort();
            foreach (var domino in dominoes)
            {
                Console.WriteLine(domino.GetDominoString());
            }
            Console.ReadLine();
        }
    }
}