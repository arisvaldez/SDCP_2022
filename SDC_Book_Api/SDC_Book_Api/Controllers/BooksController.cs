using Core.Boundaries.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace SDC_Book_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult Retrieve()
        {
            var books = this._bookRepository.RetrieveAll();

            return Ok(books);
        }
    }
}
