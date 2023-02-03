﻿// Stores a separate configuration class for the User entity which is used in the OnModelCreating() method in the ApplicationDbContext class

using Microsoft.EntityFrameworkCore;
using TestingSQLRelationships.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Linq;

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

            entity.Property(u => u.Bio);

            // Set up many-to-one relationships
            entity.HasOne(u => u.Gender).WithMany(g => g.Users);

            entity.HasOne(u => u.ExperienceLevel).WithMany(e => e.Users);

            entity.HasOne(u => u.CareerPhase).WithMany(c => c.Users);

            // Seeds DB with test users
            entity.HasData(
                 new User
                 {
                     SlackId = "U73VQP71",
                     Bio = "Hello, my name is John. I am interested in AI.",
                     GenderId = 1,
                     CareerPhaseId = 2,
                     ExperienceLevelId = 2
                 },
                 new User
                 {
                     SlackId = "8UJBW6F3",
                     Bio = "Hello, my name is Amanda. I am interested in VR.",
                     GenderId = 2,
                     CareerPhaseId = 1,
                     ExperienceLevelId = 2
                 }
            ); ;
        }
    }
}
