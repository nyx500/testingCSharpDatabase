    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.SqlServer;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using TestingSQLRelationships.Models;
    using TestingSQLRelationships.Data.ConfigurationFiles;
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
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        //public DbSet<CSInterest> CSInterests { get; set; }
        //public DbSet<Hobby> Hobbies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Sets up the properties included in the table for the User (IdentityUser) class
            //modelBuilder.Entity<User>() 
            //    .HasKey(u => u.SlackId) // SlackId --> will be the User class Primary Key for linking tables in many-to-many relationships
            //    .HasName("User_SlackId");
            //modelBuilder.Entity<User>()
            //    .Property(u => u.CareerPhase);
            //modelBuilder.Entity<User>()
            //    .Property(u => u.ExperienceLevel);
            //modelBuilder.Entity<User>()
            //    .Property(u => u.ExperienceLevel);
            //modelBuilder.Entity<User>()
            //    .Property(u => u.Bio);
            //modelBuilder.Entity<User>()
            //    .Property(u => u.Gender);
            modelBuilder.ApplyConfiguration(new UserConfig());

            // Sets up the Id and Name properties for the Language tables (natural and programming languages)
            //modelBuilder.Entity<NaturalLanguage>()
            //    .Property(n => n.NaturalLanguageId);
            //modelBuilder.Entity<NaturalLanguage>()
            //    .Property(n => n.Name);
            //modelBuilder.Entity<ProgrammingLanguage>()
            //   .Property(n => n.ProgrammingLanguageId);
            //modelBuilder.Entity<ProgrammingLanguage>()
            //    .Property(n => n.Name);

            modelBuilder.ApplyConfiguration(new NaturalLanguageConfig());
            modelBuilder.ApplyConfiguration(new ProgrammingLanguageConfig());
            modelBuilder.ApplyConfiguration(new CSInterestConfig());


            // Set up many-to-many relationship between natural/programming languages and Users
            //// Natural Languages
            //modelBuilder.Entity<NaturalLanguageUser>()
            //    .HasKey(nu => new { nu.SlackId, nu.NaturalLanguageId });
            //modelBuilder.Entity<NaturalLanguageUser>()
            //    .HasOne(nu => nu.User)
            //    .WithMany(u => u.NaturalLanguageUsers)
            //    .HasForeignKey(nu => nu.SlackId);
            //modelBuilder.Entity<NaturalLanguageUser>()
            //    .HasOne(nu => nu.NaturalLanguage)
            //    .WithMany(n => n.NaturalLanguageUsers)
            //    .HasForeignKey(nu => nu.NaturalLanguageId);
            modelBuilder.ApplyConfiguration(new NaturalLanguageUserConfig());
            // Programming Languages: many-to-many language/user setup
            //modelBuilder.Entity<ProgrammingLanguageUser>()
            //    .HasKey(pu => new { pu.SlackId, pu.ProgrammingLanguageId });
            //modelBuilder.Entity<ProgrammingLanguageUser>()
            //    .HasOne(pu => pu.User)
            //    .WithMany(u => u.ProgrammingLanguageUsers)
            //    .HasForeignKey(pu => pu.SlackId);
            //modelBuilder.Entity<ProgrammingLanguageUser>()
            //    .HasOne(pu => pu.ProgrammingLanguage)
            //    .WithMany(p => p.ProgrammingLanguageUsers)
            //    .HasForeignKey(pu => pu.ProgrammingLanguageId);
            modelBuilder.ApplyConfiguration(new ProgrammingLanguageUserConfig());

            modelBuilder.ApplyConfiguration(new CSInterestUserConfig());

            // Creates the Natural Language table in DB using the enum storing all the language names
            //foreach (int i in Enum.GetValues(typeof(EnumsForUser.NaturalLanguageName)))
            //{
            //    var enumLanguage = (EnumsForUser.NaturalLanguageName)i;

            //    string enumAsString = enumLanguage.ToString();

            //    modelBuilder.Entity<NaturalLanguage>().HasData(
            //        new NaturalLanguage
            //        {
            //            // Initializes the first Id with '1' instead of '0'
            //            NaturalLanguageId = (i + 1),
            //            Name = enumAsString
            //        }
            //    );
            //}

            // Creates the Programming Language table in the DB using the enum storing all programming language names
            //foreach (int i in Enum.GetValues(typeof(EnumsForUser.ProgrammingLanguageName)))
            //{
            //    var enumLanguage = (EnumsForUser.ProgrammingLanguageName)i;

            //    string enumAsString = enumLanguage.ToString();

            //    modelBuilder.Entity<ProgrammingLanguage>().HasData(
            //        new ProgrammingLanguage
            //        {
            //            // Initializes the first Id with '1' instead of '0'
            //            ProgrammingLanguageId = (i + 1),
            //            Name = enumAsString
            //        }
            //    );
            //}


            // Creates a test User and stores it in the User table in the DB
            //modelBuilder.Entity<User>().HasData(
            //                new User
            //                {   
            //                    SlackId = "U73VQP71",
            //                    CareerPhase = EnumsForUser.CareerPhase.Developer,
            //                    ExperienceLevel = EnumsForUser.ExperienceLevel.Intermediate,
            //                    Bio = "Hello, my name is John. I am interested in AI.",
            //                    Gender = EnumsForUser.Gender.Male
            //                }
            //            );

            // Sets up many-to-many relationship bectween the test user and their spoken/known languages
            //modelBuilder.Entity<NaturalLanguageUser>().HasData(
            //        new NaturalLanguageUser { SlackId = "U73VQP71", NaturalLanguageId = 89 }
            //    );
            //modelBuilder.Entity<NaturalLanguageUser>().HasData(
            //        new NaturalLanguageUser { SlackId = "U73VQP71", NaturalLanguageId = 28 }
            //    );
            //modelBuilder.Entity<NaturalLanguageUser>().HasData(
            //        new NaturalLanguageUser { SlackId = "U73VQP71", NaturalLanguageId = 45 }
            //    );
            //modelBuilder.Entity<ProgrammingLanguageUser>().HasData(
            //       new ProgrammingLanguageUser { SlackId = "U73VQP71", ProgrammingLanguageId = 3 }
            //   );
            //modelBuilder.Entity<ProgrammingLanguageUser>().HasData(
            //        new ProgrammingLanguageUser { SlackId = "U73VQP71", ProgrammingLanguageId = 5 }
            //    );
            //modelBuilder.Entity<ProgrammingLanguageUser>().HasData(
            //        new ProgrammingLanguageUser { SlackId = "U73VQP71", ProgrammingLanguageId = 6 }
            //    );
        }
    }
}
