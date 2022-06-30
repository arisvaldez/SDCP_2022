﻿using Core.Books;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SDC_Book_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Retrieve()
        {
            IEnumerable<Book> books = new List<Book>()
            {
                new Book("Titulo", "1234",new string[]{ "Feliz Bautista" })
            };

            return Ok(books);
        }
    }
}
