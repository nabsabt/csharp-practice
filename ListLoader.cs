using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    class ListLoader
    {
        public void listLoader()
        {
            var numberList = new List<int>() { };
            Console.WriteLine("Start to enter the numbers you want to load in the List!");
            Console.WriteLine("Enter number 666, when you finished loading numbers!");
            int number = 0;
            while (number !=666)
            {
                number = Int32.Parse(Console.ReadLine());
                numberList.Add(number);
            }
            int length = numberList.Count;
            numberList.RemoveAt(length-1);
            Console.Write("Your list is: ");
            foreach(var o in numberList)
            {
                Console.Write(o);
                Console.Write(", ");
            }
            Console.WriteLine("the length of your list is: " + (length-1));
            
        }
    }
}
