using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShoppingLib;
using BookShoppingLib.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShoppingWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookController : ControllerBase
    {
        private readonly InMemoryBookShoppingRepository _inMemoryBookShoppingRepository;
        public BookController(InMemoryBookShoppingRepository inMemoryBookShoppingRepository)
        {
            _inMemoryBookShoppingRepository = inMemoryBookShoppingRepository;
        }

        [HttpGet("[action]")]
        public List<Book> GetAllBooks()
        {
            return _inMemoryBookShoppingRepository.GetAllBooks();
        }


        
      
        [HttpPost("[action]")]
        public  void AddBook([FromBody]Book book)
        {
           _inMemoryBookShoppingRepository.AddBook(book);
                   
        }

        [HttpGet("[action]")]
        public List<Book> GetBasketBooks()
        {
            return _inMemoryBookShoppingRepository.GetBasketBooks();
        }

        [HttpGet("[action]")]
        public int CalculateFinalPrice()
        {
           return _inMemoryBookShoppingRepository.CalculateFinalPrice();
        }
    }
}