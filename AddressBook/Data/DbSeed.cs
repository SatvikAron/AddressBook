using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            var adress = new Address() { Description = "He lives in Huddinge", Addresstype = "Apartment" };
            var bdress = new Address() { Description = "He lives in Stockholm", Addresstype = "Vila" };


            var aperson = new Person() { FirstName = "Aron", LasttName = "Satvik", Email = "aron@gmail.com", Address = adress };
            var bperson = new Person() { FirstName = "Jahurul", LasttName = "Sojib", Email = "jahurul@gmail.com", Address = bdress };

        }
    }
}
