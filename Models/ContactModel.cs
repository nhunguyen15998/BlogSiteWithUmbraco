using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSiteWithUmbraco.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public string Reply { get; set; }
        public int Status { get; set; }
    }
}