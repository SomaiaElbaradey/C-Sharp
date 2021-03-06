using System;
using System.Collections.Generic;
using System.Text;

namespace myDelegate
{
    static class Reporistory
    {
        public static List<Book> GetBooks()
        {
            string[] authors = { "Joe", "Sam", "Anne" };
            string[] authors01 = { "Dan", "Mual", "Ashle" };
            string[] authors02 = { "Locen", "Phebe", "Chelr" };
            string[] authors03 = { "Lisa", "Mary" };
            string[] authors04 = { "Fual", "Mark" };

            return new List<Book>()
            {
            new Book("1205218FU", "Book01", authors, new DateTime(2015, 01, 03), 123.5M),
            new Book("7605218BY", "Book02", authors01, new DateTime(2012, 02, 05), 122.69M),
            new Book("5405218TR", "Book03", authors04, new DateTime(2011, 12, 08), 174M),
            new Book("4525218CE", "Book04", authors02, new DateTime(2010, 09, 07), 152M),
            new Book("1405245HR", "Book05", authors03, new DateTime(2009, 06, 03), 199.75M),
            new Book("9005218CV", "Book06", authors02, new DateTime(2005, 09, 03), 112.3M),
            };
        }
    }
}
