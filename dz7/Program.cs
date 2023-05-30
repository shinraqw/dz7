using dz7;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace dz7
{
    internal class Program
    {
        static void Main()
        {
            int a;
            do
            {
                Console.Write("Enter task : ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        Array myArrayObj = new Array(myArray);

                        int lessThanFive = myArrayObj.Less(5);
                        Console.WriteLine(" elements less than 5", lessThanFive);

                        int greaterThanSeven = myArrayObj.Greater(7);
                        Console.WriteLine(" elements greater than 7", greaterThanSeven);

                        break;
                    case 2:
                        int[] arr_ = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        Task2.Array_ array_ = new Task2.Array_(arr_);
                        array_.ShowEven();
                        array_.ShowOdd();
                        break;
                    case 3:
                        int[] data = { 1, 2, 3, 4, 5, 1, 2, 3 };
                        Task3._Array _array = new Task3._Array(data);
                        Console.Write("number for equal element array: ");
                        int equal = int.Parse(Console.ReadLine());
                        Console.WriteLine($"distinct values: {_array.CountDistinct()}");
                        Console.WriteLine($"values equal to {equal}: {_array.EqualToValue(equal)}");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (a < 1 || a > 3);
        }
    }
}