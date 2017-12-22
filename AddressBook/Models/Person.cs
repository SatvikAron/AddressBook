using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }

        public string LasttName { get; set; }

        public String Email { get; set; }
     
      
        public  List<Address> Addresses { get; set; }
}
}
