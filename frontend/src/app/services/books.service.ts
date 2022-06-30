import { Book } from 'src/app/models/book.model';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  private baseURL: string = `${environment.api}/books`;
  
  constructor(private readonly httpClient: HttpClient) { }

  public getBooks():Observable<Book[]> {
    return this.httpClient.get<Book[]>(this.baseURL);
  }
}
