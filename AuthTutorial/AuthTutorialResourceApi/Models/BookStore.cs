using System.Collections.Generic;

namespace AuthTutorialResourceApi.Models
{
    public class BookStore
    {
        public List<Book> Books => new List<Book>()
        {
            new Book {Id = 1, Author = "Ivanov", Title = "How to calm cum", Price = 228.45M},
            new Book {Id = 2, Author = "Petrov", Title = "Fucking niggers culture", Price = 1499.99M},
            new Book {Id = 4, Author = "Sidorov", Title = "Slave and masters relationship", Price = 499.90M},
            new Book {Id = 3, Author = "Zalupin", Title = "Why I haven't changed my surname", Price = 999.99M}
        };

        public Dictionary<int, int[]> Orders => new Dictionary<int, int[]>
        {
            {1, new[] {1, 3}},
            {2, new[] {1, 2, 4}}
        };
    }
}