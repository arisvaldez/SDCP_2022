import { BookRoutingModule } from './book-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register/register.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    RegisterComponent
  ],
  imports: [
    CommonModule,
    BookRoutingModule,
    ReactiveFormsModule
  ]
})
export class BooksModule { }
