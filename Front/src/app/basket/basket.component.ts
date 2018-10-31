import { Component, OnInit, Input } from '@angular/core';
import { BookService } from 'src/book.service';

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.scss']
})
export class BasketComponent implements OnInit {
  finalPrice: number;

Books:any;
  constructor(private bookService: BookService,) { }

  ngOnInit() {
    //this.bookService.GetBasketBooks().subscribe(bks => this.Books = bks)
    this.bookService.CalculateFinalPrice().subscribe(data => this.finalPrice = data);
    console.log(this.finalPrice);
  }

}
