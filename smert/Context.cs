﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace smert
{
    class Context : DbContext
    {

        public DbSet<Event> Events { get; set; }

        public Context() : base ("DefaultConnection") { }

    }
}
