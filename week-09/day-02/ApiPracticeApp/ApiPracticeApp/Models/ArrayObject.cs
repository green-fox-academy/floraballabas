using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPracticeApp.Models
{
    public class ArrayObject
    {
        public int[] Number { get; set; }
        public string Action { get; set; }

        public int Sum(int[] numbers)
        {
            int sum = 0;

            foreach (var n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        public int Multiply(int[] numbers)
        {
            int multi = 1;

            foreach (var n in numbers)
            {
                multi *= n;
            }
            return multi;
        }

        public int[] Double(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }
            return numbers;
        }
    }
}
