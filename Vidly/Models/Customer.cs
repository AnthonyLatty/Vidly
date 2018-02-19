﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        // Navigation type or association between customer and membership
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; } // Foriegn key in entity framework
    }
}