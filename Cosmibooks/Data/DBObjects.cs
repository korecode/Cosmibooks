using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Cosmibooks.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cosmibooks.Data
{
    public class DBObjects
    {

        public static void Initial(AppDBContent content)
        {
            
            

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Book.Any())
            {
                content.AddRange(
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    },
                    new Book
                    {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "Книга моя",
                        longDesc = "Описание",
                        img = "/img/1.jpg",
                        price = 490,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Художественная"]
                    }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Художественная", desc = "Описание"},
                        new Category { categoryName = "Нехудожественная", desc = "Описание"},
                        new Category { categoryName = "Новеллы", desc = "Описание"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}
