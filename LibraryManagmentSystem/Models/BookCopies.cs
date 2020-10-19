using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagmentSystem.Models
{
    public class BookCopies
    {
        public int BranchId { get; set; }
        public int BookId { get; set; }
        public int CopiesAvailable { get; set; }
    }
}