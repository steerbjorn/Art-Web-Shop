using ArtWebshop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Data
{
    public static class SeedingUsers
    {
        
        public static void seed(ModelBuilder modelBuilder)
        {
            string roleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = roleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = roleId
                });

            var adminUser = new ApplicationUser
            {
                Id = userId,
                FirstName = "TestUserAdmin",
                LastName = "SuperUser",
                Email = "admin@site.com",
                NormalizedEmail = "ADMIN@SITE.COM",
                EmailConfirmed = true,
                UserName = "admin@site.com",
                NormalizedUserName = "ADMIN@SITE.COM",
                BillingStreetName = "Hemadress 1",
                BillingPostalCode = "12345",
                BillingCity = "Göteborg",
                BillingCountry = "Sverige"
            };

            PasswordHasher<ApplicationUser> pH = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = pH.HashPassword(adminUser, "admin");

            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = userId
                });

            roleId = Guid.NewGuid().ToString();
            userId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                 new IdentityRole
                 {
                     Id = roleId,
                     Name = "Vendor",
                     NormalizedName = "VENDOR",
                     ConcurrencyStamp = roleId
                 });

            var vendorUser = new ApplicationUser
            {
                Id = userId,
                FirstName = "TestUserVendor",
                LastName = "Admin",
                Email = "vendor@site.com",
                NormalizedEmail = "VENDOR@SITE.COM",
                EmailConfirmed = true,
                UserName = "vendor@site.com",
                NormalizedUserName = "VENDOR@SITE.COM",
                BillingStreetName = "Hemadress 1",
                BillingPostalCode = "12345",
                BillingCity = "Göteborg",
                BillingCountry = "Sverige"
            };


            vendorUser.PasswordHash = pH.HashPassword(vendorUser, "vendor");

            modelBuilder.Entity<ApplicationUser>().HasData(vendorUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = userId
                });

            roleId = Guid.NewGuid().ToString();
            userId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
               new IdentityRole
               {
                   Id = roleId,
                   Name = "User",
                   NormalizedName = "USER",
                   ConcurrencyStamp = roleId
               });

            var customerUser = new ApplicationUser
            {
                Id = userId,
                FirstName = "TestUserCustomer",
                LastName = "Buy",
                Email = "customer@site.com",
                NormalizedEmail = "CUSTOMER@SITE.COM",
                EmailConfirmed = true,
                UserName = "customer@site.com",
                NormalizedUserName = "CUSTOMER@SITE.COM",
                BillingStreetName = "Hemadress 1",
                BillingPostalCode = "12345",
                BillingCity = "Göteborg",
                BillingCountry = "Sverige"
            };


            customerUser.PasswordHash = pH.HashPassword(customerUser, "customer");

            modelBuilder.Entity<ApplicationUser>().HasData(customerUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = userId
                });

            roleId = Guid.NewGuid().ToString();
            userId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = roleId,
                    Name = "Artist",
                    NormalizedName = "ARTIST",
                    ConcurrencyStamp = roleId
                });

            var artistUser = new ApplicationUser
            {
                Id = userId,
                FirstName = "TestUserArtist",
                LastName = "Upload",
                Email = "artist@site.com",
                NormalizedEmail = "ARTIST@SITE.COM",
                EmailConfirmed = true,
                UserName = "artist@site.com",
                NormalizedUserName = "ARTIST@SITE.COM",
                BillingStreetName = "Hemadress 1",
                BillingPostalCode = "12345",
                BillingCity = "Göteborg",
                BillingCountry = "Sverige"
            };


            artistUser.PasswordHash = pH.HashPassword(artistUser, "artist");

            modelBuilder.Entity<ApplicationUser>().HasData(artistUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = userId
                });
        }
    }
}