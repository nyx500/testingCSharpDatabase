// Stores a separate configuration class for the User entity which is used in the OnModelCreating() method in the ApplicationDbContext class

using Microsoft.EntityFrameworkCore;
using TestingSQLRelationships.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace TestingSQLRelationships.Data.ConfigurationFiles
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {   
        // We must override the Configure method in the IEntityTypeConfiguration interface here
        public void Configure(EntityTypeBuilder<User> entity)
        {
            // Cleans up code in moderlBuilder in the ApplicationDbContext by storing it here instead
            // Sets up the properties included in the table for the User (IdentityUser) class
            entity.HasKey(u => u.SlackId) // SlackId --> will be the User class Primary Key for linking tables in many-to-many relationships
                .HasName("User_SlackId");

            entity.Property(u => u.CareerPhase);
            entity.Property(u => u.ExperienceLevel);
            entity.Property(u => u.ExperienceLevel);
            entity.Property(u => u.Bio);
            entity.Property(u => u.Gender);

            // Seed DB with a test user
            entity.HasData(
                 new User
                 {
                     SlackId = "U73VQP71",
                     CareerPhase = EnumsForUser.CareerPhase.Developer,
                     ExperienceLevel = EnumsForUser.ExperienceLevel.Intermediate,
                     Bio = "Hello, my name is John. I am interested in AI.",
                     Gender = EnumsForUser.Gender.Male
                 }
            );
        }
    }
}
