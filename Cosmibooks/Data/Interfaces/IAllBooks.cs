using Cosmibooks.Data.Models;
using System.Collections.Generic;

namespace Cosmibooks.Data.Interfaces
{
    public interface IAllBooks
    {

        IEnumerable<Book> Books { get; }
        IEnumerable<Book> getFavBooks { get;}

        Book getObjectBook (int bookId);
    }
}
