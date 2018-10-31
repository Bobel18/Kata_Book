Feature: Calculating basket price
In order to know final price
As a buyer
I want to know the price of my basket according to my book number

Scenario Outline: Calculating basket's price according to book's number
When I put a <numberOfBook> in my basket
Then The final price should be a <numberMultipleOfEight>
Examples: 
| numberOfBook | numberMultipleOfEight |
| 1      | 8                     |
| 2      | 16                    |
| 4      | 32                    |
| 5      | 40                    |
| 7      | 56                    |

Scenario: Verify the number of book
When I ask a number Of Book
Then The result should be the length of the list of books