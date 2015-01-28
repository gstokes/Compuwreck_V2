namespace Compwreck.Domain.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CompuwreckModel : DbContext
    {
        public CompuwreckModel()
            : base("name=CompuwreckEntities")
        {
        }

        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Shipwreck> Shipwrecks { get; set; }
        public virtual DbSet<Shipwreck_Photo_LK> Shipwreck_Photo_LK { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<County>()
                .Property(e => e.Location)
                .IsFixedLength();

            modelBuilder.Entity<County>()
                .HasMany(e => e.Shipwrecks)
                .WithOptional(e => e.County)
                .HasForeignKey(e => e.County_FK);

            modelBuilder.Entity<Event>()
                .Property(e => e.Event_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Shipwrecks)
                .WithOptional(e => e.Event)
                .HasForeignKey(e => e.Event_FK);

            modelBuilder.Entity<Photo>()
                .HasMany(e => e.Shipwreck_Photo_LK)
                .WithRequired(e => e.Photo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipwreck>()
                .Property(e => e.DateLost)
                .HasPrecision(0);

            modelBuilder.Entity<Shipwreck>()
                .HasMany(e => e.Locations)
                .WithRequired(e => e.Shipwreck)
                .HasForeignKey(e => e.Shipwreck_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipwreck>()
                .HasMany(e => e.Shipwreck_Photo_LK)
                .WithRequired(e => e.Shipwreck)
                .WillCascadeOnDelete(false);
        }
    }
}
