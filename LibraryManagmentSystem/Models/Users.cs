using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagmentSystem.Models
{
    public class Users
    {
        public int UserId { get; }
        public string UserName { get; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public int RoleId { get;  }
    }
}