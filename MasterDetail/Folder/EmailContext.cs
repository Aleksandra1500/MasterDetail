using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Folder
{
    public class EmailContext : DbContext
    {
        public EmailContext() { }
        public DbSet<AdrEwid> adr__Ewid { get; set; }
        public DbSet<AdrEmail> adr_Email { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("C:\\Users\\Alex_\\OneDrive\\Dokumenty\\Staż\\MasterDetail\\MasterDetail\\cnstring.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("cnS"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdrEmail>()
                .HasOne<AdrEwid>(c => c.AdrEwid)
                .WithMany(e => e.AdrEmails)
                .HasForeignKey(e => e.am_IdAdres);
        }
    }
}
