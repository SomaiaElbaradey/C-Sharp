using System;
using System.Linq;
using System.Linq.Expressions;

namespace LINQ
{
    class Program
    {
        static IQueryable<IGrouping<string, object>> FindBooksSorted(string publisher, string sortMethod)
        {
            var x = Expression.Parameter(typeof(Book), "x");
            MemberExpression body = Expression.PropertyOrField(x, "Price");
            switch (sortMethod)
            {
                case "Price":
                    body = Expression.PropertyOrField(x, "Price");
                    break;
                case "Title":
                    body = Expression.PropertyOrField(x, "Title");
                    break;
                case "Subject":
                    body = Expression.PropertyOrField(x, "Subject"); 
                    break;
                case "PublicationDate":
                    body = Expression.PropertyOrField(x, "PublicationDate");
                    break;
                case "PageCount":
                    body = Expression.PropertyOrField(x, "PageCount");
                    break;
                case "Authors":
                    body = Expression.PropertyOrField(x, "Authors");
                    break;
                case "Publisher":
                    body = Expression.PropertyOrField(x, "Publisher");
                    break;
            }

            var Books = SampleData.Books;
            var lambda = Expression.Lambda<Func<Book, string>>(body, x);
            var query8 = Books.AsQueryable().Where(i => i.Publisher.Name == publisher).GroupBy(lambda).Select(w => w);
            return query8;
        }
        static void Main(string[] args)
        {
            var Books = SampleData.Books;

            //book title and its ISBN.
            Console.WriteLine("Displaying the books: ");
            var Q01 = from item in Books
                      select new { item.Title, item.Isbn };
            foreach (var item in Q01)
            {
                Console.WriteLine(item);
            }

            //the first 3 books with price more than 25.
            Console.WriteLine("first 3 books with price more than 25: ");
            var Q02 = Books.Where(book => book.Price > 25).Take(3);
            foreach (var item in Q02)
            {
                Console.WriteLine(item);
            }

            //Book title along with its publisher name.
            Console.WriteLine("book with publisher: ");
            var Q03 = Books.Select(book => new { book.Title, book.Publisher });
            foreach (var item in Q03)
            {
                Console.WriteLine(item);
            }

            //the number of books which cost more than 20.
            Console.WriteLine(" number of books which cost more than 20: ");
            var Q04 = Books.Where(book => book.Price > 20).Count();
            Console.WriteLine(Q04);

            //book title, price and subject name sorted by its subject name ascending and by its price descending.
            Console.WriteLine(" ordered by book and price: ");
            var Q05 = Books.OrderBy(bookName => bookName.Subject.Name)
                .ThenByDescending(bookPrice => bookPrice.Price).Select(book => new { Title = book.Title, Price = book.Price });
            foreach (var item in Q05)
            {
                Console.WriteLine(item);
            }

            //Display all subjects with books related to this subject.
            Console.WriteLine(" subjects with books related to this subject: ");
            var Q06 = Books.GroupBy(book => book.Subject.Name)
                .Select(i => i);
            foreach (var item in Q06)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item02 in item)
                {
                    Console.WriteLine($"{ item02}");
                }
            }

            //Display books grouped by publisher and Subject.
            Console.WriteLine("books grouped by publisher and Subject: ");
            var Q07 = Books.GroupBy(book => new { book.Publisher, book.Subject })
                .Select(i => i);
            foreach (var item in Q07)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item02 in item)
                {
                    Console.WriteLine($"{ item02}");
                }
            }

            //Ask the user for a publisher name & sorting method (sorting criteria (by Title, price, etc….) 
            //and sorting way (ASC. Or DESC.))…. And implement a function named FindBooksSorted() that displays
            //all books written by this Author sorted as the user requested.
            string publisher;
            string sortMethod;
            do
            {
                Console.WriteLine("Enter Publisher Name 'FunBooks' or 'Joe Publishing' or 'I Publisher':");
                publisher = Console.ReadLine();
            } while (!(publisher== "FunBooks" || publisher == "Joe Publishing" || publisher == "I Publisher"));
            do
            {
                Console.WriteLine("Enter sorting method by 'Title or Price or Publisher or Authors or PageCount or PublicationDate or Subject'");
                sortMethod = Console.ReadLine();
            } while (!(sortMethod == "Title" || sortMethod == "Price" || sortMethod == "Subject" || sortMethod == "Publisher" 
            || sortMethod == "Authors" || sortMethod == "PageCount" || sortMethod == "PublicationDate"));

            var Q08 = FindBooksSorted(publisher, sortMethod);
            Console.Clear();

            Console.WriteLine($"Books sorted by ${sortMethod}");
            foreach (var item in Q08)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item02 in item)
                {
                    Console.WriteLine($"{ item02}");
                }
            }
        }
    }
}