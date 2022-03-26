using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPITravel.Models
{
    public partial class TravelWebAPIDbContext : DbContext
    {
        public TravelWebAPIDbContext()
        {
        }

        public TravelWebAPIDbContext(DbContextOptions<TravelWebAPIDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Travel> Travel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-FRUHOFCD;Database=TravelWebAPI;Integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Travel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Besttime)
                    .HasColumnName("besttime")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
