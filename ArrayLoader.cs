using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    class ArrayLoader
    {
        public void arrayLoader(int numberOfItems)
        {
            int[] array = new int[numberOfItems];
            for (int i = 0; i<numberOfItems; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " value! (only integer pls)");
                int value = Int32.Parse(Console.ReadLine());
                array[i] = value;
            }
            Console.WriteLine("The loaded numbers are: ");
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
