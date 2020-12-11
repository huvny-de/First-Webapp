using First.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Data.EF
{
    public class FirstDbContext : DbContext
    {
        public FirstDbContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Products { set; get; }
    }
}
