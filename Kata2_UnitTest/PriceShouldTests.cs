using BookShoppingLib;
using BookShoppingLib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BookShopping_UnitTest
{
    public class PriceShouldTests
    {
        private readonly IBookShoppingRepository _repo = new InMemoryBookShoppingRepository();
        
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 8)]
        [InlineData(2, 16)]
        [InlineData(4, 32)]
        [InlineData(5, 40)]
        [InlineData(7, 56)]
        [InlineData(8, 64)]



        public void MultipleOfEight(int numberOfBook, int expected)
        {
            var basket = new Basket();
            var book = new Book("test",8, Guid.NewGuid());
            for (int i = 0; i < numberOfBook; i++)
            {
                basket.AddBook(book);
               
            }
            
            var multipleOfEight = basket.CalculateFinalPrice();
            Assert.Equal(multipleOfEight, expected);
        }

        [Fact]
        public void WhenGettingAllBooksShoudReturnAll()
        {
            // Arrange
            InMemoryBookShoppingRepository inMemoryBookShoppingRepository = new InMemoryBookShoppingRepository();
            // Act
            var books = inMemoryBookShoppingRepository.GetAllBooks();

            // Assert
            Assert.Equal(inMemoryBookShoppingRepository.Books.Count(), books.Count());
        }

    }
}
