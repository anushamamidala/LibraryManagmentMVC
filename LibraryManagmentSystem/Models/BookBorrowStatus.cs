using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagmentSystem.Models
{
    public class BookBorrowStatus
    {
        public int BorrowId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int BranchId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public string Comments { get; set; }
    }
}