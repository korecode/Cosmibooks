using Cosmibooks.Data.Interfaces;
using Cosmibooks.Data.Models;
using System.Collections.Generic;

namespace Cosmibooks.Data.Mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Художественная", desc = "Описание"},
                    new Category { categoryName = "Нехудожественная", desc = "Описание"},
                    new Category { categoryName = "Новеллы", desc = "Описание"}
                };
            }
        }
    }
}
