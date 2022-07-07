using Microsoft.EntityFrameworkCore;
using SocialNetwork.Core.Domain.Common;
using SocialNetwork.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocialNetwork.Infrastucture.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        // Setters
        public DbSet<UserModel> Users { get; set; }
        public DbSet<PublicationModel> Publications { get; set; }

        // Automatically fill auditable model
        public override Task<int> SaveChangesAsync(CancellationToken cancelationToken = new CancellationToken())
        {
            foreach(var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State) 
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastUpdate = DateTime.Now;
                        entry.Entity.LastUpdateBy = "DefaultAppUser";
                        break;
                }
            }

            return base.SaveChangesAsync(cancelationToken);
        }

        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region tables
            modelBuilder.Entity<UserModel>().ToTable("Users");
            modelBuilder.Entity<PublicationModel>().ToTable("Publications");
            #endregion

            #region primary keys
            modelBuilder.Entity<UserModel>().HasKey(user => user.Id);
            modelBuilder.Entity<PublicationModel>().HasKey(publication => publication.Id);
            #endregion

            #region relationships
            modelBuilder.Entity<UserModel>()
                .HasMany(user => user.Publications)
                .WithOne(publication => publication.User)
                .HasForeignKey(publication => publication.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region property configs

            #region users
            modelBuilder.Entity<UserModel>()
                .Property(user => user.Name)
                .IsRequired();

            modelBuilder.Entity<UserModel>()
                .Property(user => user.LastName)
                .IsRequired();

            modelBuilder.Entity<UserModel>()
                .Property(user => user.Email)
                .IsRequired();

            modelBuilder.Entity<UserModel>()
                .Property(user => user.PhoneNumber)
                .IsRequired();

            modelBuilder.Entity<UserModel>()
                .Property(user => user.UserName)
                .IsRequired();

            modelBuilder.Entity<UserModel>()
                .Property(user => user.Password)
                .IsRequired();
            #endregion

            #region publications
            modelBuilder.Entity<PublicationModel>()
                .Property(publication => publication.Caption)
                .IsRequired();
            #endregion

            #endregion
        }
    }
}
