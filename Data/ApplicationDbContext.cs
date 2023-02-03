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
        public DbSet<CSInterest> CSInterests { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<NaturalLanguageUser> NaturalLanguageUsers { get; set; }
        public DbSet<ProgrammingLanguageUser> ProgrammingLanguageUsers { get; set; }
        public DbSet<CSInterestUser> CSInterestUsers { get; set; }
        public DbSet<HobbyUser> HobbyUsers { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Rejections> Rejections { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionAnswerBlock> QuestionAnswerBlocks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Sets up the properties included in the table for the User (IdentityUser) class
            modelBuilder.ApplyConfiguration(new UserConfig());


            modelBuilder.ApplyConfiguration(new GenderConfig());
            modelBuilder.ApplyConfiguration(new CareerPhaseConfig());
            modelBuilder.ApplyConfiguration(new ExperienceLevelConfig());
            modelBuilder.ApplyConfiguration(new NaturalLanguageConfig());
            modelBuilder.ApplyConfiguration(new ProgrammingLanguageConfig());
            modelBuilder.ApplyConfiguration(new CSInterestConfig());
            modelBuilder.ApplyConfiguration(new HobbyConfig());
            modelBuilder.ApplyConfiguration(new QuestionConfig());



            // Set up many-to-many relationship between natural/programming languages and Users
            modelBuilder.ApplyConfiguration(new NaturalLanguageUserConfig());
            modelBuilder.ApplyConfiguration(new ProgrammingLanguageUserConfig());
            modelBuilder.ApplyConfiguration(new CSInterestUserConfig());
            modelBuilder.ApplyConfiguration(new HobbyUserConfig());
            modelBuilder.ApplyConfiguration(new LikesConfig());
            modelBuilder.ApplyConfiguration(new RejectionsConfig());
            modelBuilder.ApplyConfiguration(new QuestionAnswerBlockConfig());


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
