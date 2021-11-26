using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _422_431_432_433_434.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DatatimeCreate { get; set; }
        public int RoleID { get; set; }
        public bool Status { get; set; }



    }
}
