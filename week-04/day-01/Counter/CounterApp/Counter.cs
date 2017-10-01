using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterApp
{
    public class Counter
    {
        private int counterAmount;
        public Counter(int counterAmount = 0)
        {
            this.counterAmount = counterAmount;
        }
        public void AddByOne()
        {
            counterAmount++;
        }
        public void AddByParameter(int increase)
        {
            counterAmount += increase;
        }
        public void Get()
        {
            counterAmount.ToString();
        }
        public void Reset()
        {
            this.counterAmount = 0;
        }

        //Create Counter class
        //which has an integer property
        //when creating it should have a default value 0 or we can specify it when creating
        //we can Add(number) to this counter another whole number
        //or we can Add() without parameters just increasing the counter's value by one
        //and we can Get() the current value as string
        //also we can Reset() the value to the initial value
    }
}
