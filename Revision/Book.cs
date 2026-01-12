using System;
using System.Collections.Generic;
using System.Text;

namespace Revision
{
    internal enum BookStatus
    {
        Unknown,
        Available,
        NotAvailable,
        Borrowed,
        NotBorrowed
    }

    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public long Price { get; set; }
        //public int Quantity { get; set; }
        public BookStatus Status { get; set; }
    }
}
