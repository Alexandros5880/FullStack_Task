using FullStack_Task.Areas.Identity.Models;
using FullStack_Task.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FullStack_Task.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>, IApplicationDbContext
    {
        public DbSet<Salutation> Salutetions { get; set; }
        public DbSet<BusinessArea> BusinessAreas { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<ApplicationUser>()
            //                    .HasOne(u => u.Address)
            //                    .WithOne()
            //                    .HasForeignKey<ApplicationUser>("AddressId")
            //                    .OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<Address>()
            //                    .HasOne(a => a.User)
            //                    .WithOne()
            //                    .HasForeignKey<Address>("UserId")
            //                    .OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<ApplicationUser>()
            //                    .HasOne(u => u.Comment)
            //                    .WithOne()
            //                    .HasForeignKey<ApplicationUser>("CommentId")
            //                    .OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<Comment>()
            //                    .HasOne(c => c.User)
            //                    .WithOne()
            //                    .HasForeignKey<Comment>("UserId")
            //                    .OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<ApplicationUser>()
            //                    .HasMany(u => u.BusinessAreas)
            //                    .WithMany(b => b.Users);
            //modelBuilder.Entity<BusinessArea>()
            //                    .HasMany(b => b.Users)
            //                    .WithMany(b => b.BusinessAreas);

            //modelBuilder.Entity<ApplicationUser>()
            //                    .HasOne(u => u.Salutation)
            //                    .WithMany(s => s.Users)
            //                    .OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<Salutation>()
            //                    .HasMany(s => s.Users)
            //                    .WithOne()
            //                    .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
