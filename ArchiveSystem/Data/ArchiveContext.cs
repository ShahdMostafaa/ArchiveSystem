using ArchiveSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net.Mail;
using System.Reflection.Emit;

namespace ArchiveSystem.Data
{
    public partial class ArchiveContext : DbContext
    {
        public ArchiveContext()
        {
        }

        public ArchiveContext(DbContextOptions<ArchiveContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for each entity in the database
        public virtual DbSet<_Attachment> Attachments { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<UserAcc> UserAccs { get; set; }
        public virtual DbSet<ListUserMes> ListUserMes { get; set; }
        public virtual DbSet<RemovedUser> RemoveUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"
                           Server=DESKTOP-C9LRUQP;
                           Database=Archive5.0;
                           Trusted_Connection=True;");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListUserMes>().HasKey(K => new { K.UserId, K.MessageId });
            modelBuilder.Entity<UserAcc>()
                .HasIndex(u => u.AcadMail)
                .IsUnique();
            // Configure composite primary key for ListUserMes entity
            modelBuilder.Entity<ListUserMes>().HasKey(K => new { K.UserId, K.MessageId });
        }
    }
}
