using Microsoft.EntityFrameworkCore;
using TodosAPI.Infrastructure.Data.Entities;

namespace TodosAPI.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }

        private readonly string _path;

        public DataContext()
        {
            _path = Path.Combine(Environment.CurrentDirectory, "database.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Filename={_path}");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Todo>().ToTable("Todos");
            builder.Entity<User>().ToTable("Users");
        }
    }
}
