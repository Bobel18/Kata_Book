import { Component, OnInit } from '@angular/core';
import { IBook } from 'src/book';
import { BookService } from 'src/book.service';


@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss']
})
export class BookComponent implements OnInit {

displayedColumns: string[] = ['Title', 'Price','Add'];

books: IBook[];
 
constructor(
    private bookService: BookService,
   
  ) { }

  ngOnInit() {
    this.bookService.getAllBooks().subscribe(r =>this.books = r);
    
  }

  AddBook(book:IBook){
    this.bookService.AddBook(book).subscribe();
 console.log(book);

 
  }
}
