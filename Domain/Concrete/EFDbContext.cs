﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    class EFDbContext:DbContext
    {
        public DbSet<User> Users { get; set;}
    }
}
