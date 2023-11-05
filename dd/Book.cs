using System;
using System.Collections.Generic;

namespace LibraryManagmentSystem
{
    class Book
    {
        private static int nextId = 1;
        public string Title { get; set; }
        public string Author { get; set; }
        public int Id { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(string title, string author,  int year)
        {
            Title = title;
            Author = author;
            Id = nextId++;
            Year = year;
        }
    }

}
