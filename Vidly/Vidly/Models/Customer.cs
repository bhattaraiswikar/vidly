﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public bool IssubscribedtoNewsLetter { get; set; }
        public MembershipTypes MembershipType { get; set; }
        public int MembershipTypeId { get; set; }

        public string Gender { get; set; }

    }
}