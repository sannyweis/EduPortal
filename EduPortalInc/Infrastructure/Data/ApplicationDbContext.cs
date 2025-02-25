
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Application.Interfaces.Common;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;


namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Добавление DbSet для UserProfile
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}