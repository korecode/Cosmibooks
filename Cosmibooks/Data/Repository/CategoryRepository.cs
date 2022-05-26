using Cosmibooks.Data.Interfaces;
using Cosmibooks.Data.Models;
using System.Collections.Generic;

namespace Cosmibooks.Data.Repository
{
    public class CategoryRepository : IBooksCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
