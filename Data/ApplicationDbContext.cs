using DailyRoutineApp.Models;
using Microsoft.EntityFrameworkCore;


namespace DailyRoutineApp.Data 
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure one-to-many relationship
            modelBuilder.Entity<TodoItem>()
                .HasOne(t => t.User)
                .WithMany(u => u.TodoItems)
                .HasForeignKey(t => t.UserId);
        }

    }
}