﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VitecAPI.Models
{
    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options)
             : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
