using System;
using System.Collections.Generic;
using System.Text;

namespace myDelegate
{
    class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return $"Book Title: {book?.Title}";
        }
        public static string GetAuthors(Book book)
        {
            return $"Book Authors: {string.Join(", ", book?.Authors)}";
        }
        public static string GetPrice(Book book)
        {
            return $"Bokk Price: {book?.Price.ToString("C2")}";
        }
        public static string GetBook(string book)
        {
            return $"Bokk: {book}";
        }
        public static bool nameWithM(string book)
        {
            return book.Contains("M");
        }
        public static bool priceGt50(Book book)
        {
            return book.Price > 50;
        }
        public static bool authorsLt3(Book book)
        {
            return book.Authors.Length < 3;
        }
    }
}
