using FullStack_Task.Areas.Identity.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack_Task.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<BusinessArea> BusinessAreas { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Salutation> Salutetions { get; set; }
    }
}