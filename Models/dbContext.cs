

using Microsoft.EntityFrameworkCore;

namespace MVC.Models
{
    public class DataDbContext : DbContext
    {

        public DbSet<Users> Users { get; set; }
        public DbSet<Conversations> Conversations { get; set; }
        public DbSet<EmailDetail> EmailDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=UserMailCopy;user=root;password=12345");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Username);
                entity.Property(e => e.Pass);
            });
            modelBuilder.Entity<Conversations>(entity =>
           {

               entity.HasKey(e => e.id);
               entity.Property(e => e.content);
               entity.Property(e => e.state);
               entity.Property(e => e.mailDate);
               entity.Property(e => e.title);
           });
            modelBuilder.Entity<EmailDetail>(entity =>
            {
                entity.HasKey(ed => ed.EmailDetailId);
                entity.Property(ed => ed.conversationId);
                entity.Property(ed => ed.senderId);
                entity.Property(ed => ed.receiverId);
                // entity.HasKey(ed => ed.checkInbox);
                // entity.HasKey(ed => ed.checkReceiver);
                // entity.Property(x => x.checkInbox).IsUnique(true);
                entity.Property(x => x.checkReceiver);
                entity.Property(x => x.checkInbox);
                // entity.HasOne<Conversations>(md => md.conversations).WithMany(u => u.emailDetails).HasForeignKey(md => md.conversationId);
            });

        }
    }
}