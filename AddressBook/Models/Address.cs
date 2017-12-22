﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Description { get; set; }
        public string Addresstype { get; set; }
        public virtual List<Person> Persons { get; set; } = new List<Person>();
    }

}