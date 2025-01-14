﻿using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistance.Context
{
    public  class ApplicationDbContext:DbContext
    {
        public DbSet<Product>Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(

                new Product() { Id = Guid.NewGuid(), Name = "Test", Quantity = 29, CreatedDate = DateTime.UtcNow });

            base.OnModelCreating(modelBuilder);
        }
    }
}
