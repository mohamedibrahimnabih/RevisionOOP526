using System;
using System.Collections.Generic;
using System.Text;

namespace Revision
{
    internal class Book
    {
        //public Book(string iSBN, string title, string description, string author, long price, int quantity, int categoryId)
        //{
        //    ISBN = iSBN;
        //    Title = title;
        //    Description = description;
        //    Author = author;
        //    Price = price;
        //    Quantity = quantity;
        //    CategoryId = categoryId;
        //}

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public long Price { get; set; }
        public int Quantity { get; set; }

        public string CategoryName { get; set; }
    }
}
