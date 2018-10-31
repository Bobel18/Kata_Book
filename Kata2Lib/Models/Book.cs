using System;
using System.Collections.Generic;
using System.Text;

namespace BookShoppingLib
{
    public class Book
    { // I declare properties
       public string Title { get; set; }
       public int unitPrice { get; set; }
        //I have done a default constructor
        public Book()
        {
        }
        //I do constructor with 2 parameters
        public Book(string title, int price)
        {
            Title = title;
            unitPrice = price;
        }
    }
}
