using System;
using System.Collections.Generic;
using System.Text;

namespace myDelegate
{
    class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            Price = _Price;
            PublicationDate = _PublicationDate;
        }
        public override string ToString()
        {
            return $"book: {Title}, ISBN: {ISBN}, its price: {Price.ToString("C2")}";
        }
    }
}
