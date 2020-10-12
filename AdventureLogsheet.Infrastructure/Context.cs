using System;
using System.Collections.Generic;
using System.Text;
using AdventureLogsheet.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdventureLogsheet.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Logsheet> Logsheets { get; set; }
        public DbSet<Adventure> Adventures { get; set; }
        public DbSet<AdventureCheckpoints> AdventureCheckpoints { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<Downtime> Downtime { get; set; }
        public DbSet<Gold> Gold { get; set; }
        public DbSet<Renown> Renown { get; set; }
        public DbSet<TreasureCheckpoints> TreasureCheckpoints { get; set; }
        public Context(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Logsheet>()
                .HasMany(a => a.Characters).WithOne(b => b.Logsheet)
                .HasForeignKey(e => e.LogsheetId);
            builder.Entity<Character>()
                .HasMany(a => a.CharacterClasses).WithOne(b => b.Character)
                .HasForeignKey(e => e.CharacterId);
            builder.Entity<Character>()
                .HasMany(a => a.Adventures).WithOne(b => b.Character)
                .HasForeignKey(e => e.CharacterId);
            builder.Entity<Adventure>()
                .HasOne(a => a.AdventureCheckpoints).WithOne(b => b.Adventure)
                .HasForeignKey<AdventureCheckpoints>(e => e.AdventureRef);
            builder.Entity<Adventure>()
                .HasOne(a => a.Gold).WithOne(b => b.Adventure)
                .HasForeignKey<AdventureCheckpoints>(e => e.AdventureRef);
            builder.Entity<Adventure>()
                .HasOne(a => a.Downtime).WithOne(b => b.Adventure)
                .HasForeignKey<AdventureCheckpoints>(e => e.AdventureRef);
            builder.Entity<Adventure>()
                .HasOne(a => a.Renown).WithOne(b => b.Adventure)
                .HasForeignKey<AdventureCheckpoints>(e => e.AdventureRef);
            builder.Entity<Adventure>()
                .HasOne(a => a.TreasureCheckpoints).WithOne(b => b.Adventure)
                .HasForeignKey<AdventureCheckpoints>(e => e.AdventureRef);
        }

    }
}
