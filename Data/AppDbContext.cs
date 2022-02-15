using ArtWebshop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtWebshop.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        /*public AppDbContext()
        {
        }*/

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public override DbSet<ApplicationUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedingUsers.seed(modelBuilder);
        }
    }
}
