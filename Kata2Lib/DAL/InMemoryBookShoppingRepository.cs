using System;
using System.Collections.Generic;
using System.Text;

namespace BookShoppingLib.DAL
{
   public class InMemoryBookShoppingRepository: IBookShoppingRepository
    {
       // I create my book's list

        public readonly List<Book> Books = new List<Book>()
        {
            new Book("Harry Potter à l'école des sorciers.", 8, Guid.NewGuid()),
            new Book("Harry Potter et la chambre des secrets.", 8, Guid.NewGuid()),
            new Book("Harry Potter et le prisonnier d'Azkaban.", 8, Guid.NewGuid()),
            new Book("Harry Potter et la coupe de feu.", 8, Guid.NewGuid()),
            new Book("Harry Potter et le prince de sang-mêlé.", 8, Guid.NewGuid()),

        };

        public List<Book> GetAllBooks()
        {
            return Books;
        }

        // I add book in my basket
        public void AddBook(Book book)
        {
           booksBasket.Add(book);
        }
        // I store added books of my basket in a new list
        public  List<Book> booksBasket = new List<Book>();

        // I 
        public List<Book> GetBasketBooks()
        {
            return booksBasket;
        }

        
        public int CalculateFinalPrice()
        {
            if (booksBasket.Count != 0)
            { // Aller chercher le book qui existe dans mon Repository
                return booksBasket[0].unitPrice * booksBasket.Count;
            }
            return 0;
        }
    }
}
