using BookShoppingLib;
using BookShoppingLib.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BookShopping_UnitTest

{
    [Binding]
    public sealed class StepDefinition
    {


        public int FinalPrice
        {
            get => ScenarioContext.Current.Get<int>(nameof(FinalPrice));
            set => ScenarioContext.Current.Set(value, nameof(FinalPrice));
        }
        [When(@"I put a (.*) in my basket")]
        public void WhenIPutAInMyBasket(int numberOfBook)
        {
            Book book = new Book("test",8);
            FinalPrice = numberOfBook * book.unitPrice;
        }

        [Then(@"The final price should be a (.*)")]
        public void ThenTheFinalPriceShouldBeA(int multipleOfEight)
        {
            Assert.AreEqual(multipleOfEight, FinalPrice);
        }


        public int Quantity
        {
            get => ScenarioContext.Current.Get<int>(nameof(Quantity));
            set => ScenarioContext.Current.Set(value, nameof(Quantity));
        }
       InMemoryBookShoppingRepository memoryBookShoppingRepository = new InMemoryBookShoppingRepository();

        [When(@"I ask a number Of Book")]
        public void WhenIAskA()
        {
            Quantity = memoryBookShoppingRepository.GetAllBooks().Count();
        }

       

        [Then(@"The result should be the length of the list of books")]
        public void ThenTheResultShouldBeTheLengthOfTheListOfBooks()
        {
           int Bookscount = memoryBookShoppingRepository.Books.Count();
            Assert.AreEqual(Bookscount, Quantity);
        }



    }
}
