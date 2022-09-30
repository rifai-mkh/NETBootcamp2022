﻿using System;
using System.Collections.Generic;

namespace ScaffoldDatabaseFirst.Models
{
    public partial class Samurai
    {
        public Samurai()
        {
            Quotes = new HashSet<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Quote> Quotes { get; set; }
    }
}
