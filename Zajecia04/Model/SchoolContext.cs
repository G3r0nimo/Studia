﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia04.Model
{
    class SchoolContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
