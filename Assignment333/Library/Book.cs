using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Enum for Book Status
    public enum BookStatus
    {
        Available,
        CheckedOut,
        Reserved
    }

namespace Assignment333.Library
{


    // Book class
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }

        public Book(string title, string author, BookStatus status)
        {
            Title = title;
            Author = author;
            Status = status;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Status: {Status}");
        }
    }

    // Library class with indexer
    public class LibraryManager
    {
        private List<Book> books = new List<Book>();

        // Add a book to the library
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // Indexer to access book by title
        public Book this[string title]
        {
            get
            {
                return books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            }
        }

        // Change the status of a book
        public void ChangeStatus(string title, BookStatus newStatus)
        {
            Book book = this[title];
            if (book != null)
            {
                book.Status = newStatus;
            }
            else
            {
                Console.WriteLine($"Book titled '{title}' not found.");
            }
        }

        // Show books by status
        public void ShowBooksByStatus(BookStatus status)
        {
            Console.WriteLine($"\nBooks with status: {status}");
            foreach (var book in books)
            {
                if (book.Status == status)
                {
                    book.ShowDetails();
                }
            }
        }
    }

    // Demonstration
}
