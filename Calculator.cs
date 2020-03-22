using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    public class Calculator
    {

        int calcCode = 1;
        public void calculator(string calc, int a, int b)
        {
            int num1 = a;
            int num2 = b;
            string whatToDo = calc;
            //int calcCode = 1;

            if (whatToDo == "add")
            {
                calcCode = 1;
            }
            else if (whatToDo == "minus")
            {
                calcCode = 2;
            }
            else if (whatToDo == "multiply")
            {
                calcCode = 3;
            }
            else if (whatToDo == "devide")
            {
                calcCode = 4;
            }

            switch (calcCode)
            {
                case 1:
                    Console.WriteLine("Result is " + num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("Result is " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Result is " + num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("Result is " + num1 / num2);
                    break;

            }


        }
    }
}
