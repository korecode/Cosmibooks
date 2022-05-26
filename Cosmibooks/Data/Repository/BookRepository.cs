using Microsoft.EntityFrameworkCore;
using Cosmibooks.Data.Interfaces;
using Cosmibooks.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cosmibooks.Data.Repository
{
    public class BookRepository : IAllBooks
    {

        private readonly AppDBContent appDBContent;
        
        public BookRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Book> Books => appDBContent.Book.Include(c => c.Category);

        public IEnumerable<Book> getFavBooks => appDBContent.Book.Where(prop => prop.isFavourite).Include(c => c.Category);

        public Book getObjectBook(int bookId) => appDBContent.Book.FirstOrDefault(p => p.id == bookId);
    }
}
