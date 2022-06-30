using Core.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Boundaries.Persistence
{
    public interface IBookRepository
    {
        public Task Persist(Book book);

        public IEnumerable<Book> RetrieveAll();
    }
}
