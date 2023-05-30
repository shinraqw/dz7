using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    public class Array_ : IOutput2
    {
        private int[] arr;

        public Array_(int[] arr)
        {
            this.arr = arr;
        }

        public void ShowEven()
        {
            Console.WriteLine("even numbers:");
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd (+)numbers:");
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    }
}