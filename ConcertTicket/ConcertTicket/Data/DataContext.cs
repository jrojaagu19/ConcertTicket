using ConcertTicket.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcertTicket.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Entrance> Entrances { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entrance>().HasIndex(t => t.Id).IsUnique();
            modelBuilder.Entity<Ticket>().HasIndex("EntranceId").IsUnique();


        }

    }
}
