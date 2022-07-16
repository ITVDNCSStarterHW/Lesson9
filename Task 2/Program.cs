using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            Random rnd = new Random();

            Console.WriteLine("Select the size of the array");
            arraySize = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arraySize];

            for (int count = 0; count <= array.Length - 1; count++)
            {
                int value = rnd.Next(0, 10);
                array[count] = value;
            }

            for (int count = 0; count <= array.Length - 1; count++)
            {
                Console.Write("{0}, ", array[count]);
            }
            Console.Write("\n");

            int minValue = array[0];
            for (int count = 0; count < array.Length; count++)
            {
                if (array[count] < minValue)
                {
                    minValue = array[count];
                }
            }
            Console.WriteLine(minValue);

            int maxValue = array[0];
            for (int count = 0; count < array.Length; count++)
            {
                if (array[count] > maxValue)
                {
                    maxValue = array[count];
                }
            }
            Console.WriteLine(maxValue);

            int sum = 0;
            for (int count = 0; count < array.Length; count++)
            {
                sum = sum + array[count];
            }
            Console.WriteLine(sum);

            double arithMean = 0;
            for (int count = 0; count < array.Length; count++)
            {
                arithMean = sum / array.Length;
            }
            Console.WriteLine(arithMean);

            Console.Write("Odd nummbers of array: ");
            for (int count = 0; count < array.Length; count++)
            {
                if (array[count] % 2 != 0)
                {
                    Console.Write("{0}, ", array[count]);
                }
            }
            
            Console.ReadLine();
        }
    }
}
