using System;
using System.Collections.Generic;
using System.Text;

namespace Revision
{
    internal enum BookStatus
    {
        Borrowed,
        NotBorrowed
    }

    internal class BorrowBook : Book
    {
        //public BorrowBook(string iSBN, string title, string description, string author, long price, int quantity, int categoryId, BookStatus status) : base(iSBN, title, description, author, price, quantity, categoryId)
        //{
        //    Status = status;
        //}

        public BookStatus Status { get; set; }
    }
}
