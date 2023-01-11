using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VRMission;

namespace VR.Data.Data
{
    public class VRApiContext : DbContext
    {
        public VRApiContext (DbContextOptions<VRApiContext> options)
            : base(options)
        {
        }

        public DbSet<VRMission.Person> Person { get; set; } = default!;

        public DbSet<VRMission.Mission> Mission { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FluentAPI goes here
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>()
                .HasMany(s => s.Missions)
                .WithMany(c => c.Persons)
                .UsingEntity<Message>(
                    e => e.HasOne(e => e.Mission).WithMany(c => c.Messages),
                    e => e.HasOne(e => e.Person).WithMany(s => s.Messages));
        }
    }
}
