using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    public class Book
    {
        public int ID;
        public string Title;
        public string Author;
        public int Pages;
        public Book(int id, string title, string author, int pages)
        {
            ID = id;
            Title = title;
            Author = author;
            Pages = pages;
        }
    }
}
