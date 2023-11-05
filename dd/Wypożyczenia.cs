using System;
namespace LibraryManagmentSystem
{
	class Wypożyczenia
	{
		public Book Book { get; }
		public DateTime DueDate { get; set; }
		public Wypożyczenia(Book book, DateTime dueDate)
		{
			Book = book;
			DueDate = dueDate;

		} 
		
	}
}


