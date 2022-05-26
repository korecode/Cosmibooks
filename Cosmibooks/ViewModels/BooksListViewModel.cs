using Cosmibooks.Data.Models;
using System.Collections.Generic;

namespace Cosmibooks.ViewModels
{
    public class BooksListViewModel
    {

        public IEnumerable<Book> allBooks { get; set;  }

        public string currCategory { get; set; }
    }
}
