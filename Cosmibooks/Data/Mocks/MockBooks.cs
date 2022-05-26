using Cosmibooks.Data.Interfaces;
using Cosmibooks.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cosmibooks.Data.Mocks
{
    public class MockBooks : IAllBooks
    {

        private readonly IBooksCategory _categoryBooks = new MockCategory();
        public IEnumerable<Book> Books
        { 
            get
            {
                return new List<Book>()
                {
                    new Book {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = _categoryBooks.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Book> getFavBooks { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Book getObjectBook(int bookId)
        {
            throw new System.NotImplementedException();
        }
    }
}
