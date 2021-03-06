using System;
using System.Collections.Generic;

namespace myDelegate
{
    class Program
    {
        public delegate string printInfoDelegate(Book book);
        public delegate string genericDelegate<in T>(T book);

        static void Main(string[] args)
        {
            //non generic delegate
            string[] authors = { "Joe", "Sam", "Anne" };
            Book book1 = new Book("1205218CD", "My Book", authors, new DateTime(2015, 12, 03), 12.5M);
            //declare the delegate 
            printInfoDelegate bPtr;
            //define object from the delegate and invoke it
            bPtr = new printInfoDelegate(BookFunctions.GetAuthors);
            string msg = bPtr.Invoke(book1);
            Console.WriteLine(msg);
            bPtr = BookFunctions.GetPrice;
            Console.WriteLine(bPtr.Invoke(book1));
            bPtr = new printInfoDelegate(BookFunctions.GetTitle);
            Console.WriteLine(bPtr(book1));

            //generic user defined delegate
            genericDelegate<string> bPtr01 = BookFunctions.GetBook;
            Console.WriteLine(bPtr01(book1.Title));

            //generic delegate
            //Predicate
            Book B1 = new Book("1205218FU", "Book M", authors, new DateTime(2015, 01, 03), 23.5M);

            Predicate<string> bptr02 = new Predicate<string>(BookFunctions.nameWithM);
            Console.WriteLine($"is Book contains M? {bptr02(B1?.Title)}");

            Predicate<Book> bptr03 = BookFunctions.priceGt50;
            Console.WriteLine($"is Book price greater than 50? {bptr03(B1)}");

            Predicate<Book> bptr04 = BookFunctions.authorsLt3;
            Console.WriteLine($"is Book authors less than 3? {bptr04(B1)}");

            Predicate<string> predicate2 = a => a.Length > 10;
            Console.WriteLine(predicate2("Somaia"));

            //Func delegate 
            List<Book> bookList = Reporistory.GetBooks();
            LibraryEngine.ProcessBooks(bookList, BookFunctions.GetPrice);
            LibraryEngine.ProcessBooks(bookList, BookFunctions.GetAuthors);

            //Action
            Action action1 = () => Console.WriteLine("Action Delegate");
            action1();
            Action<int, string> action2 = (age, name) => Console.WriteLine($"{name} is {age} years old");
            action2.Invoke(22, "Somaia");
        }
    }
}