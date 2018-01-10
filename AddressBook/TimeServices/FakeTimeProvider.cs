﻿using AddressBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.TimeServices
{
    public class FakeTimeProvider : ITimeProvider
    {
        private DateTime _now;
        public DateTime Now { get => _now; set => _now = value; }
    }
}
