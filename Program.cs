using System;
using System.Collections.Generic;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)


        {
            var start = DateTime.Now;
            var date = DateTime.Now;
            Console.WriteLine("Hello! The current time is " + date);

            Calculator calcObject = new Calculator();
            void localCalc()
            {
                Console.WriteLine("Type number 1, then press Enter!");
                int number1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Type number 2, then press Enter!");
                int number2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Type add, minus, multiply or devide!");
                string operating = Console.ReadLine();
                if(operating != "add" || operating != "minus" || operating!= "multiply" || operating != "devide")
                {
                    Console.WriteLine("Invalid operator is given!");
                    return;
                }
                calcObject.calculator(operating, number1, number2);
                

            }

            void localConverter()
            {
                Console.WriteLine("Type in the integer, you want to convert to string!");
                int number = Int32.Parse(Console.ReadLine());
                Converter convObj = new Converter();
                convObj.converter(number);

            }

            void localArrayLoader()
            {
                Console.WriteLine("How many items you want to load?");
                int itemNumber = Int32.Parse(Console.ReadLine());
                ArrayLoader loaderObj = new ArrayLoader();
                loaderObj.arrayLoader(itemNumber);
            }

            void localListLoader()
            {
                ListLoader listLoaderObj = new ListLoader();
                listLoaderObj.listLoader();
            }

            void localFileHandler()
            {
                FileHandler fileHandlerObj = new FileHandler();
                Console.WriteLine("Enter the file path: ");
                var path = Console.ReadLine();
                fileHandlerObj.fileHandler(path);
                
            }

            void localUser()
            {
                Console.WriteLine("How many users do you want to add?");
                int userNumber = Int32.Parse(Console.ReadLine());
                Dictionary<int, User> userDictionary = new Dictionary<int, User>();
                for (int i = 0; i< userNumber; i++)
                {
                    Console.Write("User name: ");
                    string name = Console.ReadLine();
                    Console.Write("User previlige: ");
                    string previlige = Console.ReadLine();
                    User userObj = new User()
                    {
                        ID = i,
                        Name = name,
                        Previlige = previlige

                    };
                    userDictionary.Add(userObj.ID, userObj);
                }
                foreach (KeyValuePair<int, User> kvp in userDictionary)
                {
                    Console.WriteLine("ID={0}, Name = {1}, Previlige = {2}", kvp.Key, kvp.Value.Name, kvp.Value.Previlige);
                    Console.WriteLine("-----------------------------------------------");
                }
            }

            void localBook()
            {
                Console.WriteLine("How many books do you want to add?");
                int numberOfBooks = Int32.Parse(Console.ReadLine());
                Dictionary<int, Book> bookDictionary = new Dictionary<int, Book>();
                for (int i = 0; i<numberOfBooks; i++)
                {
                    Console.Write("Book's title: ");
                    string bTitle = Console.ReadLine();
                    Console.Write("Book's author: ");
                    string bAuthor = Console.ReadLine();
                    Console.Write("Book's length (pages, integer): ");
                    int bPages = Int32.Parse(Console.ReadLine());
                    Book bookObj = new Book(i,bTitle,bAuthor,bPages);
                    bookDictionary.Add(i, bookObj);

                }
                foreach(KeyValuePair<int, Book> kvp in bookDictionary)
                {
                    Console.WriteLine("ID={0}, Title = {1}, Author = {2}, Pages = {3}", kvp.Key, kvp.Value.Title, kvp.Value.Author, kvp.Value.Pages);
                    Console.WriteLine("-----------------------------------------------");
                }
            }
            ////////////////////////////////////////////
            ///

            Console.WriteLine("Hi! Please, enter 1, if you want to calculate, 2, if you want to convert integer to string, 3, if you want to load up an array, 4, if you want to load a list, 5, if want to handle file, 6 if you want to load user table or 7 if you want to add books!");
            string inputStr = Console.ReadLine();
            int input = Int32.Parse(inputStr);
            switch (input)
            {
                case 1:
                    localCalc();
                    break;
                case 2:
                    localConverter();
                    break;
                case 3:
                    localArrayLoader();
                    break;
                case 4:
                    localListLoader();
                    break;
                case 5:
                    localFileHandler();
                    break;
                case 6:
                    localUser();
                    break;
                case 7:
                    localBook();
                    break;
                default:
                    Console.WriteLine("incorrect input");
                    break;
            }

            var end = DateTime.Now;
            var duration = end - start;
            Console.WriteLine("The program had a running intervall of " + duration + " (hours:seconds:miliseconds)");

        }
    }

    
}
