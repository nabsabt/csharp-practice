using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace csharp
{
    class FileHandler
    {
        public void fileHandler(string path)
        {
            var pathVar = path;
            void fileAttributes()
            {
                var attributes = File.GetAttributes(pathVar);
                Console.WriteLine(attributes);
            }

            void fileRead()
            {
                /*
                var readFile = File.ReadAllLines(pathVar);
                Console.WriteLine(readFile);
                */
                string fileText = System.IO.File.ReadAllText(path);
                
                Console.WriteLine(fileText);

            }

            void fileExists()
            {
                var boolean = File.Exists(pathVar);
                if(boolean == true)
                {
                    Console.WriteLine("the file exists");
                }
                else
                {
                    Console.WriteLine("The file does not exist");
                }
            }

            Console.WriteLine("Enter the correct code, seen below: ");
            Console.WriteLine("1: file attributes" + "\n" + "2: read file" + "\n" + "3:check, if file exists");
            int number = Int32.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    fileAttributes();
                    break;
                case 2:
                    fileRead();
                    break;
                case 3:
                    fileExists();
                    break;
            }
        }
    }
}
