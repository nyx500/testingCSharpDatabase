    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.SqlServer;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using TestingSQLRelationships.Models;
    using System.Reflection.Emit;

namespace TestingSQLRelationships.Data
{
    public class ApplicationDbContext: IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        // public DbSet<User> Users { get; set; }
        public DbSet<NaturalLanguage> NaturalLanguages { get; set; }
        //public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        //public DbSet<CSInterest> CSInterests { get; set; }
        //public DbSet<Hobby> Hobbies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(u => u.SlackId)
                .HasName("User_SlackId");

            modelBuilder.Entity<User>()
                .Property(u => u.CareerPhase);

            modelBuilder.Entity<User>()
                .Property(u => u.ExperienceLevel);

            modelBuilder.Entity<User>()
                .Property(u => u.ExperienceLevel);

            modelBuilder.Entity<User>()
                .Property(u => u.Bio);

            modelBuilder.Entity<User>()
                .Property(u => u.Gender);

            modelBuilder.Entity<NaturalLanguage>()
                .Property(n => n.NaturalLanguageId);

            modelBuilder.Entity<NaturalLanguage>()
                .Property(n => n.Name);

            modelBuilder.Entity<NaturalLanguageUser>()
                .HasKey(nu => new { nu.SlackId, nu.NaturalLanguageId });

            modelBuilder.Entity<NaturalLanguageUser>()
                .HasOne(nu => nu.User)
                .WithMany(u => u.NaturalLanguageUsers)
                .HasForeignKey(nu => nu.SlackId);

            modelBuilder.Entity<NaturalLanguageUser>()
                .HasOne(nu => nu.NaturalLanguage)
                .WithMany(n => n.NaturalLanguageUsers)
                .HasForeignKey(nu => nu.NaturalLanguageId);

            foreach (int i in Enum.GetValues(typeof(EnumsForUser.NaturalLanguageName)))
            {
                var enumLanguage = (EnumsForUser.NaturalLanguageName)i;

                string enumAsString = enumLanguage.ToString();

                modelBuilder.Entity<NaturalLanguage>().HasData(
                    new NaturalLanguage
                    {
                        // Start first Id with '1' not '0'
                        NaturalLanguageId = (i + 1),
                        Name = enumAsString
                    }
                );
            }

            modelBuilder.Entity<User>().HasData(
                            new User
                            {   
                                SlackId = "U73VQP71",
                                CareerPhase = EnumsForUser.CareerPhase.Developer,
                                ExperienceLevel = EnumsForUser.ExperienceLevel.Intermediate,
                                Bio = "Hello, my name is John. I am interested in AI.",
                                Gender = EnumsForUser.Gender.Male
                            }
                        );

            // Set up many-to-many relationship
            modelBuilder.Entity<NaturalLanguageUser>().HasData(
                    new NaturalLanguageUser { SlackId = "U73VQP71", NaturalLanguageId = 89 }
                );
            modelBuilder.Entity<NaturalLanguageUser>().HasData(
                    new NaturalLanguageUser { SlackId = "U73VQP71", NaturalLanguageId = 28 }
                );
            modelBuilder.Entity<NaturalLanguageUser>().HasData(
                    new NaturalLanguageUser { SlackId = "U73VQP71", NaturalLanguageId = 45 }
                );
        }
    }
}
