using System;
using System.Collections.Generic;
using System.Text;

namespace Revision
{
    internal class DataInMemoryContext
    {
        public List<Category> Categories { get; set; } = [];
        public List<Book> Books { get; set; } = [];
        public List<User> Users { get; set; } = [];
    }
}
