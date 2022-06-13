using Microsoft.EntityFrameworkCore;
using Eterna.Models;


namespace Eterna.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AnotherSettings>()
                .HasIndex(u => u.Key)
                .IsUnique();
            base.OnModelCreating(builder);
        }
        public DbSet<Connect> Connects { get; set; }
        public DbSet<AnotherSettings> Settings { get; set; }
        public DbSet <FooterIcon>FooterIcons{ get; set; }
        public DbSet<FooterSocialMedias> FooterSocialMedias { get; set; }
        public DbSet<HeaderSocialMedias> HeaderSocialMedias { get; set; }
        public DbSet<Settings>Setting { get; set; }
        public DbSet<Slider> Sliders { get; set; }


    }
}
