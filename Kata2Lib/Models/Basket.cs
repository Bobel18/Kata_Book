using BookShoppingLib.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShoppingLib
{

    public class Basket
    {
        InMemoryBookShoppingRepository _repo = new InMemoryBookShoppingRepository();
        
        public void AddBook(Book book)
        {
            _repo.AddBook(book);
            
        }


       public int CalculateFinalPrice()
        {
            if(_repo.booksBasket.Count !=0)
            {
                return _repo.booksBasket[0].unitPrice * _repo.booksBasket.Count;
            }
            return 0;
            
            
           
        }
    }
}
