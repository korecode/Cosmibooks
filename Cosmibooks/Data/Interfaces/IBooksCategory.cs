using Cosmibooks.Data.Models;
using System.Collections.Generic;

namespace Cosmibooks.Data.Interfaces
{
    public interface IBooksCategory
    {

        IEnumerable<Category> AllCategories { get; }
    }
}
