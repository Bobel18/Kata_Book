import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookComponent } from './book/book.component';
import { BasketComponent } from './basket/basket.component';

const routes: Routes = [
  { path: 'book', component: BookComponent},
  { path: 'basket', component: BasketComponent },
  { path: '', redirectTo: 'book', pathMatch: 'full'},
 { path: '**', redirectTo: 'absences', pathMatch: 'full' },
];




@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
