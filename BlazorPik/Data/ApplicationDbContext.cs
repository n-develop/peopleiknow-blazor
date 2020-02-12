using BlazorPik.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorPik.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<EmailAddress> EmailAddresses { get; set; }

        public DbSet<Relationship> Relationships { get; set; }

        public DbSet<StatusUpdate> StatusUpdates { get; set; }

        public DbSet<TelephoneNumber> TelephoneNumbers { get; set; }
    }
}
