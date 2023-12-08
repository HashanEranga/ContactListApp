﻿using ContactListApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactListApp.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
