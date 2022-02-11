using FullStack_Task.Areas.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FullStack_Task.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>, IApplicationDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Salutation> Salutetions { get; set; }
        public DbSet<BusinessArea> BusinessAreas { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<ApplicationUserRole> UsersRoles { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<ApplicationRole> Roles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Relationships


            base.OnModelCreating(modelBuilder);



            // Create Test Data

            // Create Test Salutaions
            var salutation = new Salutation() { ID = 1, Name = "Salutation 1" };
            modelBuilder.Entity<Salutation>().HasData(
                salutation
            );
            modelBuilder.Entity<Salutation>().HasData(
                new Salutation() { ID = 2, Name = "Salutation 2" }
            );
            modelBuilder.Entity<Salutation>().HasData(
                new Salutation() { ID = 3, Name = "Salutation 3" }
            );
            modelBuilder.Entity<Salutation>().HasData(
                new Salutation() { ID = 4, Name = "Salutation 4" }
            );
            modelBuilder.Entity<Salutation>().HasData(
                new Salutation() { ID = 5, Name = "Salutation 5" }
            );

            // Create Address
            var address = new Address() 
            { 
                ID = 1,
                Country = "Greece",
                OfficeName = "Home",
                State = "Fleming",
                PostalCode = "16673",
                City = "Athens",
                Street = "Attica"
            };
            modelBuilder.Entity<Address>().HasData(
                address
            );


            // Create One User And One Role
            var hasher = new PasswordHasher<ApplicationUser>();
            const string USER_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ROLE_ID = "ad376a8f-9eab-4bb9-9fca-30b01540f445";

            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole()
                {
                    Id = ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser()
                {
                    Id = USER_ID,
                    SalutationId = 1,
                    FirstName = "Alexandros",
                    LastName = "Platanios",
                    MiddleName = "",
                    Company = "Alexandros Platanios",
                    Title = "Software Developer",
                    AcceptTerms = true,
                    Email = "alexandrosplatanios15@gmail.com",
                    NormalizedEmail = "alexandrosplatanios15@gmail.com",
                    UserName = "alexandrosplatanios15@gmail.com",
                    NormalizedUserName = "alexandrosplatanios15@gmail.com",
                    PhoneNumber = "6949277783",
                    Mobile = "6949277783",
                    Fax = "6949277783",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    PasswordHash = hasher.HashPassword(null, "-Platanios719791"),
                    SecurityStamp = string.Empty,
                    Password = "-Platanios719791"
                }
            );

            // Connect this User with this Role
            modelBuilder.Entity<ApplicationUserRole>().HasData(
                new ApplicationUserRole()
                {
                RoleId = ROLE_ID,
                UserId = USER_ID
                }
            );

            




            // Create Buisness Areas
            modelBuilder.Entity<BusinessArea>().HasData(new List<BusinessArea>()
            {
                new BusinessArea()
                {
                    ID = 1,
                    Name = "Finance"
                },
                new BusinessArea()
                {
                    ID = 2,
                    Name = "Operations"
                },
                new BusinessArea()
                {
                    ID = 3,
                    Name = "IT"
                },
                new BusinessArea()
                {
                    ID = 4,
                    Name = "Sales"
                },
                new BusinessArea()
                {
                    ID = 5,
                    Name = "Administrative"
                },
                new BusinessArea()
                {
                    ID = 6,
                    Name = "Lagel"
                },
                new BusinessArea()
                {
                    ID = 7,
                    Name = "Marketing"
                },
            });




        }
    }
}
