using Cosmibooks.Data.Models;
using System.Collections.Generic;

namespace Cosmibooks.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> favBooks { get; set; }
    }
}
