using System;
using System.Collections.Generic;
using System.Text;

namespace BookShoppingLib.DAL
{
   public class InMemoryBookShoppingRepository: IBookShoppingRepository
    {
       

        public readonly List<Book> Books = new List<Book>()
        {
            new Book("Harry Potter à l'école des sorciers.", 8),
            new Book("Harry Potter et la chambre des secrets.", 8),
            new Book("Harry Potter et le prisonnier d'Azkaban.", 8),
            new Book("Harry Potter et la coupe de feu.", 8),
            new Book("Harry Potter et le prince de sang-mêlé.", 8),

        };

        public List<Book> GetAllBooks()
        {
            return Books;
        }

        
        public void AddBook(Book book)
        {
            Basket basket = new Basket();
            booksBasket.Add(book);
        }
        public  List<Book> booksBasket = new List<Book>();

        public List<Book> GetBasketBooks()
        {
            return booksBasket;
        }

        public int CalculateFinalPrice()
        {
            Book book = new Book("test", 8);
            return book.unitPrice * booksBasket.Count;

             
        }
    }
}
