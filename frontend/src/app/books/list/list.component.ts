import { BooksService } from './../../services/books.service';
import { Component, OnInit } from '@angular/core';
import { Book } from 'src/app/models/book.model';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  public books:Book[] = [];

  constructor(private bookService:BooksService) { }

  ngOnInit(): void {
    this.bookService.getBooks().subscribe({
      next: (books:Book[]) => {
        this.books = books;
      }
    });
  }

  public get totalBooks():number{
    return this.books.length || 0;
  }
}
