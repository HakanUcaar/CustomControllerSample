using CustomControllerSample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomControllerSample
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserModelOne> ModelOne { get; set; }
        public DbSet<UserModelTwo> ModelTwo { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserModelOne>().ToTable("User").HasKey("Id");
            modelBuilder.Entity<UserModelTwo>().ToTable("User").HasKey("Id");
        }
    }
}
