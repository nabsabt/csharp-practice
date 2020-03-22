using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    class Converter
    {
        public void converter(int value)
        {
            string strValue = value.ToString();
            int length = strValue.Length;
            Console.WriteLine("The converted string's length is: " + length);
        }
    }
}
