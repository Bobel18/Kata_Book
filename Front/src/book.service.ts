import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { IBook } from './book';
import { BasketComponent } from './app/basket/basket.component';

@Injectable({
    providedIn: 'root'
  })


export class BookService {
 
    private headers: HttpHeaders;
  private accessPointUrl = 'https://localhost:44304/api/Book';

  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
}

private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      return of(result as T);
    };

}
public getAllBooks(): Observable<IBook[]> {
  const url = `${this.accessPointUrl}/GetAllBooks`;
    return this.http.get<IBook[]>(url, { headers: this.headers }).pipe(
      catchError(this.handleError<IBook[]>('book', [])));
}
public AddBook(book: IBook): Observable<IBook> {
  const url = `${this.accessPointUrl}/AddBook`;
    return this.http.post<IBook>(url, book, { headers: this.headers }).pipe(
      catchError(this.handleError<IBook>('book')));
}

// public GetBasketBooks(): Observable<IBook[]> {
//   const url = `${this.accessPointUrl}/GetBasketBooks`;
//     return this.http.get<IBook[]>(url, { headers: this.headers }).pipe(
//       catchError(this.handleError<IBook[]>('basket')));
// }
public CalculateFinalPrice(): Observable<number> {
  const url = `${this.accessPointUrl}/CalculateFinalPrice`;
    return this.http.get<number>(url, { headers: this.headers }).pipe(
      catchError(this.handleError<number>('basket')));
}


}