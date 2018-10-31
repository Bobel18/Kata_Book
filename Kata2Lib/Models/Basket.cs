using System;
using System.Collections.Generic;
using System.Text;

namespace BookShoppingLib
{

    public class Basket
    {
        
      // I had book in the basket 
    public void AddBook(Book book)
        {
            booksBasket.Add(book);
            
        }

        // I store books in basket in a list
       private List<Book> booksBasket= new List<Book>();


        
       

       public int CalculateFinalPrice()
        {
            Book book = new Book("test", 8);
            return book.unitPrice * booksBasket.Count;
           
        }
    }
}
