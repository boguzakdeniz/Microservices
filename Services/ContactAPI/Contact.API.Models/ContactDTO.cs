using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Models
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public String FullName  => $"{FirstName} {LastName}";
    }
}
