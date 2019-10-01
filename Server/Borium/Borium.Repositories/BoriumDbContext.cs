using Borium.Application.Utils;
using Borium.DomainModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace Borium.Repositories
{
    public class BoriumDbContext : DbContext
    {
        private readonly string _connectionString;

        public BoriumDbContext(CommandConnectionStringWrapper wrapper)
        {
            _connectionString = wrapper.Value;
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Epoch> Epoches { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Work> Works { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
