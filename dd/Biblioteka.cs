using System;
namespace LibraryManagmentSystem
{
	class Biblioteka
	{
        private List<Book> books = new List<Book>();
        private List<Wypożyczenia> wypożyczenie = new List<Wypożyczenia>();

        public void AddBook(string title, string author, int year)
        {
            Book newBook = new Book(title, author, year);
            books.Add(newBook);
            Console.WriteLine("Książka dodana.");
        }
        public void ListBooks()
        {
            Console.WriteLine("Lista książek.");
            foreach (Book book in books)
            {
                string availability = book.IsAvailable ? "Dostępna" : "Niedostepna";
                Console.WriteLine($"Tytuł: {book.Title}, Autor: {book.Author}, Rok wydania: {book.Year}, Id: {book.Id}");

            }
            
        }
        public Book FindBookByTitle(string title)
        {
            return books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            
        }
        public bool CheckOutBook(string title, DateTime dueDate)
        {
            Book book = FindBookByTitle(title);
            if (book != null && book.IsAvailable)
            {
                book.IsAvailable = false;
                wypożyczenie.Add(new Wypożyczenia(book, dueDate));
                Console.WriteLine($"Książka '{book.Title}' wypożyczona pomyślnie. Termin: {dueDate}");
                return true;
            }
            else
            {
                Console.WriteLine("Książka niedostępna lub nie odnaleziona");
                return false;
            }
        }
        public void CheckInBook(string title)
        {
            Book book = FindBookByTitle(title);
            if (book != null && !book.IsAvailable)
            {
                book.IsAvailable = true;
                Wypożyczenia wypożyczenia = wypożyczenie.Find(l => l.Book == book);
                wypożyczenie.Remove(wypożyczenia);
                Console.WriteLine($"Książka '{book.Title}' sprawdzona.");

            }
        }


    }
}

