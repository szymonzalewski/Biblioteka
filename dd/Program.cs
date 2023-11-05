using System;
namespace LibraryManagmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteka library = new Biblioteka();

            while (true)
            {
                Console.WriteLine("\nSystem Biblioteczny.");
                Console.WriteLine("1. Dodaj książkę.");
                Console.WriteLine("2. Pokaż listę książek.");
                Console.WriteLine("3. Znajdz książkę po tytule.");
                Console.WriteLine("4. Wypożycz książkę.");
                Console.WriteLine("5. Zwrot książki.");
                Console.WriteLine("6. Wyjście.");
                Console.WriteLine("Wybierz opcję.");
                

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Wprowadż tytuł.");
                            string title = Console.ReadLine();
                            Console.WriteLine("Wprowadż autora.");
                            string author = Console.ReadLine();
                            Console.WriteLine("Wprowadż rok wydania.");
                            int year = Convert.ToInt32(Console.ReadLine());
                            library.AddBook(title, author,  year);
                            break;

                        case 2:
                            library.ListBooks();
                            break;

                        case 3:
                            Console.WriteLine("Wprowadż tytuł książki.");
                            string searchTitle = Console.ReadLine();
                            Book foundBook = library.FindBookByTitle(searchTitle);

                            if (foundBook != null )
                            {
                                Console.WriteLine($"Book found - Tytuł: {foundBook.Title}, Autor: {foundBook.Author}, Rok wydania: {foundBook.Year}, Id: {foundBook.Id}");
                            }
                            else
                            {
                                Console.WriteLine("Książka nie znaleziona.");
                            }

                            break;

                        case 4:
                            Console.Write("Podaj tytuł wypożyczenia");
                            string checkOutTitle = Console.ReadLine();
                            Console.Write("Podaj termin wypożyczenaia.");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
                            {
                               library.CheckOutBook(checkOutTitle, dueDate);
                            }
                            else
                            {
                                Console.WriteLine("Niepoprawny format. Proszę użyć rrrr-mm-dd.");
                            }

                            break;

                        case 5:
                            Console.Write("Wprowadż tytuł zwrotu: ");
                            string checkInTitle = Console.ReadLine();
                            library.CheckInBook(checkInTitle);
                            break;
                            


                        case 6:
                            Console.WriteLine("Wyjście z programu");
                            Environment.Exit(0);
                            break;
                    }




                }
                else
                {
                    Console.WriteLine("Niepoparwne wprowadzenie.");
                }


            }
        }
    }
}
		