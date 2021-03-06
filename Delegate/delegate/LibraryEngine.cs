using System;
using System.Collections.Generic;
using System.Text;

namespace myDelegate
{
    class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book book in bList)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }
}
